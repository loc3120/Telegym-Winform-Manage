namespace WinformManageTelegym
{
    partial class FormManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbGeneral = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnManageGeneralClass = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageCandidate = new System.Windows.Forms.Button();
            this.btnManageTryingPractice = new System.Windows.Forms.Button();
            this.btnManageCoach = new System.Windows.Forms.Button();
            this.btnManageAccess = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panelBtn.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGeneral
            // 
            this.lbGeneral.AutoSize = true;
            this.lbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneral.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbGeneral.Location = new System.Drawing.Point(279, 269);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(554, 29);
            this.lbGeneral.TabIndex = 1;
            this.lbGeneral.Text = "Chào mừng bạn đến với form quản lý của nhân viên";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(414, 176);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(254, 22);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = "Xin chào, tên người đăng nhập";
            // 
            // btnManageGeneralClass
            // 
            this.btnManageGeneralClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageGeneralClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageGeneralClass.Location = new System.Drawing.Point(0, 0);
            this.btnManageGeneralClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageGeneralClass.Name = "btnManageGeneralClass";
            this.btnManageGeneralClass.Size = new System.Drawing.Size(166, 81);
            this.btnManageGeneralClass.TabIndex = 4;
            this.btnManageGeneralClass.Text = "Quản lý lớp tập";
            this.btnManageGeneralClass.UseVisualStyleBackColor = true;
            this.btnManageGeneralClass.Click += new System.EventHandler(this.btnManageGeneralClass_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnLogout);
            this.panelBtn.Controls.Add(this.btnManageStaff);
            this.panelBtn.Controls.Add(this.btnManageCandidate);
            this.panelBtn.Controls.Add(this.btnManageTryingPractice);
            this.panelBtn.Controls.Add(this.btnManageCoach);
            this.panelBtn.Controls.Add(this.btnManageAccess);
            this.panelBtn.Controls.Add(this.btnManageCustomer);
            this.panelBtn.Controls.Add(this.btnManageGeneralClass);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 0);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(166, 648);
            this.panelBtn.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(0, 567);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 81);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageStaff.Location = new System.Drawing.Point(0, 486);
            this.btnManageStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(166, 81);
            this.btnManageStaff.TabIndex = 4;
            this.btnManageStaff.Text = "Quản lý nhân viên";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // btnManageCandidate
            // 
            this.btnManageCandidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCandidate.Location = new System.Drawing.Point(0, 405);
            this.btnManageCandidate.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCandidate.Name = "btnManageCandidate";
            this.btnManageCandidate.Size = new System.Drawing.Size(166, 81);
            this.btnManageCandidate.TabIndex = 4;
            this.btnManageCandidate.Text = "Danh sách ứng tuyển HLV";
            this.btnManageCandidate.UseVisualStyleBackColor = true;
            this.btnManageCandidate.Click += new System.EventHandler(this.btnManageCandidate_Click);
            // 
            // btnManageTryingPractice
            // 
            this.btnManageTryingPractice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTryingPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageTryingPractice.Location = new System.Drawing.Point(0, 324);
            this.btnManageTryingPractice.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageTryingPractice.Name = "btnManageTryingPractice";
            this.btnManageTryingPractice.Size = new System.Drawing.Size(166, 81);
            this.btnManageTryingPractice.TabIndex = 4;
            this.btnManageTryingPractice.Text = "Danh sách đăng ký tập thử";
            this.btnManageTryingPractice.UseVisualStyleBackColor = true;
            this.btnManageTryingPractice.Click += new System.EventHandler(this.btnManageTryingPractice_Click);
            // 
            // btnManageCoach
            // 
            this.btnManageCoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCoach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCoach.Location = new System.Drawing.Point(0, 243);
            this.btnManageCoach.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCoach.Name = "btnManageCoach";
            this.btnManageCoach.Size = new System.Drawing.Size(166, 81);
            this.btnManageCoach.TabIndex = 4;
            this.btnManageCoach.Text = "Quản lý huấn luyện viên";
            this.btnManageCoach.UseVisualStyleBackColor = true;
            this.btnManageCoach.Click += new System.EventHandler(this.btnManageCoach_Click);
            // 
            // btnManageAccess
            // 
            this.btnManageAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageAccess.Location = new System.Drawing.Point(0, 162);
            this.btnManageAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccess.Name = "btnManageAccess";
            this.btnManageAccess.Size = new System.Drawing.Size(166, 81);
            this.btnManageAccess.TabIndex = 4;
            this.btnManageAccess.Text = "Quản lý ra vào";
            this.btnManageAccess.UseVisualStyleBackColor = true;
            this.btnManageAccess.Click += new System.EventHandler(this.btnManageAccess_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCustomer.Location = new System.Drawing.Point(0, 81);
            this.btnManageCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(166, 81);
            this.btnManageCustomer.TabIndex = 4;
            this.btnManageCustomer.Text = "Quản lý khách hàng";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.lbWelcome);
            this.panelForm.Controls.Add(this.lbGeneral);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForm.Location = new System.Drawing.Point(166, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1060, 648);
            this.panelForm.TabIndex = 6;
            // 
            // btnBackward
            // 
            this.btnBackward.Enabled = false;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.Location = new System.Drawing.Point(169, 262);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(33, 41);
            this.btnBackward.TabIndex = 8;
            this.btnBackward.Text = "←";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Visible = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(1230, 259);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(33, 41);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 648);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelBtn);
            this.IsMdiContainer = true;
            this.Name = "FormManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form quản lý";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGeneral;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnManageGeneralClass;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnManageCandidate;
        private System.Windows.Forms.Button btnManageCoach;
        private System.Windows.Forms.Button btnManageAccess;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnManageTryingPractice;
    }
}