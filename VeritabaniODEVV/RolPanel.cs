using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniODEVV
{
    public partial class RolPanel : Form
    {
        AnaPanel panel;
        public RolPanel(AnaPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        private void RolPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
        }

        private void buttonRolEkle_Click(object sender, EventArgs e)
        {
            FormRolEkle form = new FormRolEkle(this);
            form.Show();
            this.Hide();
        }

        private void buttonPersoneleRolEkle_Click(object sender, EventArgs e)
        {
            FormPersoneleRolEkle form = new FormPersoneleRolEkle(this);
            form.Show();
            this.Hide();
        }
    }
}
