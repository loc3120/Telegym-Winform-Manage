using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformManageTelegym.Entity;

namespace WinformManageTelegym
{
    public partial class FormManage : Form
    {
        private readonly User u;
        public FormManage()
        {
            InitializeComponent();
        }
        public FormManage(User u)
        {
            this.u = u;
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Xin chào, " + u.name;
            if (u.role == "ROLE_STAFF")
            {
                Size = new Size(panelBtn.Width + panelForm.Width + (panelBtn.Width / 5) + btnBackward.Width, btnLogout.Height * 7 + btnLogout.Height / 2);
                btnManageStaff.Visible = false;
            }
        }

        private void btnManageGeneralClass_Click(object sender, EventArgs e)
        {
            changeSize();
            btnForward.Visible = true;
            FormManageClass fmc = new FormManageClass(u);
            AddForm(fmc);
        }

        private void AddForm(Form f)
        {
            this.panelForm.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageCustomer fmc = new FormManageCustomer(u);
            AddForm(fmc);
        }

        private void btnManageAccess_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageCheckinAndCheckout fma = new FormManageCheckinAndCheckout(u);
            AddForm(fma);
        }
        private void btnManageCoach_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageCoach fma = new FormManageCoach(u);
            AddForm(fma);
        }
        private void btnManageTryingPractice_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageTryingPractice fmtp = new FormManageTryingPractice(u);
            AddForm(fmtp);
        }

        private void btnManageCandidate_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageCandidate fmc = new FormManageCandidate(u);
            AddForm(fmc);
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            returnSize();
            FormManageUser fmu = new FormManageUser(u);
            AddForm(fmu);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeSize()
        {
            btnForward.Visible = true;
            btnForward.Enabled = true;
            if (u.role.Equals("ROLE_STAFF"))
            {
                //Size = new Size(1285, 606);
                Size = new Size(panelBtn.Width + panelForm.Width + (panelBtn.Width/5) + btnBackward.Width, btnLogout.Height*7 + btnLogout.Height/2);
            }
                
            else
            {
                //Size = new Size(1285, 687);
                Size = new Size(panelBtn.Width + panelForm.Width + (panelBtn.Width/5) + btnBackward.Width, btnLogout.Height*8 + btnLogout.Height/2);
            }
        }
        private void returnSize()
        {
            if (u.role.Equals("ROLE_STAFF"))
            {
                //Size = new Size(1243, 606);
                Size = new Size(panelBtn.Width + panelForm.Width, btnLogout.Height * 7 + btnLogout.Height / 2);
            }
            else
            {
                //Size = new Size(1243, 687);
                Size = new Size(panelBtn.Width + panelForm.Width, btnLogout.Height * 8 + btnLogout.Height / 2);
            }
            panelForm.Dock = DockStyle.Left;
            btnForward.Visible = false;
            btnForward.Enabled = false;
            btnBackward.Visible = false;
            btnBackward.Enabled = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            FormManagePrivateClass fmpc = new FormManagePrivateClass(u);
            AddForm(fmpc);
            panelForm.Dock = DockStyle.Right;
            btnForward.Visible = false;
            btnForward.Enabled = false;
            btnBackward.Visible = true;
            btnBackward.Enabled = true;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            FormManageClass fmc = new FormManageClass(u);
            AddForm(fmc);
            panelForm.Dock = DockStyle.Left;
            btnForward.Visible = true;
            btnForward.Enabled = true;
            btnBackward.Visible = false;
            btnBackward.Enabled = false;
        }


    }
}
