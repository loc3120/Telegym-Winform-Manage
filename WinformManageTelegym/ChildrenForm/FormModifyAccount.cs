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
    public partial class FormModifyAccount : Form
    {
        private readonly string prefixURL = "user";
        private readonly string prefixURL2 = "auth";
        private readonly User u;
        private User userModified;
        public FormModifyAccount()
        {
            InitializeComponent();
        }
        public FormModifyAccount(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        public FormModifyAccount(User u, User userModified)
        {
            this.u = u;
            this.userModified = userModified;
            InitializeComponent();
        }

        private void FormModifyAccount_Load(object sender, EventArgs e)
        {
            if (userModified != null)
            {
                txbUsername.Text = userModified.username;
                txbName.Text = userModified.name;
                if (userModified.role == "ROLE_STAFF")
                {
                    cbbRole.SelectedIndex = 0;
                }
                else
                {
                    cbbRole.SelectedIndex = 1;
                }
                txbUsername.ReadOnly = true;
            }
            else
            {
                cbbRole.SelectedIndex = 0;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không thể để trống", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txbPass.Text.Equals(txbConfirmPass.Text))
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userModified == null)
            {
                _ = createSync();
            }
            else
            {
                _ = updateSync();
            }
        }

        private async Task updateSync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/update";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            User user = new User
            {
                id = userModified.id,
                pass = txbPass.Text,
                name = txbName.Text
            };
            if (cbbRole.SelectedIndex == 0)
            {
                user.role = "staff";
            }
            else
            {
                user.role = "admin";
            }
            String data = JsonConvert.SerializeObject(user);

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
        private async Task createSync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL2 + "/signup";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };


            User user = new User
            {
                username = txbUsername.Text,
                pass = txbPass.Text,
                name = txbName.Text
            };
            if (cbbRole.SelectedIndex == 0)
            {
                user.role = "staff";
            }
            else
            {
                user.role = "admin";
            }
            String data = JsonConvert.SerializeObject(user);

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
