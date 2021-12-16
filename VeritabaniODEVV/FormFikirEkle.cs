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
    public partial class FormFikirEkle : Form
    {
        FikirPanel panel;
        public FormFikirEkle(FikirPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void FormFikirEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Personel\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxPersonel.DisplayMember = "Name";
            comboBoxPersonel.ValueMember = "ID";
            comboBoxPersonel.DataSource = dt;
            baglanti.Close();
        }

        private void FormFikirEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
            panel.TabloYenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"Ideas\" (\"PersonelID\",\"Title\",\"Description\") values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", comboBoxPersonel.SelectedValue);
            komut1.Parameters.AddWithValue("@p2", textBoxTitle.Text);
            komut1.Parameters.AddWithValue("@p3", richTextBoxDescription.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fikir ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }
    }
}
