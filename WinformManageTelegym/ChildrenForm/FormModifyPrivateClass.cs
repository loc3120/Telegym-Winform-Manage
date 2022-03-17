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
    public partial class FormModifyPrivateClass : Form
    {
        private readonly User u;
        private PrivateClass classModified;
        public FormModifyPrivateClass()
        {
            InitializeComponent();
        }
        public FormModifyPrivateClass(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        public FormModifyPrivateClass(User u, PrivateClass classModified)
        {
            this.u = u;
            this.classModified = classModified;
            InitializeComponent();
        }

        private void FormModifyPrivateClass_Load(object sender, EventArgs e)
        {
            if (classModified != null)
            {
                txbName.Text = classModified.name;
                numTotalSessions.Value = classModified.number_sessions;
                numRemainSessions.Value = classModified.remaining_sessions;
                txbDescription.Text = classModified.description;
            }
            else
            {
                cbbCoachName.SelectedIndex = 0;
            }
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/getall";
            string loadNameURL = ConfigURL.LOCAL_SERVICE_URL + "customer/detail";

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
                    cbbCoachName.SelectedValue = classModified.coach;

                    HttpClient client2 = new HttpClient
                    {
                        BaseAddress = new Uri(loadNameURL)
                    };
                    client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

                    HttpResponseMessage response2 = client2.GetAsync(string.Format("?id={0}", classModified.customer)).Result;
                    if (response2.IsSuccessStatusCode)
                    {
                        resultContent = response2.Content.ReadAsStringAsync().Result;
                        rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                        Customer customer = JsonConvert.DeserializeObject<Customer>(rs.dataResponse.ToString());
                        lbCustomerName.Text = customer.name;
                    }
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
            if (txbName.Text.Trim().Equals("") || txbDescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numTotalSessions.Value == 0)
            {
                MessageBox.Show("Sức chứa phải > 0", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = modifySync();
            }
        }
        private async Task modifySync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "pc/modify";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            PrivateClass pc = new PrivateClass();
            if (classModified != null)
            {
                pc.id = classModified.id;
            }
            pc.name = txbName.Text;
            pc.description = txbDescription.Text;
            pc.number_sessions = (int) numTotalSessions.Value;
            pc.remaining_sessions = (int) numRemainSessions.Value;
            pc.customer = 
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
                    MessageBox.Show(rs.message.ToString(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rs.message.ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
