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
    public partial class ForumUrunEkle : Form
    {
        UrunPanel panel;
        public ForumUrunEkle(UrunPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void ForumUrunEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
            panel.TabloYenile();
        }

        private void ForumUrunEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Category\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxKategori.DisplayMember = "Name";
            comboBoxKategori.ValueMember = "ID";
            comboBoxKategori.DataSource = dt;
            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            int fiyat = int.Parse(textBoxFiyat.Text);
            float sonuc = fiyat * 0.3f;

            sonuc = fiyat + sonuc;

            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"Product\" (\"Name\",\"CategoryID\",\"Price\",\"KdvliFiyat\") values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.Parameters.AddWithValue("@p2", comboBoxKategori.SelectedValue);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxFiyat.Text));
            komut1.Parameters.AddWithValue("@p4", sonuc);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }
    }
}
