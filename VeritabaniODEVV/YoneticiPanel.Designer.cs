
namespace VeritabaniODEVV
{
    partial class YoneticiPanel
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
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDepartman = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonYoneticiEkle = new System.Windows.Forms.Button();
            this.buttonDepartmanEkle = new System.Windows.Forms.Button();
            this.buttonARA = new System.Windows.Forms.Button();
            this.dgwYonetici = new System.Windows.Forms.DataGridView();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(688, 65);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(154, 22);
            this.textBoxAra.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Departman ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "İsim:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(968, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 22);
            this.textBoxID.TabIndex = 31;
            // 
            // textBoxDepartman
            // 
            this.textBoxDepartman.Location = new System.Drawing.Point(968, 145);
            this.textBoxDepartman.Name = "textBoxDepartman";
            this.textBoxDepartman.Size = new System.Drawing.Size(151, 22);
            this.textBoxDepartman.TabIndex = 32;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(968, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 22);
            this.textBoxName.TabIndex = 35;
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(968, 206);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(151, 50);
            this.buttonDuzenle.TabIndex = 26;
            this.buttonDuzenle.Text = "DÜZENLE";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(968, 273);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(151, 50);
            this.buttonSil.TabIndex = 27;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonYoneticiEkle
            // 
            this.buttonYoneticiEkle.Location = new System.Drawing.Point(688, 273);
            this.buttonYoneticiEkle.Name = "buttonYoneticiEkle";
            this.buttonYoneticiEkle.Size = new System.Drawing.Size(154, 50);
            this.buttonYoneticiEkle.TabIndex = 29;
            this.buttonYoneticiEkle.Text = "YÖNETİCİ EKLE";
            this.buttonYoneticiEkle.UseVisualStyleBackColor = true;
            this.buttonYoneticiEkle.Click += new System.EventHandler(this.buttonYoneticiEkle_Click);
            // 
            // buttonDepartmanEkle
            // 
            this.buttonDepartmanEkle.Location = new System.Drawing.Point(688, 206);
            this.buttonDepartmanEkle.Name = "buttonDepartmanEkle";
            this.buttonDepartmanEkle.Size = new System.Drawing.Size(154, 50);
            this.buttonDepartmanEkle.TabIndex = 28;
            this.buttonDepartmanEkle.Text = "DEPARTMAN EKLE";
            this.buttonDepartmanEkle.UseVisualStyleBackColor = true;
            this.buttonDepartmanEkle.Click += new System.EventHandler(this.buttonDepartmanEkle_Click);
            // 
            // buttonARA
            // 
            this.buttonARA.Location = new System.Drawing.Point(688, 100);
            this.buttonARA.Name = "buttonARA";
            this.buttonARA.Size = new System.Drawing.Size(154, 38);
            this.buttonARA.TabIndex = 30;
            this.buttonARA.Text = "ARA";
            this.buttonARA.UseVisualStyleBackColor = true;
            this.buttonARA.Click += new System.EventHandler(this.buttonARA_Click);
            // 
            // dgwYonetici
            // 
            this.dgwYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYonetici.Location = new System.Drawing.Point(12, 38);
            this.dgwYonetici.Name = "dgwYonetici";
            this.dgwYonetici.RowHeadersWidth = 51;
            this.dgwYonetici.RowTemplate.Height = 24;
            this.dgwYonetici.Size = new System.Drawing.Size(644, 308);
            this.dgwYonetici.TabIndex = 25;
            this.dgwYonetici.DoubleClick += new System.EventHandler(this.dgwYonetici_DoubleClick);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(968, 110);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(151, 22);
            this.textBoxSurname.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Soyisim:";
            // 
            // YoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 364);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDepartman);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonYoneticiEkle);
            this.Controls.Add(this.buttonDepartmanEkle);
            this.Controls.Add(this.buttonARA);
            this.Controls.Add(this.dgwYonetici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YoneticiPanel";
            this.Text = "YoneticiPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiPanel_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYonetici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDepartman;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonYoneticiEkle;
        private System.Windows.Forms.Button buttonDepartmanEkle;
        private System.Windows.Forms.Button buttonARA;
        private System.Windows.Forms.DataGridView dgwYonetici;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
    }
}