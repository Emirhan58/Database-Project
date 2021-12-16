
namespace VeritabaniODEVV
{
    partial class UrunPanel
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
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKategoriEkle = new System.Windows.Forms.Button();
            this.buttonARA = new System.Windows.Forms.Button();
            this.textBoxKdvFiyat = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrun
            // 
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(12, 12);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.RowHeadersWidth = 51;
            this.dgwUrun.RowTemplate.Height = 24;
            this.dgwUrun.Size = new System.Drawing.Size(738, 308);
            this.dgwUrun.TabIndex = 13;
            this.dgwUrun.DoubleClick += new System.EventHandler(this.dgwUrun_DoubleClick);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(785, 61);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(137, 22);
            this.textBoxAra.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(996, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "İsim:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(1036, 24);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 22);
            this.textBoxID.TabIndex = 18;
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(1036, 94);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(151, 22);
            this.textBoxKategori.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1036, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 22);
            this.textBoxName.TabIndex = 20;
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(1036, 192);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(151, 50);
            this.buttonDuzenle.TabIndex = 14;
            this.buttonDuzenle.Text = "DÜZENLE";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(1036, 259);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(151, 50);
            this.buttonSil.TabIndex = 15;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonKategoriEkle
            // 
            this.buttonKategoriEkle.Location = new System.Drawing.Point(785, 192);
            this.buttonKategoriEkle.Name = "buttonKategoriEkle";
            this.buttonKategoriEkle.Size = new System.Drawing.Size(137, 50);
            this.buttonKategoriEkle.TabIndex = 16;
            this.buttonKategoriEkle.Text = "KATEGORİ EKLE";
            this.buttonKategoriEkle.UseVisualStyleBackColor = true;
            this.buttonKategoriEkle.Click += new System.EventHandler(this.buttonKategoriEkle_Click);
            // 
            // buttonARA
            // 
            this.buttonARA.Location = new System.Drawing.Point(785, 96);
            this.buttonARA.Name = "buttonARA";
            this.buttonARA.Size = new System.Drawing.Size(137, 30);
            this.buttonARA.TabIndex = 17;
            this.buttonARA.Text = "ARA";
            this.buttonARA.UseVisualStyleBackColor = true;
            this.buttonARA.Click += new System.EventHandler(this.buttonARA_Click);
            // 
            // textBoxKdvFiyat
            // 
            this.textBoxKdvFiyat.Location = new System.Drawing.Point(1036, 153);
            this.textBoxKdvFiyat.Name = "textBoxKdvFiyat";
            this.textBoxKdvFiyat.Size = new System.Drawing.Size(151, 22);
            this.textBoxKdvFiyat.TabIndex = 19;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(1036, 125);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(151, 22);
            this.textBoxFiyat.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(939, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kategori ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(945, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kdvli Fiyat:";
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Location = new System.Drawing.Point(785, 259);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(137, 50);
            this.buttonUrunEkle.TabIndex = 16;
            this.buttonUrunEkle.Text = "ÜRÜN EKLE";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 342);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxKdvFiyat);
            this.Controls.Add(this.textBoxKategori);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonUrunEkle);
            this.Controls.Add(this.buttonKategoriEkle);
            this.Controls.Add(this.buttonARA);
            this.Controls.Add(this.dgwUrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.Text = "UrunPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrunPanel_FormClosing);
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonKategoriEkle;
        private System.Windows.Forms.Button buttonARA;
        private System.Windows.Forms.TextBox textBoxKdvFiyat;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUrunEkle;
    }
}