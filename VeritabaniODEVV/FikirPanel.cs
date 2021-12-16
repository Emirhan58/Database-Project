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
    public partial class FikirPanel : Form
    {
        AnaPanel anapanel;
        public FikirPanel(AnaPanel _anapanel)
        {
            anapanel = _anapanel;
            InitializeComponent();
            textBoxUretkenID.Enabled = false;
            textBoxUretkenName.Enabled = false;
            textBoxUretkenSurname.Enabled = false;
            textBoxUretkenToplam.Enabled = false;
            textBoxID.Enabled = false;
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        public void TabloYenile()
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Ideas\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwPersonel.DataSource = ds.Tables[0];

            sorgu = "Select * from enUretkenPersonelID()";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            int enUretkenPersonelID = ds2.Tables[0].Rows[0].Field<int>("PersonelID");
            var toplamFikir = ds2.Tables[0].Rows[0].Field<object>("ToplamFikir");

            sorgu = $"Select * from public.\"Personel\" where \"ID\" = {enUretkenPersonelID}";

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            textBoxUretkenID.Text = ds3.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxUretkenName.Text = ds3.Tables[0].Rows[0].Field<string>("Name");
            textBoxUretkenSurname.Text = ds3.Tables[0].Rows[0].Field<string>("Surname");
            textBoxUretkenToplam.Text = toplamFikir.ToString();


            baglanti.Close();
        }

        private void FikirPanel_Load(object sender, EventArgs e)
        {
            TabloYenile();
        }

        private void FikirPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            anapanel.Show();
        }

        private void dgwPersonel_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = (int)dgwPersonel[0, dgwPersonel.CurrentCell.RowIndex].Value;
            string sorgu = $"Select * from public.\"Ideas\" where \"ID\" = {id}";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);


            textBoxID.Text = ds.Tables[0].Rows[0].Field<int>("ID").ToString();
            textBoxTitle.Text = ds.Tables[0].Rows[0].Field<string>("Title");
            richTextBoxDescription.Text = ds.Tables[0].Rows[0].Field<string>("Description");

            baglanti.Close();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update public.\"Ideas\" set \"Title\" = @p1 , \"Description\" = @p2 where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxTitle.Text);
            komut1.Parameters.AddWithValue("@p2", richTextBoxDescription.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fikir düzenleme işlemi başarılı bir şekilde gerçekleştirildi");
            TabloYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from public.\"Ideas\" where \"ID\" = @p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fikir silme işlemi başarılı bir şekilde gerçekleştirildi");
            textBoxID.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            richTextBoxDescription.Text = string.Empty;
            TabloYenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            FormFikirEkle form = new FormFikirEkle(this);
            form.Show();
            this.Hide();
        }
    }
}
