namespace UI.WinForm
{
    partial class AyakkabiEkleForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbUnisex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(261, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 84);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(78, 23);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(256, 21);
            this.cmbMarka.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(77, 74);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(223, 20);
            this.txtModel.TabIndex = 7;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Location = new System.Drawing.Point(78, 124);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(175, 21);
            this.cmbCins.TabIndex = 6;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(79, 178);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 8;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(137, 178);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 8;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Location = new System.Drawing.Point(196, 178);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(57, 17);
            this.rbUnisex.TabIndex = 8;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // AyakkabiEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 207);
            this.Controls.Add(this.rbUnisex);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadin);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AyakkabiEkleForm";
            this.Text = "AyakkabiEkleForm";
            this.Load += new System.EventHandler(this.AyakkabiEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbUnisex;
    }
}