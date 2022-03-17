namespace WinformManageTelegym.ChildrenForm
{
    partial class FormRatingCoach
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCoachName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmailCoach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên HLV:";
            // 
            // lbCoachName
            // 
            this.lbCoachName.AutoSize = true;
            this.lbCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoachName.Location = new System.Drawing.Point(235, 58);
            this.lbCoachName.Name = "lbCoachName";
            this.lbCoachName.Size = new System.Drawing.Size(33, 17);
            this.lbCoachName.TabIndex = 0;
            this.lbCoachName.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email HLV:";
            // 
            // lbEmailCoach
            // 
            this.lbEmailCoach.AutoSize = true;
            this.lbEmailCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailCoach.Location = new System.Drawing.Point(235, 122);
            this.lbEmailCoach.Name = "lbEmailCoach";
            this.lbEmailCoach.Size = new System.Drawing.Size(42, 17);
            this.lbEmailCoach.TabIndex = 0;
            this.lbEmailCoach.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đánh giá điểm:";
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 1;
            this.numRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRating.Location = new System.Drawing.Point(238, 189);
            this.numRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(68, 23);
            this.numRating.TabIndex = 1;
            // 
            // btnRating
            // 
            this.btnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.Location = new System.Drawing.Point(107, 256);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(94, 40);
            this.btnRating.TabIndex = 2;
            this.btnRating.Text = "Đánh giá";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(249, 256);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormRatingCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 321);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbEmailCoach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCoachName);
            this.Controls.Add(this.label1);
            this.Name = "FormRatingCoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá về huấn luyện viên";
            this.Load += new System.EventHandler(this.FormRatingCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCoachName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmailCoach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.Button btnReturn;
    }
}