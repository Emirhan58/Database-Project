
namespace VeritabaniODEVV
{
    partial class FormPersonel
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
            this.buttonARA = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonARA
            // 
            this.buttonARA.Location = new System.Drawing.Point(585, 71);
            this.buttonARA.Name = "buttonARA";
            this.buttonARA.Size = new System.Drawing.Size(137, 30);
            this.buttonARA.TabIndex = 0;
            this.buttonARA.Text = "ARA";
            this.buttonARA.UseVisualStyleBackColor = true;
            this.buttonARA.Click += new System.EventHandler(this.buttonARA_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(585, 179);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(137, 50);
            this.buttonEkle.TabIndex = 0;
            this.buttonEkle.Text = "PERSONEL EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(836, 216);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(151, 50);
            this.buttonSil.TabIndex = 0;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(836, 151);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(151, 50);
            this.buttonDuzenle.TabIndex = 0;
            this.buttonDuzenle.Text = "DÜZENLE";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(836, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(836, 106);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(151, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(12, 12);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.RowHeadersWidth = 51;
            this.dgwPersonel.RowTemplate.Height = 24;
            this.dgwPersonel.Size = new System.Drawing.Size(497, 254);
            this.dgwPersonel.TabIndex = 2;
            this.dgwPersonel.DoubleClick += new System.EventHandler(this.dgwPersonel_DoubleClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(836, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(585, 36);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(137, 22);
            this.textBoxAra.TabIndex = 4;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 294);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwPersonel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonARA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPersonel";
            this.Text = "Personel Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersonel_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonARA;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAra;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
    }
}

