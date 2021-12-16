
namespace VeritabaniODEVV
{
    partial class RolPanel
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
            this.buttonRolEkle = new System.Windows.Forms.Button();
            this.buttonPersoneleRolEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRolEkle
            // 
            this.buttonRolEkle.Location = new System.Drawing.Point(36, 52);
            this.buttonRolEkle.Name = "buttonRolEkle";
            this.buttonRolEkle.Size = new System.Drawing.Size(150, 69);
            this.buttonRolEkle.TabIndex = 0;
            this.buttonRolEkle.Text = "ROL EKLE";
            this.buttonRolEkle.UseVisualStyleBackColor = true;
            this.buttonRolEkle.Click += new System.EventHandler(this.buttonRolEkle_Click);
            // 
            // buttonPersoneleRolEkle
            // 
            this.buttonPersoneleRolEkle.Location = new System.Drawing.Point(215, 52);
            this.buttonPersoneleRolEkle.Name = "buttonPersoneleRolEkle";
            this.buttonPersoneleRolEkle.Size = new System.Drawing.Size(150, 69);
            this.buttonPersoneleRolEkle.TabIndex = 0;
            this.buttonPersoneleRolEkle.Text = "PERSONELE ROL EKLE";
            this.buttonPersoneleRolEkle.UseVisualStyleBackColor = true;
            this.buttonPersoneleRolEkle.Click += new System.EventHandler(this.buttonPersoneleRolEkle_Click);
            // 
            // RolPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 162);
            this.Controls.Add(this.buttonPersoneleRolEkle);
            this.Controls.Add(this.buttonRolEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RolPanel";
            this.Text = "RolPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRolEkle;
        private System.Windows.Forms.Button buttonPersoneleRolEkle;
    }
}