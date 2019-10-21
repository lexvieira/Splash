using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class frmSplash : Form
    {
        string appDirectory = AppDomain.CurrentDomain.BaseDirectory + "propaganda.jpg";
        public frmSplash()
        {
            InitializeComponent();

            verifyAdvertising();

        }

        private void FrmSplash_ResizeEnd(object sender, EventArgs e)
        {
            this.picAdvertising.Size = this.ClientSize;
            this.lblAlert.Width = this.Width;
            this.lblAlert.Location = new Point((this.ClientSize.Width / 2) - (this.lblAlert.Width / 2), (this.ClientSize.Height / 2) - ((this.lblAlert.Height / 2)+30));
            this.btnReload.Location = new Point((this.ClientSize.Width / 2) - (this.btnReload.Width/2), (this.ClientSize.Height/2) - (this.btnReload.Height / 2));
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            verifyAdvertising();
        }

        private void verifyAdvertising() {
            if (System.IO.File.Exists(appDirectory))
            {
                this.picAdvertising.ImageLocation = appDirectory;
                this.lblAlert.Visible = false;
                this.btnReload.Visible = false;
            }
            else
            {
                this.lblAlert.Visible = true;
                this.btnReload.Visible = true;
            }

        }
    }
}
