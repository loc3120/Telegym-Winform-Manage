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
    public partial class FormContactCustomer : Form
    {
        private readonly User u;
        private TryingPractice tp;
        public FormContactCustomer()
        {
            InitializeComponent();
        }

        public FormContactCustomer(User u, TryingPractice tp)
        {
            this.u = u;
            this.tp = tp;
            InitializeComponent();
        }

        private void FormContactCustomer_Load(object sender, EventArgs e)
        {
            lbName.Text = tp.name;
            lbPhoneNumb.Text = tp.phone_number;
            lbEmail.Text = tp.email;
            lbTimeSent.Text = tp.time_sent.ToString();
            if (tp._contacted == false)
            {
                //rdbYes.Checked = false;
                rdbNo.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = contactAsync();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task contactAsync ()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "tp/contact";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            SearchObject searchObject = new SearchObject();
            _ = rdbYes.Checked == true ? searchObject.bl1 = true : searchObject.bl1 = false;

            String data = JsonConvert.SerializeObject(searchObject);

            var content = new StringContent(data, Encoding.Default, "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            connectURL += string.Format("/{0}", tp.id);

            try
            {
                HttpResponseMessage response = await client.PostAsync(connectURL, content);
                string resultContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(resultContent, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultContent, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
