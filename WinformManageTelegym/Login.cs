using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformManageTelegym.Common;
using WinformManageTelegym.Entity;

namespace WinformManageTelegym
{
    public partial class Login : Form
    {
        private readonly string prefixURL = "auth";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _ = LoginAccountAsync(txbUsername.Text, txbPassword.Text);
        }

        private async Task LoginAccountAsync(string username, string pass)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/signin";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

            SearchObject searchObject = new SearchObject()
            {
                str1 = username,
                str2 = pass
            };

            String data = JsonConvert.SerializeObject(searchObject);

            var content = new StringContent(data, Encoding.Default, "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = await client.PostAsync(connectURL, content);
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = await response.Content.ReadAsStringAsync();
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    User u = JsonConvert.DeserializeObject<User>(rs.dataResponse.ToString());
                    this.Visible = false;
                    FormManage fm = new FormManage(u);
                    fm.ShowDialog();
                }
                else
                {
                    lbNoti.Visible = true;
                    txbUsername.Text = "";
                    txbPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                this.Visible = true;
            }
        }
    }
}
