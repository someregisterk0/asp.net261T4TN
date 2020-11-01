namespace WinAppXemDiem
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
            this.txtReading = new System.Windows.Forms.TextBox();
            this.txtListening = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.lblDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reading";
            // 
            // txtReading
            // 
            this.txtReading.Location = new System.Drawing.Point(152, 27);
            this.txtReading.Name = "txtReading";
            this.txtReading.Size = new System.Drawing.Size(168, 20);
            this.txtReading.TabIndex = 1;
            // 
            // txtListening
            // 
            this.txtListening.Location = new System.Drawing.Point(152, 64);
            this.txtListening.Name = "txtListening";
            this.txtListening.Size = new System.Drawing.Size(168, 20);
            this.txtListening.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listening";
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(152, 105);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(75, 23);
            this.btnXemDiem.TabIndex = 4;
            this.btnXemDiem.Text = "Xem Điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(152, 154);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(31, 13);
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "Điểm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 237);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.txtListening);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReading);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReading;
        private System.Windows.Forms.TextBox txtListening;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Label lblDiem;
    }
}

