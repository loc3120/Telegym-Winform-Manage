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
    public partial class FormManageUser : Form
    {
        private readonly string prefixURL = "user";
        private readonly User u;
        public FormManageUser()
        {
            InitializeComponent();
        }
        public FormManageUser(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageUser_Load(object sender, EventArgs e)
        {
            cbbUserFilter.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lbPageNumber.Text.Equals("1"))
                btnPrevious.Enabled = false;

            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/filter";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                if (cbbUserFilter.SelectedIndex == 0)
                {
                    response = client.GetAsync(string.Format("?page={0}&search={1}", lbPageNumber.Text, 
                        txbSearch.Text)).Result;
                }
                else if (cbbUserFilter.SelectedIndex == 1)
                {
                    response = client.GetAsync(string.Format("?page={0}&search={1}&roleName={2}", lbPageNumber.Text,
                        txbSearch.Text, "ROLE_STAFF")).Result;
                }
                else
                {
                    response = client.GetAsync(string.Format("?page={0}&search={1}&roleName={2}", lbPageNumber.Text, 
                        txbSearch.Text, "ROLE_ADMIN")).Result;
                }
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<User> listName = JsonConvert.DeserializeObject<List<User>>(pds.data.ToString());

                    dgvUser.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvUser.Columns["id"].Visible = false;
                        dgvUser.Columns["pass"].Visible = false;
                        dgvUser.Columns["tokenValue"].Visible = false;
                    }
                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbTotalElement.Text = "Số lượng: " + pds.totalElements.ToString();
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

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                User userClicked = new User
                {
                    id = dgvUser.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                    name = dgvUser.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    username = dgvUser.Rows[e.RowIndex].Cells["username"].Value.ToString(),
                    role = dgvUser.Rows[e.RowIndex].Cells["role"].Value.ToString()
                };
                new FormModifyAccount(u, userClicked).ShowDialog();
                FormManageUser_Load(sender, e);
                btnSearch_Click(sender, e);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FormModifyAccount(u).ShowDialog();
            FormManageUser_Load(sender, e);
            btnSearch_Click(sender, e);
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

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá HLV này?", "Xoá huấn luyện viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dgvUser.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    _ = deleteSync(id);
                    btnSearch_Click(sender, e);
                }
            }
        }

        private async Task deleteSync(string id)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL;

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(string.Format("user/{0}", id));
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
