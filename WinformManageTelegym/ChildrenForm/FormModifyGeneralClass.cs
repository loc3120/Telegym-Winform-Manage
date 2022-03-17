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
    public partial class FormModifyGeneralClass : Form
    {
        private readonly string prefixURL = "gc";
        private readonly User u;
        private readonly GeneralClass classModified;
        public FormModifyGeneralClass()
        {
            InitializeComponent();
        }

        public FormModifyGeneralClass(User u)
        {
            this.u = u;
            InitializeComponent();
        }

        public FormModifyGeneralClass(User u, GeneralClass classModified)
        {
            this.u = u;
            this.classModified = classModified;
            InitializeComponent();
        }
        private void FormModifyGeneralClass_Load(object sender, EventArgs e)
        {
            if (classModified != null)
            {
                txbName.Text = classModified.name;
                txbPracticeTime.Text = classModified.practice_time;
                numCapacity.Value = classModified.capacity;
                txbDescription.Text = classModified.description;
                if (classModified.type == "gym")
                {
                    cbbType.SelectedIndex = 0;
                }
                else
                {
                    cbbType.SelectedIndex = 1;
                }
            }
            else
            {
                cbbType.SelectedIndex = 0;
            }
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + "coach/getall";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", u.tokenValue);

            try
            {
                HttpResponseMessage response = client.GetAsync(string.Format("?search={0}", "")).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultContent = response.Content.ReadAsStringAsync().Result;
                    ResponseStructure rs = JsonConvert.DeserializeObject<ResponseStructure>(resultContent);

                    PageDataStructure pds = JsonConvert.DeserializeObject<PageDataStructure>(rs.dataResponse.ToString());
                    List<Coach> listCoaches = JsonConvert.DeserializeObject<List<Coach>>(pds.data.ToString());
                    cbbCoachName.DataSource = listCoaches;
                    cbbCoachName.DisplayMember = "name";
                    cbbCoachName.ValueMember = "id";
                    cbbCoachName.SelectedIndex = cbbCoachName.FindStringExact(classModified.coach);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbName.Text.Trim().Equals("") || txbPracticeTime.Text.Trim().Equals("") || txbDescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numCapacity.Value == 0)
            {
                MessageBox.Show("Sức chứa phải > 0", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _ = modifySync();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task modifySync()
        {
            string connectURL = ConfigURL.LOCAL_SERVICE_URL + prefixURL + "/modify";

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(connectURL)
            };

            GeneralClass gc = new GeneralClass();
            if (classModified != null)
            {
                gc.id = classModified.id;
            }
            gc.name = txbName.Text;
            gc.type = cbbType.GetItemText(cbbType.SelectedItem);
            gc.description = txbDescription.Text;
            gc.capacity = (int)numCapacity.Value;
            gc.practice_time = txbPracticeTime.Text;
            gc.coach = cbbCoachName.SelectedValue.ToString();

            String data = JsonConvert.SerializeObject(gc);

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
