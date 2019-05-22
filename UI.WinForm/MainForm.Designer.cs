namespace UI.WinForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yonetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayakkabilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokHareketiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yonetimToolStripMenuItem,
            this.stokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yonetimToolStripMenuItem
            // 
            this.yonetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markalarToolStripMenuItem,
            this.ayakkabilarToolStripMenuItem});
            this.yonetimToolStripMenuItem.Name = "yonetimToolStripMenuItem";
            this.yonetimToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.yonetimToolStripMenuItem.Text = "Yonetim";
            // 
            // markalarToolStripMenuItem
            // 
            this.markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            this.markalarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.markalarToolStripMenuItem.Text = "Markalar";
            this.markalarToolStripMenuItem.Click += new System.EventHandler(this.markalarToolStripMenuItem_Click);
            // 
            // ayakkabilarToolStripMenuItem
            // 
            this.ayakkabilarToolStripMenuItem.Name = "ayakkabilarToolStripMenuItem";
            this.ayakkabilarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ayakkabilarToolStripMenuItem.Text = "Ayakkabilar";
            this.ayakkabilarToolStripMenuItem.Click += new System.EventHandler(this.ayakkabilarToolStripMenuItem_Click);
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokHareketiOlusturToolStripMenuItem});
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.stokToolStripMenuItem.Text = "Stok";
            // 
            // stokHareketiOlusturToolStripMenuItem
            // 
            this.stokHareketiOlusturToolStripMenuItem.Name = "stokHareketiOlusturToolStripMenuItem";
            this.stokHareketiOlusturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokHareketiOlusturToolStripMenuItem.Text = "StokHareketiOlustur";
            this.stokHareketiOlusturToolStripMenuItem.Click += new System.EventHandler(this.stokHareketiOlusturToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::UI.WinForm.Properties.Resources.iconfinder_Shoes_1_753878___Kopya__2_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton1.Text = "MarkaEkle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::UI.WinForm.Properties.Resources.iconfinder_Shoes_1_753878;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton2.Text = "AyakkabıEkle";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::UI.WinForm.Properties.Resources.iconfinder_Shoes_1_753878___Kopya;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton3.Text = "StokHareket";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::UI.WinForm.Properties.Resources.iconfinder_185_Design_measure_product_refinement_Development_app_development_4178988;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton4.Text = "Envanter";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yonetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayakkabilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stokHareketiOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}