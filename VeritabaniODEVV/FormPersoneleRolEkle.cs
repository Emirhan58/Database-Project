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
    public partial class FormPersoneleRolEkle : Form
    {
        RolPanel panel;
        public FormPersoneleRolEkle(RolPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void FormPersoneleRolEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
        }

        private void FormPersoneleRolEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * from public.\"Roles\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxRol.DisplayMember = "Name";
            comboBoxRol.ValueMember = "ID";
            comboBoxRol.DataSource = dt;

            sorgu = "Select * from public.\"Personel\"";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxPersonel.DisplayMember = "Name";
            comboBoxPersonel.ValueMember = "ID";
            comboBoxPersonel.DataSource = dt2;
            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"PersonelRoles\" (\"PersonelID\",\"RoleID\") values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", comboBoxPersonel.SelectedValue);
            komut1.Parameters.AddWithValue("@p2", comboBoxRol.SelectedValue);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personele rol ekleme işlemi başarılı bir şekilde gerçekleştirildi");
        }
    }
}
