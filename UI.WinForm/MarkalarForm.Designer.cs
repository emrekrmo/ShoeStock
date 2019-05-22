namespace UI.WinForm
{
    partial class MarkalarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarkalar = new System.Windows.Forms.TextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnDuzenle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markalar";
            // 
            // txtMarkalar
            // 
            this.txtMarkalar.Location = new System.Drawing.Point(9, 20);
            this.txtMarkalar.Name = "txtMarkalar";
            this.txtMarkalar.Size = new System.Drawing.Size(355, 47);
            this.txtMarkalar.TabIndex = 1;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(529, 364);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(190, 86);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Duzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(725, 364);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 86);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 315);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.Marka_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMarkalar);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Location = new System.Drawing.Point(3, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 109);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(370, 7);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(147, 86);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // MarkalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "MarkalarForm";
            this.Text = "MarkalarForm";
            this.Load += new System.EventHandler(this.MarkalarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtMarkalar;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
    }
}