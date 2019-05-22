namespace UI.WinForm
{
    partial class StokHareketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbAyakkabi = new System.Windows.Forms.ComboBox();
            this.nudNumara = new System.Windows.Forms.NumericUpDown();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbGiris = new System.Windows.Forms.RadioButton();
            this.rbCikis = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ayakkabi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adet:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(115, 12);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(203, 39);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbAyakkabi
            // 
            this.cmbAyakkabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cmbAyakkabi.FormattingEnabled = true;
            this.cmbAyakkabi.Location = new System.Drawing.Point(151, 57);
            this.cmbAyakkabi.Name = "cmbAyakkabi";
            this.cmbAyakkabi.Size = new System.Drawing.Size(167, 39);
            this.cmbAyakkabi.TabIndex = 1;
            // 
            // nudNumara
            // 
            this.nudNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nudNumara.Location = new System.Drawing.Point(136, 102);
            this.nudNumara.Name = "nudNumara";
            this.nudNumara.Size = new System.Drawing.Size(182, 38);
            this.nudNumara.TabIndex = 2;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nudAdet.Location = new System.Drawing.Point(96, 146);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(222, 38);
            this.nudAdet.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Islem Yonu:";
            // 
            // rbGiris
            // 
            this.rbGiris.AutoSize = true;
            this.rbGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rbGiris.Location = new System.Drawing.Point(178, 209);
            this.rbGiris.Name = "rbGiris";
            this.rbGiris.Size = new System.Drawing.Size(88, 35);
            this.rbGiris.TabIndex = 3;
            this.rbGiris.TabStop = true;
            this.rbGiris.Text = "Giris";
            this.rbGiris.UseVisualStyleBackColor = true;
            // 
            // rbCikis
            // 
            this.rbCikis.AutoSize = true;
            this.rbCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rbCikis.Location = new System.Drawing.Point(272, 209);
            this.rbCikis.Name = "rbCikis";
            this.rbCikis.Size = new System.Drawing.Size(92, 35);
            this.rbCikis.TabIndex = 3;
            this.rbCikis.TabStop = true;
            this.rbCikis.Text = "Cıkıs";
            this.rbCikis.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnKaydet.Location = new System.Drawing.Point(324, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(40, 199);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // StokHareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 249);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rbCikis);
            this.Controls.Add(this.rbGiris);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.nudNumara);
            this.Controls.Add(this.cmbAyakkabi);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StokHareketForm";
            this.Text = "StokHareketForm";
            this.Load += new System.EventHandler(this.StokHareketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbAyakkabi;
        private System.Windows.Forms.NumericUpDown nudNumara;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbGiris;
        private System.Windows.Forms.RadioButton rbCikis;
        private System.Windows.Forms.Button btnKaydet;
    }
}