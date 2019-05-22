namespace UI.WinForm
{
    partial class AyakkabilarForm
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
            this.lbAyakkabilarForm = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAyakkabilarForm
            // 
            this.lbAyakkabilarForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAyakkabilarForm.FormattingEnabled = true;
            this.lbAyakkabilarForm.Location = new System.Drawing.Point(0, 0);
            this.lbAyakkabilarForm.Name = "lbAyakkabilarForm";
            this.lbAyakkabilarForm.Size = new System.Drawing.Size(171, 270);
            this.lbAyakkabilarForm.TabIndex = 0;
            this.lbAyakkabilarForm.SelectedIndexChanged += new System.EventHandler(this.lbAyakkabilarForm_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuzenle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lblCins);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblMarka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(177, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaylar";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(479, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(33, 252);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Duzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(518, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 84);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(122, 215);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(78, 26);
            this.lblCins.TabIndex = 1;
            this.lblCins.Text = "lblCins";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(122, 160);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(112, 26);
            this.lblCinsiyet.TabIndex = 1;
            this.lblCinsiyet.Text = "lblCinsiyet";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(122, 105);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(93, 26);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "lblModel";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(122, 50);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(94, 26);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "lblMarka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // AyakkabilarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAyakkabilarForm);
            this.Name = "AyakkabilarForm";
            this.Text = "AyakkabilarForm";
            this.Load += new System.EventHandler(this.AyakkabilarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAyakkabilarForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuzenle;
    }
}