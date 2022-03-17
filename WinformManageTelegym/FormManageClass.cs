using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformManageTelegym.Entity;
using WinformManageTelegym.Common;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Collections;
using WinformManageTelegym.ChildrenForm;

namespace WinformManageTelegym
{
    public partial class FormManageClass : Form
    {
        private readonly string prefixURL = "gc";
        private string descriptionOfClass;

        public bool flag;
        private readonly User u;
        public FormManageClass()
        {
            InitializeComponent();
        }

        public FormManageClass(User u)
        {
            this.u = u;
            InitializeComponent();
        }
        private void FormManageClass_Load(object sender, EventArgs e)
        {
        }
        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/getname";
            btnPrint.Enabled = true;
            btnHistory.Enabled = true;
            btnUpdate.Enabled = true;

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?type={0}", cbbType.SelectedItem.ToString())).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    List<GeneralClass> listName = JsonConvert.DeserializeObject<List<GeneralClass>>(rs.dataResponse.ToString());
                    cbbGeneralClass.DataSource = listName;
                    cbbGeneralClass.DisplayMember = "name";
                    cbbGeneralClass.ValueMember = "id";
                    cbbGeneralClass_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void cbbGeneralClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/detail";
            string loadNameCoachURL = ConfigURL.LOCAL_SERVICE_URL + "coach/detail";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?id={0}", cbbGeneralClass.SelectedValue)).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    GeneralClass detailGeneralClass = JsonConvert.DeserializeObject<GeneralClass>(rs.dataResponse.ToString());

                    // Gọi thêm API load tên và id HLV
                    HttpClient client2 = new HttpClient
                    {
                        BaseAddress = new Uri(loadNameCoachURL)
                    };
                    client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

                    HttpResponseMessage response2 = client2.GetAsync(string.Format("?id={0}", cbbGeneralClass.SelectedValue)).Result;
                    resultContent = response2.Content.ReadAsStringAsync().Result;
                    rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);
                    Coach detailCoach = JsonConvert.DeserializeObject<Coach>(rs.dataResponse.ToString());

                    lbCapacity.Text = detailGeneralClass.capacity.ToString();
                    lbPracticeTime.Text = detailGeneralClass.practice_time.ToString();
                    descriptionOfClass = detailGeneralClass.description;
                    lbCoach.Text = detailCoach.name;
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            flag = false;
            if (lbPageNumber.Text.Equals("1"))
                btnPrevious.Enabled = false;
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "accessmanagement" + "/listcustomernow";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?page={0}&id_generalClass={1}", lbPageNumber.Text, cbbGeneralClass.SelectedValue)).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<Customer> listName = JsonConvert.DeserializeObject<List<Customer>>(pds.data.ToString());

                    dgvGeneralClass.DataSource = listName;
                    if (listName.Count > 0)
                    {
                        dgvGeneralClass.Columns["id"].Visible = false;
                    }

                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbProp.Text = "Số lượng đang tập: ";
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            flag = true;
            if (lbPageNumber.Text.Equals("1"))
                btnPrevious.Enabled = false;
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "accessmanagement" + "/historyclass";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?page={0}&id_generalClass={1}", lbPageNumber.Text, cbbGeneralClass.SelectedValue)).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<AccessManagement> listHistory = JsonConvert.DeserializeObject<List<AccessManagement>>(pds.data.ToString());

                    dgvGeneralClass.DataSource = listHistory;
                    if (listHistory.Count > 0)
                    {
                        dgvGeneralClass.Columns["id"].Visible = false;
                    }

                    lbTotalPages.Text = " /     " + pds.totalPages;
                    lbProp.Text = "Số bản ghi lịch sử: ";
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
            if (flag)
                btnHistory_Click(sender, e);
            else
                btnPrint_Click(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            int a = Int32.Parse(lbPageNumber.Text);
            lbPageNumber.Text = (a + 1).ToString();
            if (flag)
                btnHistory_Click(sender, e);
            else
                btnPrint_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormModifyGeneralClass(u).ShowDialog();
            FormManageClass_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GeneralClass gc = new GeneralClass
            {
                id = cbbGeneralClass.SelectedValue.ToString(),
                name = cbbGeneralClass.GetItemText(cbbGeneralClass.SelectedItem),
                practice_time = lbPracticeTime.Text,
                type = cbbType.SelectedItem.ToString(),
                capacity = Int32.Parse(lbCapacity.Text),
                description = descriptionOfClass,
                coach = lbCoach.Text
            };
            new FormModifyGeneralClass(u, gc).ShowDialog();
            FormManageClass_Load(sender, e);
        }
    }
}
