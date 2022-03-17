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
    public partial class FormManageTryingPractice : Form
    {
        private readonly string prefixURL = "tp";
        private readonly User u;
        public FormManageTryingPractice()
        {
            InitializeComponent();
        }
        public FormManageTryingPractice(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageTryingPractice_Load(object sender, EventArgs e)
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
                    List<TryingPractice> listName = JsonConvert.DeserializeObject<List<TryingPractice>>(pds.data.ToString());

                    dgvTryingPractice.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvTryingPractice.Columns["id"].Visible = false;
                        dgvTryingPractice.Columns["time_reply"].Visible = false;
                        dgvTryingPractice.Columns["reply_by"].Visible = false;
                    }
                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbCountNumber.Text = pds.totalElements.ToString();
                    if (pds.hasNext == true)
                        btnNext.Enabled = false;
                    else
                        btnNext.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dgvTryingPractice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TryingPractice TP = new TryingPractice
                {
                    id = dgvTryingPractice.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                    name = dgvTryingPractice.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    phone_number = dgvTryingPractice.Rows[e.RowIndex].Cells["phone_number"].Value.ToString(),
                    email = dgvTryingPractice.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                    time_sent = (DateTime) dgvTryingPractice.Rows[e.RowIndex].Cells["time_sent"].Value,
                    _contacted = bool.Parse(dgvTryingPractice.Rows[e.RowIndex].Cells["_contacted"].Value.ToString())
                };
                new FormContactCustomer(u, TP).ShowDialog();
                FormManageTryingPractice_Load(sender, e);
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
