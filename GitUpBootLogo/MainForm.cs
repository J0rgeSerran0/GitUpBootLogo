namespace GitUpBootLogo
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public MainForm()
        {
            InitializeComponent();

            // PlaceHolders
            SendMessage(this.txtFreeText.Handle, EM_SETCUEBANNER, 0, "(Free text)");

            SendMessage(this.txtName.Handle, EM_SETCUEBANNER, 0, "(Name)");
            SendMessage(this.txtPhone.Handle, EM_SETCUEBANNER, 0, "(Phone Number)");
            SendMessage(this.txtEmail.Handle, EM_SETCUEBANNER, 0, "(Email)");

            SendMessage(this.txtPath.Handle, EM_SETCUEBANNER, 0, "(Path)");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.txtPath.Text = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + "\\";
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (!String.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                this.txtPath.Text = folderBrowserDialog.SelectedPath.TrimEnd('\\') + "\\";
            }
        }

        private void btnSaveCustomBootLogo_Click(object sender, EventArgs e)
        {
            if (GenerateGitUpBootLogo())
            {
                MessageBox.Show("The GitUp Boot Logo has been generated");
            }
            else
            {
                MessageBox.Show("An error ocurred while the GitUp Boot Logo was being generating");
            }
        }

        private bool GenerateGitUpBootLogo()
        {
            try
            {
                this.picResult.Image = null;
                this.lblFileSize.Text = String.Empty;

                var image = Properties.Resources.Base;

                var fileImage = this.txtPath.Text + "logo.jpg";

                if (File.Exists(fileImage))
                {
                    File.Delete(fileImage);
                }

                using (var graphics = Graphics.FromImage(image))
                {
                    var font = new Font("Segoe UI", 16, FontStyle.Regular, GraphicsUnit.Pixel);
                    graphics.DrawString(this.txtFreeText.Text, font, Brushes.Black, 12, 50);

                    font = new Font("Segoe UI", 22, FontStyle.Bold, GraphicsUnit.Pixel);
                    graphics.DrawString(this.txtName.Text, font, Brushes.Black, 12, 80);
                    graphics.DrawString(this.txtPhone.Text, font, Brushes.Black, 12, 110);

                    font = new Font("Segoe UI", 18, FontStyle.Regular, GraphicsUnit.Pixel);
                    graphics.DrawString(this.txtEmail.Text, font, Brushes.Black, 12, 150);

                    image.Save(fileImage, image.RawFormat);
                }

                using (var fs = new FileStream(fileImage, FileMode.Open, FileAccess.Read))
                {
                    this.picResult.Image = Image.FromStream(fs);
                }

                long size = new FileInfo(fileImage).Length;
                int magnitude = (int)Math.Log(size, 1024);
                decimal adjustedSize = (decimal)size / (1L << (magnitude * 10));
                this.lblFileSize.Text = String.Format("{0} Kb", adjustedSize.ToString().Substring(0, 5));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}