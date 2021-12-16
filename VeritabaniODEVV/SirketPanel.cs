using Npgsql;
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
    public partial class SirketPanel : Form
    {
        AnaPanel panel;
        public SirketPanel(AnaPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void SirketPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
        }

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Company\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwSirket.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            FormSirketEkle form = new FormSirketEkle(this);
            form.Show();
            this.Hide();
        }
    }
}
