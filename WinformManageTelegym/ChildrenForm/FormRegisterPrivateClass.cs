using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformManageTelegym.Common;
using WinformManageTelegym.Entity;

namespace WinformManageTelegym.ChildrenForm
{
    public partial class FormRegisterPrivateClass : Form
    {
        private readonly User u;
        private readonly Customer c;
        public FormRegisterPrivateClass()
        {
            InitializeComponent();
        }
        public FormRegisterPrivateClass(User u, Customer c)
        {
            this.u = u;
            this.c = c;
            InitializeComponent();
        }
        private void FormRegisterPrivateClass_Load(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?search={0}", "")).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<Coach> listCoaches = JsonConvert.DeserializeObject<List<Coach>>(pds.data.ToString());
                    cbbCoachName.DataSource = listCoaches;
                    cbbCoachName.DisplayMember = "name";
                    cbbCoachName.ValueMember = "id";
                    cbbCoachName.SelectedIndex = 0;
                    lbPhoneNum.Text = c.phone_number;
                    lbCustomerName.Text = c.name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbName.Text.Equals("") || txbDescription.Text.Equals(""))
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numTotalSessions.Value == 0)
            {
                MessageBox.Show("Tổng số buổi phải lớn hơn 0", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = createSync();
            }
        }

        private async Task createSync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "pc/modify";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            PrivateClass pc = new PrivateClass();

            pc.name = txbName.Text;
            pc.description = txbDescription.Text;
            pc.number_sessions = (int) numTotalSessions.Value;
            pc.customer = c.id;
            pc.coach = cbbCoachName.SelectedValue.ToString();

            String data = JsonConvert.SerializeObject(pc);

            var content = new StringContent(data, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = await client.PostAsync(connectURL, content);
                string resultContent = await response.Content.ReadAsStringAsync();
                ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(rs.message.ToString(), "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rs.message.ToString(), "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
