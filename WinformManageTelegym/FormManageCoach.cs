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
using WinformManageTelegym.ChildrenForm;
using WinformManageTelegym.Common;
using WinformManageTelegym.Entity;

namespace WinformManageTelegym
{
    public partial class FormManageCoach : Form
    {
        private readonly string prefixURL = "coach";
        private readonly User u;
        public FormManageCoach()
        {
            InitializeComponent();
        }
        public FormManageCoach(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageCoach_Load(object sender, EventArgs e)
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
                    List<Coach> listName = JsonConvert.DeserializeObject<List<Coach>>(pds.data.ToString());

                    dgvCoach.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvCoach.Columns["id"].Visible = false;
                        dgvCoach.Columns["_deleted"].Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormModifyCoach(u).ShowDialog();
            btnSearch_Click(sender, e);
        }
        private void dgvCoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnRating.Enabled = true;
                btnDelete.Enabled = true;
            }
                
            else
            {
                btnRating.Enabled = false;
                btnDelete.Enabled = false;
            }
                
        }
        private void btnRating_Click(object sender, EventArgs e)
        {
            Coach coachSelected = (Coach) dgvCoach.CurrentRow.DataBoundItem;
            new FormRatingCoach(u, coachSelected).ShowDialog();
            FormManageCoach_Load(sender, e);
            btnSearch_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá HLV này?", "Xoá huấn luyện viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Coach coachSelected = (Coach)dgvCoach.CurrentRow.DataBoundItem;
                _ = deleteSync(coachSelected.id);
                btnSearch_Click(sender, e);
            }
        }
        private async Task deleteSync(string id)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/delete";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            SearchObject searchObject = new SearchObject
            {
                str1 = id
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
