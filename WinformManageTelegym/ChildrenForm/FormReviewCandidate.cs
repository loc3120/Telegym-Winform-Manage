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
using WinformManageTelegym.Entity;

namespace WinformManageTelegym.ChildrenForm
{
    public partial class FormReviewCandidate : Form
    {
        private readonly User u;
        private Candidate c;
        public FormReviewCandidate()
        {
            InitializeComponent();
        }

        public FormReviewCandidate(User u, Candidate c)
        {
            this.u = u; ;
            this.c = c;
            InitializeComponent();
        }
        private void FormReviewCandidate_Load(object sender, EventArgs e)
        {
            lbName.Text = c.name;
            lbDateOfBirth.Text = c.dateOfBirth.ToString();
            lbEmail.Text = c.email;
            lbPhoneNumb.Text = c.phone_number;
            lbTimeSent.Text = c.time_sent.ToString();
            lbDescription.Text = c.description;
            if (c.approved == false)
            {
                rdbNo.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = reviewAsync();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task reviewAsync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "candidate/review";

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

            connectURL += string.Format("/{0}", c.id);

            try
            {
                HttpResponseMessage response = await client.PostAsync(connectURL, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
