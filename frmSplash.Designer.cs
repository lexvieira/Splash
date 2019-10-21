using System;

namespace Splash
{
    partial class frmSplash
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
            this.picAdvertising = new System.Windows.Forms.PictureBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvertising)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdvertising
            // 
            this.picAdvertising.Location = new System.Drawing.Point(0, 0);
            this.picAdvertising.Name = "picAdvertising";
            this.picAdvertising.Size = new System.Drawing.Size(50, 50);
            this.picAdvertising.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAdvertising.TabIndex = 0;
            this.picAdvertising.TabStop = false;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Crimson;
            this.lblAlert.Location = new System.Drawing.Point(110, 142);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(573, 40);
            this.lblAlert.TabIndex = 1;
            this.lblAlert.Text = "Verifique se a imagem com o nome Propaganda está na mesma pasta do App ;)\r\nExtens" +
    "ões disponíveis: \"gif\", \"jpeg\", \"jpg,\",\"png\",\"bmp\"";
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReload.Location = new System.Drawing.Point(328, 247);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(145, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Recarregar Imagem";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.picAdvertising);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.Text = "Splash Screen";
            this.ResizeEnd += new System.EventHandler(this.FrmSplash_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picAdvertising)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdvertising;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btnReload;
    }
}

