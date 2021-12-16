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
    public partial class YoneticiPanel : Form
    {
        AnaPanel panel;
        public YoneticiPanel(AnaPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
            textBoxID.Enabled = false;
            textBoxDepartman.Enabled = false;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void YoneticiPanel_Load(object sender, EventArgs e)
        {
            TabloYenile();
        }

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Leaders\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwYonetici.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dgwYonetici_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = (int)dgwYonetici[0, dgwYonetici.CurrentCell.RowIndex].Value;
            string sorgu = $"Select * from public.\"Leaders\" where \"ID\" = {id}";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);


            textBoxID.Text = ds.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxName.Text = ds.Tables[0].Rows[0].Field<string>("Name");
            textBoxSurname.Text = ds.Tables[0].Rows[0].Field<string>("Surname");
            textBoxDepartman.Text = ds.Tables[0].Rows[0].Field<int>("DepartmanID").ToString();

            baglanti.Close();
        }

        private void YoneticiPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
        }

        private void buttonARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = $"Select * from public.\"Leaders\" where \"Name\" like '%{textBoxAra.Text}%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwYonetici.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update public.\"Leaders\" set \"Name\" = @p1 , \"Surname\" = @p2 where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxSurname.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici düzenleme işlemi başarılı bir şekilde gerçekleştirildi");
            TabloYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from public.\"Leaders\" where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici silme işlemi başarılı bir şekilde gerçekleştirildi");
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxDepartman.Text = string.Empty;
            TabloYenile();
        }

        private void buttonDepartmanEkle_Click(object sender, EventArgs e)
        {
            FormDepartmanEkle form = new FormDepartmanEkle(this);
            form.Show();
            this.Hide();
        }

        private void buttonYoneticiEkle_Click(object sender, EventArgs e)
        {
            FormYoneticiEkle form = new FormYoneticiEkle(this);
            form.Show();
            this.Hide();
        }
    }
}
