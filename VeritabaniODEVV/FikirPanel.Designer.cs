
namespace VeritabaniODEVV
{
    partial class FikirPanel
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
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUretkenName = new System.Windows.Forms.TextBox();
            this.textBoxUretkenSurname = new System.Windows.Forms.TextBox();
            this.textBoxUretkenID = new System.Windows.Forms.TextBox();
            this.textBoxUretkenToplam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(12, 12);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.RowHeadersWidth = 51;
            this.dgwPersonel.RowTemplate.Height = 24;
            this.dgwPersonel.Size = new System.Drawing.Size(607, 184);
            this.dgwPersonel.TabIndex = 3;
            this.dgwPersonel.DoubleClick += new System.EventHandler(this.dgwPersonel_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUretkenSurname);
            this.groupBox1.Controls.Add(this.textBoxUretkenName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUretkenToplam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUretkenID);
            this.groupBox1.Location = new System.Drawing.Point(625, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Üretken Personel";
            // 
            // textBoxUretkenName
            // 
            this.textBoxUretkenName.Location = new System.Drawing.Point(125, 58);
            this.textBoxUretkenName.Name = "textBoxUretkenName";
            this.textBoxUretkenName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUretkenName.TabIndex = 0;
            // 
            // textBoxUretkenSurname
            // 
            this.textBoxUretkenSurname.Location = new System.Drawing.Point(125, 89);
            this.textBoxUretkenSurname.Name = "textBoxUretkenSurname";
            this.textBoxUretkenSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxUretkenSurname.TabIndex = 0;
            // 
            // textBoxUretkenID
            // 
            this.textBoxUretkenID.Location = new System.Drawing.Point(125, 30);
            this.textBoxUretkenID.Name = "textBoxUretkenID";
            this.textBoxUretkenID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUretkenID.TabIndex = 0;
            // 
            // textBoxUretkenToplam
            // 
            this.textBoxUretkenToplam.Location = new System.Drawing.Point(125, 117);
            this.textBoxUretkenToplam.Name = "textBoxUretkenToplam";
            this.textBoxUretkenToplam.Size = new System.Drawing.Size(100, 22);
            this.textBoxUretkenToplam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Fikir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyisim";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(725, 175);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(131, 32);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "FİKİR EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(977, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(1103, 49);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(131, 32);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(1103, 12);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(131, 32);
            this.buttonDuzenle.TabIndex = 5;
            this.buttonDuzenle.Text = "DÜZENLE";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Başlık";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Açıklama";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(977, 54);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(977, 88);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(257, 96);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            // 
            // FikirPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 218);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwPersonel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FikirPanel";
            this.Text = "FikirPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FikirPanel_FormClosing);
            this.Load += new System.EventHandler(this.FikirPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUretkenSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUretkenToplam;
        private System.Windows.Forms.TextBox textBoxUretkenID;
        private System.Windows.Forms.TextBox textBoxUretkenName;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
    }
}