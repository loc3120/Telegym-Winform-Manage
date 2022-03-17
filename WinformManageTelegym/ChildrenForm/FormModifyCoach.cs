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
    public partial class FormModifyCoach : Form
    {
        private readonly User u;
        public FormModifyCoach()
        {
            InitializeComponent();
        }
        public FormModifyCoach(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbName.Text.Trim().Equals("") || txbPhoneNum.Text.Trim().Equals("") || txbEmail.Text.Trim().Equals("") || txbDescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = modifySync();
            }
        }
        private async Task modifySync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/modify";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            Coach coach = new Coach();
            coach.name = txbName.Text;
            coach.dateOfBirth = dtpDateOfBirth.Value;
            coach.email = txbEmail.Text;
            coach.phone_number = txbPhoneNum.Text;
            coach.description = txbDescription.Text;

            String data = JsonConvert.SerializeObject(coach);

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
