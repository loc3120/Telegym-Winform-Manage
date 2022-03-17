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

namespace WinformManageTelegym
{
    public partial class FormManageCheckinAndCheckout : Form
    {
        private readonly string prefixURL = "accessmanagement";
        private readonly User u;
        public FormManageCheckinAndCheckout()
        {
            InitializeComponent();
        }

        public FormManageCheckinAndCheckout(User u)
        {
            this.u = u;
            InitializeComponent();
        }

        private void FormManageCheckinAndCheckout_Load(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "gc/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync("").Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    List<GeneralClass> listName = JsonConvert.DeserializeObject<List<GeneralClass>>(rs.dataResponse.ToString());
                    cbbListClass.DataSource = listName;
                    cbbListClass.DisplayMember = "name";
                    cbbListClass.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lbPageNumber.Text.Equals("1"))
                btnPrevious.Enabled = false;
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "customer" + "/getall";

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
                    List<Customer> listName = JsonConvert.DeserializeObject<List<Customer>>(pds.data.ToString());

                    dgvAccess.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvAccess.Columns["id"].Visible = false;
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

        private void dgvAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCheckin.Enabled = true;
        }

        private void dgvAccess_Leave(object sender, EventArgs e)
        {
            btnCheckin.Enabled = true;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            _ = checkinAsync();
            btnSearch_Click(sender, e);
        }

        private async Task checkinAsync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/access";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            AccessManagement accessManagement = new AccessManagement()
            {   
                id_generalClass = cbbListClass.SelectedValue.ToString(),
                id_customer = dgvAccess.CurrentRow.Cells["id"].Value.ToString()
            };

            String data = JsonConvert.SerializeObject(accessManagement);

            var content = new StringContent(data, Encoding.Default, "application/json");
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
                    lbStatus.Text = "Lớp trước chưa checkout";
                    lbStatus.ForeColor = Color.Red;
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
    }
}
