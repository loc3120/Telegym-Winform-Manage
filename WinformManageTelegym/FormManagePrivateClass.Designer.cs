namespace WinformManageTelegym
{
    partial class FormManagePrivateClass
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dgvPrivateClass = new System.Windows.Forms.DataGridView();
            this.lbCountNumber = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateClass)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(307, 34);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(282, 23);
            this.txbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(618, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.AutoSize = true;
            this.lbTotalPages.Location = new System.Drawing.Point(521, 98);
            this.lbTotalPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(32, 13);
            this.lbTotalPages.TabIndex = 18;
            this.lbTotalPages.Text = "Tổng";
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Location = new System.Drawing.Point(501, 98);
            this.lbPageNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(13, 13);
            this.lbPageNumber.TabIndex = 19;
            this.lbPageNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(590, 89);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Trang kế tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(360, 89);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(93, 32);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Trang trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dgvPrivateClass
            // 
            this.dgvPrivateClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrivateClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivateClass.Location = new System.Drawing.Point(32, 167);
            this.dgvPrivateClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrivateClass.Name = "dgvPrivateClass";
            this.dgvPrivateClass.ReadOnly = true;
            this.dgvPrivateClass.RowHeadersWidth = 51;
            this.dgvPrivateClass.RowTemplate.Height = 24;
            this.dgvPrivateClass.Size = new System.Drawing.Size(981, 230);
            this.dgvPrivateClass.TabIndex = 13;
            this.dgvPrivateClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrivateClass_CellClick);
            this.dgvPrivateClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrivateClass_CellDoubleClick);
            // 
            // lbCountNumber
            // 
            this.lbCountNumber.AutoSize = true;
            this.lbCountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountNumber.Location = new System.Drawing.Point(706, 97);
            this.lbCountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountNumber.Name = "lbCountNumber";
            this.lbCountNumber.Size = new System.Drawing.Size(108, 17);
            this.lbCountNumber.TabIndex = 22;
            this.lbCountNumber.Text = "Số lượng trả về:";
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(938, 110);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(74, 36);
            this.btnCheckin.TabIndex = 4;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(462, 133);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(73, 17);
            this.lbStatus.TabIndex = 23;
            this.lbStatus.Text = "Trạng thái";
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(465, 424);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(113, 59);
            this.btnHistory.TabIndex = 24;
            this.btnHistory.Text = "Lịch sử checkin";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // FormManagePrivateClass
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 519);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.lbCountNumber);
            this.Controls.Add(this.lbTotalPages);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dgvPrivateClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormManagePrivateClass";
            this.Text = "FormManagePrivateClass";
            this.Load += new System.EventHandler(this.FormManagePrivateClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivateClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbTotalPages;
        private System.Windows.Forms.Label lbPageNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridView dgvPrivateClass;
        private System.Windows.Forms.Label lbCountNumber;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnHistory;
    }
}