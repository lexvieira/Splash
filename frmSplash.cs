using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class frmSplash : Form
    {
        string appDirectory = GetFile();
        public frmSplash()
        {
            InitializeComponent();

            verifyAdvertising();

        }

        private void FrmSplash_ResizeEnd(object sender, EventArgs e)
        {
            this.ClientSize = this.picAdvertising.Size;
            this.lblAlert.Width = this.Width;
            this.lblAlert.Location = new Point((this.ClientSize.Width / 2) - (this.lblAlert.Width / 2), (this.ClientSize.Height / 4) - ((this.lblAlert.Height / 2)+30));
            this.btnReload.Location = new Point((this.ClientSize.Width / 2) - (this.btnReload.Width/2), (this.ClientSize.Height/2) - (this.btnReload.Height / 2));
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            appDirectory = GetFile();

            verifyAdvertising();
        }

        private void verifyAdvertising() {
            if (System.IO.File.Exists(appDirectory))
            {
                this.picAdvertising.Image = Image.FromFile(appDirectory);
                this.ClientSize = this.picAdvertising.Size;
                this.lblAlert.Visible = false;
                this.btnReload.Visible = false;
            }
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
        private static string GetFile()
        {
            String searchFolder = AppDomain.CurrentDomain.BaseDirectory;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "bmp" };
            var files = GetFilesFrom(searchFolder, filters, false);
            if (files.Length == 0)
                return null;
            return files[0];
        }

    }
}
