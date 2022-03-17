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
    public partial class FormManageCustomer : Form
    {
        private readonly string prefixURL = "customer";

        private readonly User u;
        public FormManageCustomer()
        {
            InitializeComponent();
        }

        public FormManageCustomer(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageCustomer_Load(object sender, EventArgs e)
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
                    List<Customer> listName = JsonConvert.DeserializeObject<List<Customer>>(pds.data.ToString());

                    dgvCustomer.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvCustomer.Columns["id"].Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddCustomer(u).ShowDialog();
            FormManageCustomer_Load(sender, e);
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
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnRegisterPrivateClass.Enabled = true;
            else
                btnRegisterPrivateClass.Enabled = false;
        }
        private void btnRegisterPrivateClass_Click(object sender, EventArgs e)
        {
            Customer customerSelected = (Customer) dgvCustomer.CurrentRow.DataBoundItem;
            new FormRegisterPrivateClass(u, customerSelected).ShowDialog();
            FormManageCustomer_Load(sender, e);
            btnSearch_Click(sender, e);
        }
    }
}
