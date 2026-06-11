
namespace TickVibe
{
    partial class frmAttachmentViewVN
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
            this.picbAttachment = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.siticoneShadowPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picbAttachment)).BeginInit();
            this.siticoneShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbAttachment
            // 
            this.picbAttachment.BackColor = System.Drawing.Color.White;
            this.picbAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAttachment.Location = new System.Drawing.Point(12, 12);
            this.picbAttachment.Name = "picbAttachment";
            this.picbAttachment.Size = new System.Drawing.Size(860, 634);
            this.picbAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbAttachment.TabIndex = 118;
            this.picbAttachment.TabStop = false;
            this.picbAttachment.Click += new System.EventHandler(this.picbAttachment_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(802, 22);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 26);
            this.lblExit.TabIndex = 119;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.AutoSize = true;
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.lblExit);
            this.siticoneShadowPanel1.Controls.Add(this.picbAttachment);
            this.siticoneShadowPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 5;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.siticoneShadowPanel1.ShadowDepth = 250;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(884, 658);
            this.siticoneShadowPanel1.TabIndex = 174;
            // 
            // frmAttachmentViewVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 658);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttachmentViewVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAttachmentViewVN";
            ((System.ComponentModel.ISupportInitialize)(this.picbAttachment)).EndInit();
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbAttachment;
        private System.Windows.Forms.Label lblExit;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
    }
}