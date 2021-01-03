
namespace WinApp
{
    partial class FormImport
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
            this.btnImport = new System.Windows.Forms.Button();
            this.gvImport = new System.Windows.Forms.DataGridView();
            this.btnImport2 = new System.Windows.Forms.Button();
            this.gvMovie = new System.Windows.Forms.DataGridView();
            this.btnImportMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(126, 21);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(145, 43);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Rating";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gvImport
            // 
            this.gvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvImport.Location = new System.Drawing.Point(12, 99);
            this.gvImport.Name = "gvImport";
            this.gvImport.Size = new System.Drawing.Size(776, 316);
            this.gvImport.TabIndex = 1;
            // 
            // btnImport2
            // 
            this.btnImport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport2.Location = new System.Drawing.Point(295, 21);
            this.btnImport2.Name = "btnImport2";
            this.btnImport2.Size = new System.Drawing.Size(145, 43);
            this.btnImport2.TabIndex = 2;
            this.btnImport2.Text = "Import Rating 2";
            this.btnImport2.UseVisualStyleBackColor = true;
            this.btnImport2.Click += new System.EventHandler(this.btnImport2_Click);
            // 
            // gvMovie
            // 
            this.gvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovie.Location = new System.Drawing.Point(12, 434);
            this.gvMovie.Name = "gvMovie";
            this.gvMovie.Size = new System.Drawing.Size(776, 316);
            this.gvMovie.TabIndex = 3;
            // 
            // btnImportMovie
            // 
            this.btnImportMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMovie.Location = new System.Drawing.Point(514, 21);
            this.btnImportMovie.Name = "btnImportMovie";
            this.btnImportMovie.Size = new System.Drawing.Size(145, 43);
            this.btnImportMovie.TabIndex = 4;
            this.btnImportMovie.Text = "Import Movie";
            this.btnImportMovie.UseVisualStyleBackColor = true;
            this.btnImportMovie.Click += new System.EventHandler(this.btnImportMovie_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 762);
            this.Controls.Add(this.btnImportMovie);
            this.Controls.Add(this.gvMovie);
            this.Controls.Add(this.btnImport2);
            this.Controls.Add(this.gvImport);
            this.Controls.Add(this.btnImport);
            this.Name = "FormImport";
            this.Text = "FormImport";
            ((System.ComponentModel.ISupportInitialize)(this.gvImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView gvImport;
        private System.Windows.Forms.Button btnImport2;
        private System.Windows.Forms.DataGridView gvMovie;
        private System.Windows.Forms.Button btnImportMovie;
    }
}