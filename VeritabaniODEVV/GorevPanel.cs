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
    public partial class GorevPanel : Form
    {
        AnaPanel anapanel;
        public GorevPanel(AnaPanel _anapanel)
        {
            anapanel = _anapanel;
            InitializeComponent();
            textBoxYogunID.Enabled = false;
            textBoxYogunName.Enabled = false;
            textBoxYogunSurname.Enabled = false;
            textBoxYogunToplam.Enabled = false;
            textBoxID.Enabled = false;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void GorevPanel_Load(object sender, EventArgs e)
        {
            TabloYenile();
        }

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Tasks\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwGorev.DataSource = ds.Tables[0];

            sorgu = "Select * from enYogunPersonelID()";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            int enYogunPersonelID = ds2.Tables[0].Rows[0].Field<int>("PersonelID");
            var toplamGorev = ds2.Tables[0].Rows[0].Field<object>("ToplamGorev");

            sorgu = $"Select * from public.\"Personel\" where \"ID\" = {enYogunPersonelID}";

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            textBoxYogunID.Text = ds3.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxYogunName.Text = ds3.Tables[0].Rows[0].Field<string>("Name");
            textBoxYogunSurname.Text = ds3.Tables[0].Rows[0].Field<string>("Surname");
            textBoxYogunToplam.Text = toplamGorev.ToString();


            baglanti.Close();
        }

        private void GorevPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            anapanel.Show();
        }

        private void dgwGorev_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = (int)dgwGorev[0, dgwGorev.CurrentCell.RowIndex].Value;
            string sorgu = $"Select * from public.\"Tasks\" where \"ID\" = {id}";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);


            textBoxID.Text = ds.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxTitle.Text = ds.Tables[0].Rows[0].Field<string>("Title");
            richTextBoxDescription.Text = ds.Tables[0].Rows[0].Field<string>("Description");

            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            FormGorevEkle form = new FormGorevEkle(this);
            form.Show();
            this.Hide();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update public.\"Tasks\" set \"Title\" = @p1 , \"Description\" = @p2 where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxTitle.Text);
            komut1.Parameters.AddWithValue("@p2", richTextBoxDescription.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görev düzenleme işlemi başarılı bir şekilde gerçekleştirildi");
            TabloYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from public.\"Tasks\" where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görev silme işlemi başarılı bir şekilde gerçekleştirildi");
            textBoxID.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            richTextBoxDescription.Text = string.Empty;
            TabloYenile();
        }
    }
}
