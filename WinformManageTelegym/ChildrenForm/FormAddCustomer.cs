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
    public partial class FormAddCustomer : Form
    {
        private readonly User u;
        public FormAddCustomer()
        {
            InitializeComponent();
        }
        public FormAddCustomer(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "membershipcard/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync("").Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<MembershipCard> listCard = JsonConvert.DeserializeObject<List<MembershipCard>>(pds.data.ToString());

                    cbbMemberCard.DataSource = listCard;
                    cbbMemberCard.DisplayMember = "cardname";
                    cbbMemberCard.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbName.Text.Trim().Equals("") || txbPhoneNum.Text.Trim().Equals("") || txbEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = modifySync();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task modifySync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "customer/modify";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            Customer customer = new Customer();
            customer.name = txbName.Text;
            customer.phone_number = txbPhoneNum.Text;
            customer.email = txbEmail.Text;
            customer.time_enroll = dtpEnroll.Value;
            customer.time_expire = dtpExpire.Value;
            customer.membershipCard = cbbMemberCard.SelectedValue.ToString();
            customer.exercise_form = cbbExerciseForm.GetItemText(cbbExerciseForm.SelectedItem);

            String data = JsonConvert.SerializeObject(customer);

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
