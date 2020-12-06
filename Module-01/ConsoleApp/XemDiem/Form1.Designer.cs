namespace XemDiem
{
    partial class Form1
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
            this.nudMon1 = new System.Windows.Forms.NumericUpDown();
            this.nudMon2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMon3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxKhuVuc = new System.Windows.Forms.ComboBox();
            this.cbxDoiTuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.nudDiemChuan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemChuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn 1";
            // 
            // nudMon1
            // 
            this.nudMon1.Location = new System.Drawing.Point(112, 56);
            this.nudMon1.Name = "nudMon1";
            this.nudMon1.Size = new System.Drawing.Size(120, 20);
            this.nudMon1.TabIndex = 1;
            // 
            // nudMon2
            // 
            this.nudMon2.Location = new System.Drawing.Point(345, 56);
            this.nudMon2.Name = "nudMon2";
            this.nudMon2.Size = new System.Drawing.Size(120, 20);
            this.nudMon2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn 2";
            // 
            // nudMon3
            // 
            this.nudMon3.Location = new System.Drawing.Point(612, 56);
            this.nudMon3.Name = "nudMon3";
            this.nudMon3.Size = new System.Drawing.Size(120, 20);
            this.nudMon3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khu vực";
            // 
            // cbxKhuVuc
            // 
            this.cbxKhuVuc.FormattingEnabled = true;
            this.cbxKhuVuc.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxKhuVuc.Location = new System.Drawing.Point(344, 11);
            this.cbxKhuVuc.Name = "cbxKhuVuc";
            this.cbxKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cbxKhuVuc.TabIndex = 7;
            // 
            // cbxDoiTuong
            // 
            this.cbxDoiTuong.FormattingEnabled = true;
            this.cbxDoiTuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxDoiTuong.Location = new System.Drawing.Point(612, 11);
            this.cbxDoiTuong.Name = "cbxDoiTuong";
            this.cbxDoiTuong.Size = new System.Drawing.Size(121, 21);
            this.cbxDoiTuong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đối tượng";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(164, 118);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 32);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "Xem kết quả";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(301, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Result";
            // 
            // nudDiemChuan
            // 
            this.nudDiemChuan.Location = new System.Drawing.Point(112, 12);
            this.nudDiemChuan.Name = "nudDiemChuan";
            this.nudDiemChuan.Size = new System.Drawing.Size(120, 20);
            this.nudDiemChuan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Điểm chuẩn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.nudDiemChuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cbxDoiTuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxKhuVuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMon3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMon2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMon1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemChuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMon1;
        private System.Windows.Forms.NumericUpDown nudMon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMon3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKhuVuc;
        private System.Windows.Forms.ComboBox cbxDoiTuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown nudDiemChuan;
        private System.Windows.Forms.Label label6;
    }
}

