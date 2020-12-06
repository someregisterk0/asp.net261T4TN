namespace FormBaoBuaKeo
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
            this.btnBao = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNguoiChon = new System.Windows.Forms.Label();
            this.lblMayChon = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(53, 22);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(95, 37);
            this.btnBao.TabIndex = 0;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(394, 22);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(95, 37);
            this.btnKeo.TabIndex = 1;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(222, 22);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(95, 37);
            this.btnBua.TabIndex = 2;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máy";
            // 
            // lblNguoiChon
            // 
            this.lblNguoiChon.AutoSize = true;
            this.lblNguoiChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiChon.Location = new System.Drawing.Point(230, 102);
            this.lblNguoiChon.Name = "lblNguoiChon";
            this.lblNguoiChon.Size = new System.Drawing.Size(42, 24);
            this.lblNguoiChon.TabIndex = 5;
            this.lblNguoiChon.Text = "N/A";
            // 
            // lblMayChon
            // 
            this.lblMayChon.AutoSize = true;
            this.lblMayChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayChon.Location = new System.Drawing.Point(230, 138);
            this.lblMayChon.Name = "lblMayChon";
            this.lblMayChon.Size = new System.Drawing.Size(42, 24);
            this.lblMayChon.TabIndex = 6;
            this.lblMayChon.Text = "N/A";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(230, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 24);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 285);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMayChon);
            this.Controls.Add(this.lblNguoiChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.btnBao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNguoiChon;
        private System.Windows.Forms.Label lblMayChon;
        private System.Windows.Forms.Label lblResult;
    }
}

