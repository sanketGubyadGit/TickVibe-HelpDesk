using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TickVibe
{
    public partial class frmAttachmentViewVN : Form
    {
        //here user can view his attachment not make any changes here 
        public frmAttachmentViewVN(string attachment)
        {
            InitializeComponent();
             
            if (!string.IsNullOrEmpty(attachment) && File.Exists(attachment))
            {
                picbAttachment.Image = Image.FromFile(attachment);
            }
            else
            {
                picbAttachment.Image = null; // shows blank space if no image
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picbAttachment_Click(object sender, EventArgs e)
        {

        }
    }
}
