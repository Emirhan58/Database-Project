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
    public partial class FormYoneticiEkle : Form
    {
        YoneticiPanel panel;
        public FormYoneticiEkle(YoneticiPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void FormYoneticiEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Departmans\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxDepartman.DisplayMember = "Name";
            comboBoxDepartman.ValueMember = "ID";
            comboBoxDepartman.DataSource = dt;

            sorgu = "Select * from public.\"Personel\"";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxYonetici.DisplayMember = "Name";
            comboBoxYonetici.ValueMember = "ID";
            comboBoxYonetici.DataSource = dt2;
            baglanti.Close();
        }

        private void FormYoneticiEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
            panel.TabloYenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            int yoneticiID = (int)comboBoxYonetici.SelectedValue;
            string sorgu = $"Select * from public.\"Personel\" where \"ID\" = {yoneticiID}";

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            string name = ds3.Tables[0].Rows[0].Field<string>("Name");
            string surnname = ds3.Tables[0].Rows[0].Field<string>("Surname");


            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"Leaders\" (\"DepartmanID\",\"ID\",\"Name\",\"Surname\") values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", comboBoxDepartman.SelectedValue);
            komut1.Parameters.AddWithValue("@p2", comboBoxYonetici.SelectedValue);
            komut1.Parameters.AddWithValue("@p3", name);
            komut1.Parameters.AddWithValue("@p4", surnname);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }
    }
}
