
namespace VeritabaniODEVV
{
    partial class FormPersoneleRolEkle
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
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(82, 18);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPersonel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(217, 14);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(153, 67);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(82, 57);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRol.TabIndex = 7;
            // 
            // FormPersoneleRolEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 106);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.comboBoxPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPersoneleRolEkle";
            this.Text = "Personele Rol Ekleme Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersoneleRolEkle_FormClosing);
            this.Load += new System.EventHandler(this.FormPersoneleRolEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRol;
    }
}