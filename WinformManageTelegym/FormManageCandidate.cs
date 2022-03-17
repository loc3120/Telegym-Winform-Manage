using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformManageTelegym.ChildrenForm;
using WinformManageTelegym.Common;
using WinformManageTelegym.Entity;

namespace WinformManageTelegym
{
    public partial class FormManageCandidate : Form
    {
        private readonly string prefixURL = "candidate";
        private readonly User u;
        public FormManageCandidate()
        {
            InitializeComponent();
        }
        public FormManageCandidate(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageCandidate_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lbPageNumber.Text.Equals("1"))
                btnPrevious.Enabled = false;
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?page={0}&search={1}", lbPageNumber.Text, txbSearch.Text)).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<Candidate> listCandidate = JsonConvert.DeserializeObject<List<Candidate>>(pds.data.ToString());

                    dgvCandidate.DataSource = listCandidate;
                    if (listCandidate.Count > 0)
                    {
                        dgvCandidate.Columns["id"].Visible = false;
                        dgvCandidate.Columns["description"].Visible = false;
                        dgvCandidate.Columns["time_reply"].Visible = false;
                        dgvCandidate.Columns["reply_by"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dgvCandidate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                Candidate c = new Candidate
                {
                    id = dgvCandidate.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                    name = dgvCandidate.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    dateOfBirth = (DateTime)dgvCandidate.Rows[e.RowIndex].Cells["dateOfBirth"].Value,
                    phone_number = dgvCandidate.Rows[e.RowIndex].Cells["phone_number"].Value.ToString(),
                    email = dgvCandidate.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                    time_sent = (DateTime) dgvCandidate.Rows[e.RowIndex].Cells["time_sent"].Value,
                    description = dgvCandidate.Rows[e.RowIndex].Cells["description"].Value.ToString(),
                    approved = bool.Parse(dgvCandidate.Rows[e.RowIndex].Cells["approved"].Value.ToString())
                };
                new FormReviewCandidate(u, c).ShowDialog();
                FormManageCandidate_Load(sender, e);
                btnSearch_Click(sender, e);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbPageNumber.Text);
            lbPageNumber.Text = (a - 1).ToString();
            btnSearch_Click(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            int a = Int32.Parse(lbPageNumber.Text);
            lbPageNumber.Text = (a + 1).ToString();
            btnSearch_Click(sender, e);
        }
    }
}
