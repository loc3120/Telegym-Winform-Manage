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
    public partial class FormManagePrivateClass : Form
    {
        private readonly User u;
        private readonly string prefixURL = "pc";
        private string storageID_PrivateClass;
        public FormManagePrivateClass()
        {
            InitializeComponent();
        }
        public FormManagePrivateClass(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManagePrivateClass_Load(object sender, EventArgs e)
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
                    List<PrivateClass> listPrivateClass = JsonConvert.DeserializeObject<List<PrivateClass>>(pds.data.ToString());

                    dgvPrivateClass.DataSource = listPrivateClass;
                    if (listPrivateClass.Count > 0)
                    {
                        dgvPrivateClass.Columns["id"].Visible = false;
                        dgvPrivateClass.Columns["coach"].Visible = false;
                        dgvPrivateClass.Columns["customer"].Visible = false;
                    }
                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbCountNumber.Text = "Số lượng trả về: " + pds.totalElements.ToString();
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

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            _ = createSync();
            btnSearch_Click(sender, e);
        }
        private async Task createSync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "tracking/create";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            TrackingProgress newTracking = new TrackingProgress(storageID_PrivateClass);

            String data = JsonConvert.SerializeObject(newTracking);

            var content = new StringContent(data, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = await client.PostAsync(connectURL, content);

                if (response.IsSuccessStatusCode)
                {
                    string resultContent = await response.Content.ReadAsStringAsync();
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    lbStatus.Text = rs.message;
                    lbStatus.ForeColor = Color.Green;
                }
                else
                {
                    lbStatus.Text = "Không thể checkin";
                    lbStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dgvPrivateClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                storageID_PrivateClass = dgvPrivateClass.Rows[e.RowIndex].Cells["id"].Value.ToString();
            }
        }

        private void dgvPrivateClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PrivateClass pc = new PrivateClass
            {
                id = dgvPrivateClass.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                name = dgvPrivateClass.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                description = dgvPrivateClass.Rows[e.RowIndex].Cells["description"].Value.ToString(),
                number_sessions = Int32.Parse(dgvPrivateClass.Rows[e.RowIndex].Cells["number_sessions"].Value.ToString()), 
                remaining_sessions = Int32.Parse(dgvPrivateClass.Rows[e.RowIndex].Cells["remaining_sessions"].Value.ToString()),
                customer = dgvPrivateClass.Rows[e.RowIndex].Cells["customer"].Value.ToString(),
                coach = dgvPrivateClass.Rows[e.RowIndex].Cells["coach"].Value.ToString()
            };
            new FormModifyPrivateClass(u, pc).ShowDialog();
            FormManagePrivateClass_Load(sender, e);
            btnSearch_Click(sender, e);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "tracking/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?page={0}&id_private_class={1}", lbPageNumber.Text, storageID_PrivateClass)).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<TrackingProgress> listHistory = JsonConvert.DeserializeObject<List<TrackingProgress>>(pds.data.ToString());

                    dgvPrivateClass.DataSource = listHistory;

                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbCountNumber.Text = "Số bản ghi lịch sử: " + pds.totalElements.ToString();
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
    }
}
