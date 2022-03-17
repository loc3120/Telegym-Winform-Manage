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
    public partial class FormRatingCoach : Form
    {
        private readonly User u;
        private Coach c;
        public FormRatingCoach()
        {
            InitializeComponent();
        }
        public FormRatingCoach(User u, Coach c)
        {
            this.u = u;
            this.c = c;
            InitializeComponent();
        }

        private void FormRatingCoach_Load(object sender, EventArgs e)
        {
            lbCoachName.Text = c.name;
            lbEmailCoach.Text = c.email;
        }
        private void btnRating_Click(object sender, EventArgs e)
        {
            _ = ratingSync();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task ratingSync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/rating";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            SearchObject searchObject = new SearchObject
            {
                str1 = c.id,
                fl1 = (float) numRating.Value
            };

            String data = JsonConvert.SerializeObject(searchObject);

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
