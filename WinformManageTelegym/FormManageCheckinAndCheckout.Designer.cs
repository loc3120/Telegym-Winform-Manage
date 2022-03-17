namespace WinformManageTelegym
{
    partial class FormManageCheckinAndCheckout
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
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.cbbListClass = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbCountNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccess
            // 
            this.dgvAccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Location = new System.Drawing.Point(43, 212);
            this.dgvAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.ReadOnly = true;
            this.dgvAccess.RowHeadersWidth = 51;
            this.dgvAccess.RowTemplate.Height = 24;
            this.dgvAccess.Size = new System.Drawing.Size(1308, 283);
            this.dgvAccess.TabIndex = 3;
            this.dgvAccess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccess_CellClick);
            this.dgvAccess.Leave += new System.EventHandler(this.dgvAccess_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(851, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(385, 57);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(400, 26);
            this.txbSearch.TabIndex = 5;
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(549, 113);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(216, 46);
            this.btnCheckin.TabIndex = 6;
            this.btnCheckin.Text = "Checkin / Checkout";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // cbbListClass
            // 
            this.cbbListClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListClass.FormattingEnabled = true;
            this.cbbListClass.Location = new System.Drawing.Point(43, 54);
            this.cbbListClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbListClass.Name = "cbbListClass";
            this.cbbListClass.Size = new System.Drawing.Size(177, 28);
            this.cbbListClass.TabIndex = 7;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(579, 176);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(84, 20);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Trạng thái";
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.AutoSize = true;
            this.lbTotalPages.Location = new System.Drawing.Point(1036, 153);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(39, 16);
            this.lbTotalPages.TabIndex = 23;
            this.lbTotalPages.Text = "Tổng";
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Location = new System.Drawing.Point(1009, 153);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(14, 16);
            this.lbPageNumber.TabIndex = 24;
            this.lbPageNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(1125, 142);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 39);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Trang kế tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(844, 142);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(124, 39);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "Trang trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbCountNumber
            // 
            this.lbCountNumber.AutoSize = true;
            this.lbCountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountNumber.Location = new System.Drawing.Point(1335, 153);
            this.lbCountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountNumber.Name = "lbCountNumber";
            this.lbCountNumber.Size = new System.Drawing.Size(16, 18);
            this.lbCountNumber.TabIndex = 19;
            this.lbCountNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1261, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng: ";
            // 
            // FormManageCheckinAndCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 639);
            this.Controls.Add(this.lbTotalPages);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lbCountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbbListClass);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.dgvAccess);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManageCheckinAndCheckout";
            this.Text = "FormManageCheckinAndCheckout";
            this.Load += new System.EventHandler(this.FormManageCheckinAndCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.ComboBox cbbListClass;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTotalPages;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lbCountNumber;
        private System.Windows.Forms.Label label5;
    }
}