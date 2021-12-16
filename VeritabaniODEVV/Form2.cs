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
    public partial class Form2 : Form
    {
        FormPersonel form;
        public Form2(FormPersonel _form)
        {
            form = _form;
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select PersonelEkle(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxSurname.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
            form.TabloYenile();
        }
    }
}
