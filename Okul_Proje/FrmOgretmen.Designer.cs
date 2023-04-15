namespace Okul_Proje
{
    partial class FrmOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmen));
            this.txtDersler = new System.Windows.Forms.Button();
            this.btnKulupler = new System.Windows.Forms.Button();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.btnOgretmenler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDersler
            // 
            this.txtDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersler.Location = new System.Drawing.Point(75, 52);
            this.txtDersler.Name = "txtDersler";
            this.txtDersler.Size = new System.Drawing.Size(136, 33);
            this.txtDersler.TabIndex = 0;
            this.txtDersler.Text = "Dersler";
            this.txtDersler.UseVisualStyleBackColor = true;
            this.txtDersler.Click += new System.EventHandler(this.txtDersler_Click);
            // 
            // btnKulupler
            // 
            this.btnKulupler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulupler.Location = new System.Drawing.Point(75, 102);
            this.btnKulupler.Name = "btnKulupler";
            this.btnKulupler.Size = new System.Drawing.Size(136, 33);
            this.btnKulupler.TabIndex = 1;
            this.btnKulupler.Text = "Kulüpler";
            this.btnKulupler.UseVisualStyleBackColor = true;
            this.btnKulupler.Click += new System.EventHandler(this.btnKulupler_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotlar.Location = new System.Drawing.Point(75, 150);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(136, 33);
            this.btnNotlar.TabIndex = 2;
            this.btnNotlar.Text = "Notlar";
            this.btnNotlar.UseVisualStyleBackColor = true;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // btnOgretmenler
            // 
            this.btnOgretmenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenler.Location = new System.Drawing.Point(75, 200);
            this.btnOgretmenler.Name = "btnOgretmenler";
            this.btnOgretmenler.Size = new System.Drawing.Size(136, 33);
            this.btnOgretmenler.TabIndex = 3;
            this.btnOgretmenler.Text = "Öğretmenler";
            this.btnOgretmenler.UseVisualStyleBackColor = true;
            this.btnOgretmenler.Click += new System.EventHandler(this.btnOgretmenler_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 291);
            this.Controls.Add(this.btnOgretmenler);
            this.Controls.Add(this.btnNotlar);
            this.Controls.Add(this.btnKulupler);
            this.Controls.Add(this.txtDersler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtDersler;
        private System.Windows.Forms.Button btnKulupler;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.Button btnOgretmenler;
    }
}