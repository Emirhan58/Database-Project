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
    public partial class FormDepartmanEkle : Form
    {
        YoneticiPanel panel;
        public FormDepartmanEkle(YoneticiPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void FormDepartmanEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
            panel.TabloYenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"Departmans\" (\"Name\") values(@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Departman ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }
    }
}
