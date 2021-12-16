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
    public partial class AnaPanel : Form
    {
        public AnaPanel()
        {
            InitializeComponent();
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            FormPersonel form =  new FormPersonel(this);
            form.Show();
            this.Hide();
        }

        private void buttonFikir_Click(object sender, EventArgs e)
        {
            FikirPanel form = new FikirPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonGorev_Click(object sender, EventArgs e)
        {
            GorevPanel form = new GorevPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonUrun_Click(object sender, EventArgs e)
        {
            UrunPanel form = new UrunPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonistatistik_Click(object sender, EventArgs e)
        {
            IstatistikPanel form = new IstatistikPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonYonetici_Click(object sender, EventArgs e)
        {
            YoneticiPanel form = new YoneticiPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonSirket_Click(object sender, EventArgs e)
        {
            SirketPanel form = new SirketPanel(this);
            form.Show();
            this.Hide();
        }

        private void buttonRol_Click(object sender, EventArgs e)
        {
            RolPanel form = new RolPanel(this);
            form.Show();
            this.Hide();
        }
    }
}
