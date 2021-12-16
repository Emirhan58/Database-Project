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
    public partial class IstatistikPanel : Form
    {
        AnaPanel panel;
        public IstatistikPanel(AnaPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");


        private void IstatistikPanel_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"CountTable\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwIstatistik.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void IstatistikPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
        }
    }
}
