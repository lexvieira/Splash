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
        string appDirectory = AppDomain.CurrentDomain.BaseDirectory + "propaganda";
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
            verifyAdvertising();
        }

        private void verifyAdvertising() {

            string[] imgs = { "png", "gif", "jpeg", "jpg", "bmp"};

            for (int i = 0; i <= (imgs.Length - 1); i++)
            {
                if (System.IO.File.Exists(appDirectory + "." + imgs[i]))
                {
                    this.picAdvertising.Image = Image.FromFile(appDirectory + "." + imgs[i]);
                    //this.picAdvertising.ImageLocation = appDirectory + "." + imgs[i];
                    this.ClientSize = this.picAdvertising.Size;
                    this.lblAlert.Visible = false;
                    this.btnReload.Visible = false;
                    break;
                }
            }
        }
    }
}
