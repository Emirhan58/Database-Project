
namespace VeritabaniODEVV
{
    partial class SirketPanel
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
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.dgwSirket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSirket)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Location = new System.Drawing.Point(695, 56);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(177, 85);
            this.buttonEKLE.TabIndex = 0;
            this.buttonEKLE.Text = "ŞİRKET EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // dgwSirket
            // 
            this.dgwSirket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSirket.Location = new System.Drawing.Point(12, 12);
            this.dgwSirket.Name = "dgwSirket";
            this.dgwSirket.RowHeadersWidth = 51;
            this.dgwSirket.RowTemplate.Height = 24;
            this.dgwSirket.Size = new System.Drawing.Size(630, 184);
            this.dgwSirket.TabIndex = 4;
            // 
            // SirketPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 220);
            this.Controls.Add(this.dgwSirket);
            this.Controls.Add(this.buttonEKLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SirketPanel";
            this.Text = "SirketPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SirketPanel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSirket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.DataGridView dgwSirket;
    }
}