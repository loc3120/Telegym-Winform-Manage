namespace WinformManageTelegym
{
    partial class FormManageClass
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
            this.cbbGeneralClass = new System.Windows.Forms.ComboBox();
            this.dgvGeneralClass = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.lbProp = new System.Windows.Forms.Label();
            this.lbCountNumber = new System.Windows.Forms.Label();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPracticeTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCoach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbGeneralClass
            // 
            this.cbbGeneralClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGeneralClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGeneralClass.FormattingEnabled = true;
            this.cbbGeneralClass.Location = new System.Drawing.Point(43, 89);
            this.cbbGeneralClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGeneralClass.Name = "cbbGeneralClass";
            this.cbbGeneralClass.Size = new System.Drawing.Size(171, 26);
            this.cbbGeneralClass.TabIndex = 1;
            this.cbbGeneralClass.Tag = "1";
            this.cbbGeneralClass.SelectedIndexChanged += new System.EventHandler(this.cbbGeneralClass_SelectedIndexChanged);
            // 
            // dgvGeneralClass
            // 
            this.dgvGeneralClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeneralClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralClass.Location = new System.Drawing.Point(43, 230);
            this.dgvGeneralClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGeneralClass.Name = "dgvGeneralClass";
            this.dgvGeneralClass.ReadOnly = true;
            this.dgvGeneralClass.RowHeadersWidth = 51;
            this.dgvGeneralClass.RowTemplate.Height = 24;
            this.dgvGeneralClass.Size = new System.Drawing.Size(1308, 283);
            this.dgvGeneralClass.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(267, 49);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(249, 46);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Danh sách học viên đang học";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Enabled = false;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(585, 49);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(224, 46);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Thông tin lịch sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(435, 530);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm lớp học";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "gym",
            "yoga"});
            this.cbbType.Location = new System.Drawing.Point(43, 31);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(171, 26);
            this.cbbType.TabIndex = 0;
            this.cbbType.Tag = "";
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // lbProp
            // 
            this.lbProp.AutoSize = true;
            this.lbProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProp.Location = new System.Drawing.Point(931, 164);
            this.lbProp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProp.Name = "lbProp";
            this.lbProp.Size = new System.Drawing.Size(135, 18);
            this.lbProp.TabIndex = 5;
            this.lbProp.Text = "Số lượng đang tập: ";
            // 
            // lbCountNumber
            // 
            this.lbCountNumber.AutoSize = true;
            this.lbCountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountNumber.Location = new System.Drawing.Point(1071, 164);
            this.lbCountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountNumber.Name = "lbCountNumber";
            this.lbCountNumber.Size = new System.Drawing.Size(16, 18);
            this.lbCountNumber.TabIndex = 5;
            this.lbCountNumber.Text = "0";
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.AutoSize = true;
            this.lbTotalPages.Location = new System.Drawing.Point(696, 164);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(39, 16);
            this.lbTotalPages.TabIndex = 11;
            this.lbTotalPages.Text = "Tổng";
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Location = new System.Drawing.Point(669, 164);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(14, 16);
            this.lbPageNumber.TabIndex = 12;
            this.lbPageNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(787, 153);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 39);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Trang kế tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(481, 153);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(124, 39);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Trang trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(747, 530);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Thay đổi thông tin lớp học";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapacity.Location = new System.Drawing.Point(120, 130);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(16, 18);
            this.lbCapacity.TabIndex = 5;
            this.lbCapacity.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sức chứa:";
            // 
            // lbPracticeTime
            // 
            this.lbPracticeTime.AutoSize = true;
            this.lbPracticeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPracticeTime.Location = new System.Drawing.Point(149, 164);
            this.lbPracticeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPracticeTime.Name = "lbPracticeTime";
            this.lbPracticeTime.Size = new System.Drawing.Size(16, 18);
            this.lbPracticeTime.TabIndex = 5;
            this.lbPracticeTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian tập:";
            // 
            // lbCoach
            // 
            this.lbCoach.AutoSize = true;
            this.lbCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoach.Location = new System.Drawing.Point(172, 198);
            this.lbCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCoach.Name = "lbCoach";
            this.lbCoach.Size = new System.Drawing.Size(52, 18);
            this.lbCoach.TabIndex = 5;
            this.lbCoach.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Huấn luyện viên:";
            // 
            // FormManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 639);
            this.Controls.Add(this.lbTotalPages);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCoach);
            this.Controls.Add(this.lbPracticeTime);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbCountNumber);
            this.Controls.Add(this.lbProp);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvGeneralClass);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.cbbGeneralClass);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManageClass";
            this.Text = "FormManageClass";
            this.Load += new System.EventHandler(this.FormManageClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbGeneralClass;
        private System.Windows.Forms.DataGridView dgvGeneralClass;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label lbProp;
        private System.Windows.Forms.Label lbCountNumber;
        private System.Windows.Forms.Label lbTotalPages;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPracticeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCoach;
        private System.Windows.Forms.Label label4;
    }
}