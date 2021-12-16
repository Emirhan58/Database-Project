
namespace VeritabaniODEVV
{
    partial class IstatistikPanel
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
            this.dgwIstatistik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIstatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIstatistik
            // 
            this.dgwIstatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIstatistik.Location = new System.Drawing.Point(12, 36);
            this.dgwIstatistik.Name = "dgwIstatistik";
            this.dgwIstatistik.RowHeadersWidth = 51;
            this.dgwIstatistik.RowTemplate.Height = 24;
            this.dgwIstatistik.Size = new System.Drawing.Size(503, 90);
            this.dgwIstatistik.TabIndex = 4;
            // 
            // IstatistikPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 141);
            this.Controls.Add(this.dgwIstatistik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IstatistikPanel";
            this.Text = "IstatistikPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IstatistikPanel_FormClosing);
            this.Load += new System.EventHandler(this.IstatistikPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIstatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIstatistik;
    }
}