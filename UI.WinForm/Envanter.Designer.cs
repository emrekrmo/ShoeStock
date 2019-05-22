namespace UI.WinForm
{
    partial class Envanter
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
            this.btnTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTxt
            // 
            this.btnTxt.Image = global::UI.WinForm.Properties.Resources.iconfinder_185_Design_measure_product_refinement_Development_app_development_4178988;
            this.btnTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTxt.Location = new System.Drawing.Point(530, 12);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(148, 34);
            this.btnTxt.TabIndex = 1;
            this.btnTxt.Text = "Txt Aktar";
            this.btnTxt.UseVisualStyleBackColor = true;
            // 
            // Envanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 379);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Envanter";
            this.Text = "Envanter";
            this.Load += new System.EventHandler(this.Envanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTxt;
    }
}