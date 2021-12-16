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
    public partial class FormPersonel : Form
    {
        AnaPanel anapanel;
        public FormPersonel(AnaPanel _anapanel)
        {
            anapanel = _anapanel;
            InitializeComponent();
            textBoxID.Enabled = false;
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void Form1_Load(object sender, EventArgs e)
        {
            TabloYenile();
        }

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Personel\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwPersonel.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void dgwPersonel_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = (int)dgwPersonel[0, dgwPersonel.CurrentCell.RowIndex].Value;
            string sorgu = $"Select * from public.\"Personel\" where \"ID\" = {id}";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);


            textBoxID.Text = ds.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxName.Text = ds.Tables[0].Rows[0].Field<string>("Name");
            textBoxSurname.Text = ds.Tables[0].Rows[0].Field<string>("Surname");

            baglanti.Close();
        }

        private void buttonARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = $"Select * from public.\"Personel\" where \"Name\" like '%{textBoxAra.Text}%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwPersonel.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update public.\"Personel\" set \"Name\" = @p1 , \"Surname\" = @p2 where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxSurname.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel düzenleme işlemi başarılı bir şekilde gerçekleştirildi");
            TabloYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from public.\"Personel\" where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel silme işlemi başarılı bir şekilde gerçekleştirildi");
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            TabloYenile();
        }

        private void FormPersonel_FormClosing(object sender, FormClosingEventArgs e)
        {
            anapanel.Show();
        }
    }
}
