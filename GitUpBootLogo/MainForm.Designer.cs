namespace GitUpBootLogo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSaveCustomBootLogo = new System.Windows.Forms.Button();
            this.txtFreeText = new System.Windows.Forms.TextBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(299, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(24, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(299, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(675, 46);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(108, 37);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPath.Location = new System.Drawing.Point(24, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(759, 22);
            this.txtPath.TabIndex = 0;
            // 
            // btnSaveCustomBootLogo
            // 
            this.btnSaveCustomBootLogo.Location = new System.Drawing.Point(129, 230);
            this.btnSaveCustomBootLogo.Name = "btnSaveCustomBootLogo";
            this.btnSaveCustomBootLogo.Size = new System.Drawing.Size(194, 37);
            this.btnSaveCustomBootLogo.TabIndex = 6;
            this.btnSaveCustomBootLogo.Text = "Save Custom Boot Logo";
            this.btnSaveCustomBootLogo.UseVisualStyleBackColor = true;
            this.btnSaveCustomBootLogo.Click += new System.EventHandler(this.btnSaveCustomBootLogo_Click);
            // 
            // txtFreeText
            // 
            this.txtFreeText.Location = new System.Drawing.Point(24, 70);
            this.txtFreeText.Name = "txtFreeText";
            this.txtFreeText.Size = new System.Drawing.Size(299, 22);
            this.txtFreeText.TabIndex = 2;
            // 
            // picResult
            // 
            this.picResult.Image = ((System.Drawing.Image)(resources.GetObject("picResult.Image")));
            this.picResult.Location = new System.Drawing.Point(361, 70);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(270, 197);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 7;
            this.picResult.TabStop = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(363, 267);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(0, 17);
            this.lblFileSize.TabIndex = 8;
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 292);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.txtFreeText);
            this.Controls.Add(this.btnSaveCustomBootLogo);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitUp Custom Boot Logo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSaveCustomBootLogo;
        private System.Windows.Forms.TextBox txtFreeText;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblFileSize;
    }
}

