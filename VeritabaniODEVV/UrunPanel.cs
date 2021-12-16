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
    public partial class UrunPanel : Form
    {
        AnaPanel anapanel;
        public UrunPanel(AnaPanel _anaPanel)
        {
            anapanel = _anaPanel;
            InitializeComponent();
            textBoxID.Enabled = false;
            textBoxKdvFiyat.Enabled = false;
            textBoxKategori.Enabled = false;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            TabloYenile();
        }

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Product\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwUrun.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void UrunPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            anapanel.Show();
        }

        private void buttonARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = $"Select * from public.\"Product\" where \"Name\" like '%{textBoxAra.Text}%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwUrun.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            int fiyat = int.Parse(textBoxFiyat.Text);
            float sonuc = fiyat * 0.3f;

            sonuc = fiyat + sonuc;

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update public.\"Product\" set \"Name\" = @p1 , \"Price\" = @p2 ,\"KdvliFiyat\" = @p4 where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.Parameters.AddWithValue("@p2", int.Parse(textBoxFiyat.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.Parameters.AddWithValue("@p4", sonuc);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün düzenleme işlemi başarılı bir şekilde gerçekleştirildi");
            TabloYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from public.\"Product\" where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleştirildi");
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxKategori.Text = string.Empty;
            textBoxFiyat.Text = string.Empty;
            textBoxKdvFiyat.Text = string.Empty;
            TabloYenile();
        }

        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            FormKategoriEkle form = new FormKategoriEkle(this);
            form.Show();
            this.Hide();
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            ForumUrunEkle form = new ForumUrunEkle(this);
            form.Show();
            this.Hide();
        }

        private void dgwUrun_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = (int)dgwUrun[0, dgwUrun.CurrentCell.RowIndex].Value;
            string sorgu = $"Select * from public.\"Product\" where \"ID\" = {id}";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            textBoxID.Text = ds.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxName.Text = ds.Tables[0].Rows[0].Field<string>("Name");
            textBoxKategori.Text = ds.Tables[0].Rows[0].Field<int>("CategoryID").ToString();
            textBoxFiyat.Text = ds.Tables[0].Rows[0].Field<int>("Price").ToString();
            textBoxKdvFiyat.Text = ds.Tables[0].Rows[0].Field<object>("KdvliFiyat") != null ? ds.Tables[0].Rows[0].Field<object>("KdvliFiyat").ToString() : "0";

            baglanti.Close();
        }
    }
}
