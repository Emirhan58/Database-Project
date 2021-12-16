
namespace VeritabaniODEVV
{
    partial class AnaPanel
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
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.buttonUrun = new System.Windows.Forms.Button();
            this.buttonGorev = new System.Windows.Forms.Button();
            this.buttonFikir = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.buttonYonetici = new System.Windows.Forms.Button();
            this.buttonSirket = new System.Windows.Forms.Button();
            this.buttonRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.Location = new System.Drawing.Point(177, 39);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(141, 79);
            this.buttonPersonel.TabIndex = 0;
            this.buttonPersonel.Text = "Personel Paneli";
            this.buttonPersonel.UseVisualStyleBackColor = true;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // buttonUrun
            // 
            this.buttonUrun.Location = new System.Drawing.Point(324, 124);
            this.buttonUrun.Name = "buttonUrun";
            this.buttonUrun.Size = new System.Drawing.Size(141, 79);
            this.buttonUrun.TabIndex = 0;
            this.buttonUrun.Text = "Ürün Paneli";
            this.buttonUrun.UseVisualStyleBackColor = true;
            this.buttonUrun.Click += new System.EventHandler(this.buttonUrun_Click);
            // 
            // buttonGorev
            // 
            this.buttonGorev.Location = new System.Drawing.Point(177, 124);
            this.buttonGorev.Name = "buttonGorev";
            this.buttonGorev.Size = new System.Drawing.Size(141, 79);
            this.buttonGorev.TabIndex = 0;
            this.buttonGorev.Text = "Görev Paneli";
            this.buttonGorev.UseVisualStyleBackColor = true;
            this.buttonGorev.Click += new System.EventHandler(this.buttonGorev_Click);
            // 
            // buttonFikir
            // 
            this.buttonFikir.Location = new System.Drawing.Point(30, 124);
            this.buttonFikir.Name = "buttonFikir";
            this.buttonFikir.Size = new System.Drawing.Size(141, 79);
            this.buttonFikir.TabIndex = 0;
            this.buttonFikir.Text = "Fikir Paneli";
            this.buttonFikir.UseVisualStyleBackColor = true;
            this.buttonFikir.Click += new System.EventHandler(this.buttonFikir_Click);
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.Location = new System.Drawing.Point(471, 124);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(141, 79);
            this.buttonistatistik.TabIndex = 0;
            this.buttonistatistik.Text = "İstatistik Paneli";
            this.buttonistatistik.UseVisualStyleBackColor = true;
            this.buttonistatistik.Click += new System.EventHandler(this.buttonistatistik_Click);
            // 
            // buttonYonetici
            // 
            this.buttonYonetici.Location = new System.Drawing.Point(471, 39);
            this.buttonYonetici.Name = "buttonYonetici";
            this.buttonYonetici.Size = new System.Drawing.Size(141, 79);
            this.buttonYonetici.TabIndex = 0;
            this.buttonYonetici.Text = "Yönetici Paneli";
            this.buttonYonetici.UseVisualStyleBackColor = true;
            this.buttonYonetici.Click += new System.EventHandler(this.buttonYonetici_Click);
            // 
            // buttonSirket
            // 
            this.buttonSirket.Location = new System.Drawing.Point(30, 39);
            this.buttonSirket.Name = "buttonSirket";
            this.buttonSirket.Size = new System.Drawing.Size(141, 79);
            this.buttonSirket.TabIndex = 0;
            this.buttonSirket.Text = "Şirket Paneli";
            this.buttonSirket.UseVisualStyleBackColor = true;
            this.buttonSirket.Click += new System.EventHandler(this.buttonSirket_Click);
            // 
            // buttonRol
            // 
            this.buttonRol.Location = new System.Drawing.Point(324, 39);
            this.buttonRol.Name = "buttonRol";
            this.buttonRol.Size = new System.Drawing.Size(141, 79);
            this.buttonRol.TabIndex = 0;
            this.buttonRol.Text = "Rol Paneli";
            this.buttonRol.UseVisualStyleBackColor = true;
            this.buttonRol.Click += new System.EventHandler(this.buttonRol_Click);
            // 
            // AnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 231);
            this.Controls.Add(this.buttonYonetici);
            this.Controls.Add(this.buttonRol);
            this.Controls.Add(this.buttonistatistik);
            this.Controls.Add(this.buttonGorev);
            this.Controls.Add(this.buttonSirket);
            this.Controls.Add(this.buttonFikir);
            this.Controls.Add(this.buttonUrun);
            this.Controls.Add(this.buttonPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AnaPanel";
            this.Text = "AnaPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.Button buttonUrun;
        private System.Windows.Forms.Button buttonGorev;
        private System.Windows.Forms.Button buttonFikir;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Button buttonYonetici;
        private System.Windows.Forms.Button buttonSirket;
        private System.Windows.Forms.Button buttonRol;
    }
}