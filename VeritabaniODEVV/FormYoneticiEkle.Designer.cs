﻿
namespace VeritabaniODEVV
{
    partial class FormYoneticiEkle
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
            this.comboBoxDepartman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYonetici = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxDepartman
            // 
            this.comboBoxDepartman.FormattingEnabled = true;
            this.comboBoxDepartman.Location = new System.Drawing.Point(123, 31);
            this.comboBoxDepartman.Name = "comboBoxDepartman";
            this.comboBoxDepartman.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartman.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Departman:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(269, 23);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(153, 56);
            this.buttonEkle.TabIndex = 17;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yönetici:";
            // 
            // comboBoxYonetici
            // 
            this.comboBoxYonetici.FormattingEnabled = true;
            this.comboBoxYonetici.Location = new System.Drawing.Point(123, 64);
            this.comboBoxYonetici.Name = "comboBoxYonetici";
            this.comboBoxYonetici.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYonetici.TabIndex = 23;
            // 
            // FormYoneticiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 110);
            this.Controls.Add(this.comboBoxYonetici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDepartman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormYoneticiEkle";
            this.Text = "FormYoneticiEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormYoneticiEkle_FormClosing);
            this.Load += new System.EventHandler(this.FormYoneticiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYonetici;
    }
}