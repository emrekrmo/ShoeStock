namespace UI.WinForm
{
    partial class AyakkabiDuzenleForm
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
            this.rbUnisex = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbUnisex
            // 
            this.rbUnisex.AutoSize = true;
            this.rbUnisex.Location = new System.Drawing.Point(212, 193);
            this.rbUnisex.Name = "rbUnisex";
            this.rbUnisex.Size = new System.Drawing.Size(57, 17);
            this.rbUnisex.TabIndex = 17;
            this.rbUnisex.TabStop = true;
            this.rbUnisex.Text = "Unisex";
            this.rbUnisex.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(153, 193);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 18;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(95, 193);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 19;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 89);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(223, 20);
            this.txtModel.TabIndex = 16;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Location = new System.Drawing.Point(94, 139);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(175, 21);
            this.cmbCins.TabIndex = 14;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(94, 38);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(256, 21);
            this.cmbMarka.TabIndex = 15;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(277, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 84);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ayakkabi Duzenle";
            // 
            // AyakkabiDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 231);
            this.Controls.Add(this.label5);
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
            this.Name = "AyakkabiDuzenleForm";
            this.Text = "AyakkabiDuzenleForm";
            this.Load += new System.EventHandler(this.AyakkabiDuzenleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUnisex;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}