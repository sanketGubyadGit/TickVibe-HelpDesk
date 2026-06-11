namespace TickVibe
{
    partial class frmNotificationAL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new Siticone.UI.WinForms.SiticoneButton();
            this.btnMarkAsRead = new Siticone.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 324);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticonePanel1.Location = new System.Drawing.Point(2, 11);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(380, 385);
            this.siticonePanel1.TabIndex = 2;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.Teal;
            this.siticonePanel2.BorderRadius = 2;
            this.siticonePanel2.BorderThickness = 1;
            this.siticonePanel2.Controls.Add(this.label1);
            this.siticonePanel2.Controls.Add(this.dataGridView1);
            this.siticonePanel2.Controls.Add(this.btnclear);
            this.siticonePanel2.Controls.Add(this.btnMarkAsRead);
            this.siticonePanel2.CustomBorderColor = System.Drawing.Color.Teal;
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticonePanel2.Location = new System.Drawing.Point(2, 2);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(376, 380);
            this.siticonePanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notification";
            // 
            // btnclear
            // 
            this.btnclear.CheckedState.Parent = this.btnclear;
            this.btnclear.CustomImages.Parent = this.btnclear;
            this.btnclear.FillColor = System.Drawing.Color.Empty;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.HoveredState.Parent = this.btnclear;
            this.btnclear.Location = new System.Drawing.Point(194, 358);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.Parent = this.btnclear;
            this.btnclear.Size = new System.Drawing.Size(87, 20);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.Visible = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.CheckedState.Parent = this.btnMarkAsRead;
            this.btnMarkAsRead.CustomImages.Parent = this.btnMarkAsRead;
            this.btnMarkAsRead.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarkAsRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsRead.ForeColor = System.Drawing.Color.Black;
            this.btnMarkAsRead.HoveredState.Parent = this.btnMarkAsRead;
            this.btnMarkAsRead.Location = new System.Drawing.Point(2, 358);
            this.btnMarkAsRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.ShadowDecoration.Parent = this.btnMarkAsRead;
            this.btnMarkAsRead.Size = new System.Drawing.Size(124, 20);
            this.btnMarkAsRead.TabIndex = 3;
            this.btnMarkAsRead.Text = "Mark As Read";
            this.btnMarkAsRead.Click += new System.EventHandler(this.btnMarkAsRead_Click);
            // 
            // frmNotificationAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 397);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNotificationAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmNotificationAL";
            this.Load += new System.EventHandler(this.frmNotificationAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneButton btnclear;
        private Siticone.UI.WinForms.SiticoneButton btnMarkAsRead;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label label1;
    }
}