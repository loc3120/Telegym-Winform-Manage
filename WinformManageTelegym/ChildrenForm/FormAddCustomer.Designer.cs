namespace WinformManageTelegym.ChildrenForm
{
    partial class FormAddCustomer
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
            this.lbName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbTimeEnroll = new System.Windows.Forms.Label();
            this.lbTimeExpire = new System.Windows.Forms.Label();
            this.dtpEnroll = new System.Windows.Forms.DateTimePicker();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMemberCard = new System.Windows.Forms.ComboBox();
            this.cbbExerciseForm = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(98, 68);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(132, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên khách hàng:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(269, 66);
            this.txbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(234, 23);
            this.txbName.TabIndex = 0;
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNum.Location = new System.Drawing.Point(98, 129);
            this.lbPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(95, 17);
            this.lbPhoneNum.TabIndex = 0;
            this.lbPhoneNum.Text = "Số điện thoại:";
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNum.Location = new System.Drawing.Point(269, 127);
            this.txbPhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(234, 23);
            this.txbPhoneNum.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(98, 191);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(269, 188);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(234, 23);
            this.txbEmail.TabIndex = 2;
            // 
            // lbTimeEnroll
            // 
            this.lbTimeEnroll.AutoSize = true;
            this.lbTimeEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeEnroll.Location = new System.Drawing.Point(98, 255);
            this.lbTimeEnroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeEnroll.Name = "lbTimeEnroll";
            this.lbTimeEnroll.Size = new System.Drawing.Size(125, 17);
            this.lbTimeEnroll.TabIndex = 0;
            this.lbTimeEnroll.Text = "Thời gian đăng ký:";
            // 
            // lbTimeExpire
            // 
            this.lbTimeExpire.AutoSize = true;
            this.lbTimeExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeExpire.Location = new System.Drawing.Point(98, 324);
            this.lbTimeExpire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeExpire.Name = "lbTimeExpire";
            this.lbTimeExpire.Size = new System.Drawing.Size(123, 17);
            this.lbTimeExpire.TabIndex = 0;
            this.lbTimeExpire.Text = "Thời gian hết hạn:";
            // 
            // dtpEnroll
            // 
            this.dtpEnroll.CustomFormat = "yyyy-MM-dd";
            this.dtpEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnroll.Location = new System.Drawing.Point(269, 255);
            this.dtpEnroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnroll.Name = "dtpEnroll";
            this.dtpEnroll.Size = new System.Drawing.Size(234, 23);
            this.dtpEnroll.TabIndex = 3;
            // 
            // dtpExpire
            // 
            this.dtpExpire.CustomFormat = "yyyy-MM-dd";
            this.dtpExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpire.Location = new System.Drawing.Point(269, 323);
            this.dtpExpire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(234, 23);
            this.dtpExpire.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại thẻ thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể loại:";
            // 
            // cbbMemberCard
            // 
            this.cbbMemberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMemberCard.FormattingEnabled = true;
            this.cbbMemberCard.Location = new System.Drawing.Point(269, 387);
            this.cbbMemberCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMemberCard.Name = "cbbMemberCard";
            this.cbbMemberCard.Size = new System.Drawing.Size(234, 24);
            this.cbbMemberCard.TabIndex = 5;
            // 
            // cbbExerciseForm
            // 
            this.cbbExerciseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbExerciseForm.FormattingEnabled = true;
            this.cbbExerciseForm.Items.AddRange(new object[] {
            "gym",
            "yoga"});
            this.cbbExerciseForm.Location = new System.Drawing.Point(269, 449);
            this.cbbExerciseForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbExerciseForm.Name = "cbbExerciseForm";
            this.cbbExerciseForm.Size = new System.Drawing.Size(234, 24);
            this.cbbExerciseForm.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(142, 530);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm khách hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(325, 530);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 42);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 630);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbExerciseForm);
            this.Controls.Add(this.cbbMemberCard);
            this.Controls.Add(this.dtpExpire);
            this.Controls.Add(this.dtpEnroll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimeExpire);
            this.Controls.Add(this.lbTimeEnroll);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbPhoneNum);
            this.Controls.Add(this.lbPhoneNum);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbTimeEnroll;
        private System.Windows.Forms.Label lbTimeExpire;
        private System.Windows.Forms.DateTimePicker dtpEnroll;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMemberCard;
        private System.Windows.Forms.ComboBox cbbExerciseForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
    }
}