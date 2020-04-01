namespace Afo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forsikringerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lægeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.købtemedecinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transporttilandredepotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.købtevarerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.depotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forsikringerToolStripMenuItem,
            this.firmaerToolStripMenuItem,
            this.lægeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // forsikringerToolStripMenuItem
            // 
            this.forsikringerToolStripMenuItem.Name = "forsikringerToolStripMenuItem";
            this.forsikringerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forsikringerToolStripMenuItem.Text = "forsikringer";
            this.forsikringerToolStripMenuItem.Click += new System.EventHandler(this.ForsikringerToolStripMenuItem_Click);
            // 
            // firmaerToolStripMenuItem
            // 
            this.firmaerToolStripMenuItem.Name = "firmaerToolStripMenuItem";
            this.firmaerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaerToolStripMenuItem.Text = "firmaer";
            this.firmaerToolStripMenuItem.Click += new System.EventHandler(this.FirmaerToolStripMenuItem_Click);
            // 
            // lægeToolStripMenuItem
            // 
            this.lægeToolStripMenuItem.Name = "lægeToolStripMenuItem";
            this.lægeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lægeToolStripMenuItem.Text = "læge";
            this.lægeToolStripMenuItem.Click += new System.EventHandler(this.LægeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // depotToolStripMenuItem
            // 
            this.depotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.købtemedecinerToolStripMenuItem,
            this.købtevarerToolStripMenuItem,
            this.transporttilandredepotToolStripMenuItem});
            this.depotToolStripMenuItem.Name = "depotToolStripMenuItem";
            this.depotToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.depotToolStripMenuItem.Text = "depo";
            // 
            // købtemedecinerToolStripMenuItem
            // 
            this.købtemedecinerToolStripMenuItem.Name = "købtemedecinerToolStripMenuItem";
            this.købtemedecinerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.købtemedecinerToolStripMenuItem.Text = "købtemedeciner";
            this.købtemedecinerToolStripMenuItem.Click += new System.EventHandler(this.KøbtemedecinerToolStripMenuItem_Click);
            // 
            // transporttilandredepotToolStripMenuItem
            // 
            this.transporttilandredepotToolStripMenuItem.Name = "transporttilandredepotToolStripMenuItem";
            this.transporttilandredepotToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.transporttilandredepotToolStripMenuItem.Text = "transporttilandredepot";
            this.transporttilandredepotToolStripMenuItem.Click += new System.EventHandler(this.TransporttilandredepotToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Afo.Properties.Resources.daro;
            this.pictureBox1.Location = new System.Drawing.Point(72, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // købtevarerToolStripMenuItem
            // 
            this.købtevarerToolStripMenuItem.Name = "købtevarerToolStripMenuItem";
            this.købtevarerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.købtevarerToolStripMenuItem.Text = " købtevarer";
            this.købtevarerToolStripMenuItem.Click += new System.EventHandler(this.KøbtevarertoolStripSeparator2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(619, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APOTEK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void ForsikringerToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forsikringerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lægeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem købtemedecinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transporttilandredepotToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem købtevarerToolStripMenuItem;
    }
}
