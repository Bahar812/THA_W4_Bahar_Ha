namespace THA_W4_Bahar_H
{
    partial class MainWindowForm
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
            this.btnOpenNextForm = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblMyFavorite = new System.Windows.Forms.Label();
            this.txtboxFavorite = new System.Windows.Forms.TextBox();
            this.cbKonfirmasi = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenNextForm
            // 
            this.btnOpenNextForm.Location = new System.Drawing.Point(38, 31);
            this.btnOpenNextForm.Name = "btnOpenNextForm";
            this.btnOpenNextForm.Size = new System.Drawing.Size(121, 23);
            this.btnOpenNextForm.TabIndex = 0;
            this.btnOpenNextForm.Text = "Open Next Form";
            this.btnOpenNextForm.UseVisualStyleBackColor = true;
            this.btnOpenNextForm.Click += new System.EventHandler(this.btnOpenNextForm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(146, 80);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 20);
            this.txtboxName.TabIndex = 2;
            // 
            // lblMyFavorite
            // 
            this.lblMyFavorite.AutoSize = true;
            this.lblMyFavorite.Location = new System.Drawing.Point(35, 112);
            this.lblMyFavorite.Name = "lblMyFavorite";
            this.lblMyFavorite.Size = new System.Drawing.Size(88, 13);
            this.lblMyFavorite.TabIndex = 3;
            this.lblMyFavorite.Text = "My Favorite Artist";
            // 
            // txtboxFavorite
            // 
            this.txtboxFavorite.Location = new System.Drawing.Point(147, 109);
            this.txtboxFavorite.Name = "txtboxFavorite";
            this.txtboxFavorite.Size = new System.Drawing.Size(99, 20);
            this.txtboxFavorite.TabIndex = 4;
            // 
            // cbKonfirmasi
            // 
            this.cbKonfirmasi.AutoSize = true;
            this.cbKonfirmasi.Location = new System.Drawing.Point(38, 148);
            this.cbKonfirmasi.Name = "cbKonfirmasi";
            this.cbKonfirmasi.Size = new System.Drawing.Size(194, 17);
            this.cbKonfirmasi.TabIndex = 5;
            this.cbKonfirmasi.Text = "All of the content I put above is true";
            this.cbKonfirmasi.UseVisualStyleBackColor = true;
            this.cbKonfirmasi.CheckedChanged += new System.EventHandler(this.cbKonfirmasi_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(171, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbKonfirmasi);
            this.Controls.Add(this.txtboxFavorite);
            this.Controls.Add(this.lblMyFavorite);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOpenNextForm);
            this.Name = "MainWindowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNextForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblMyFavorite;
        private System.Windows.Forms.TextBox txtboxFavorite;
        private System.Windows.Forms.CheckBox cbKonfirmasi;
        private System.Windows.Forms.Button btnSubmit;
    }
}

