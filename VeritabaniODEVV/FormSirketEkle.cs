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
    public partial class FormSirketEkle : Form
    {
        SirketPanel panel;
        public FormSirketEkle(SirketPanel _panel)
        {
            panel = _panel;
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = MyDatabase; user ID=postgres; password=123");

        private void FormSirketEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Show();
            panel.TabloYenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            Random random = new Random();
            int Countryid = random.Next();
            int Countyid = random.Next();
            int Provinceid = random.Next();
            int Placeid = random.Next();
            int YearOfFoundationid = random.Next();

            NpgsqlCommand komut1 = new NpgsqlCommand($"insert into public.\"yearOfFoundation\" (\"Day\",\"Month\",\"Year\",\"ID\") values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBoxGun.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(textBoxAy.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBoxYil.Text));
            komut1.Parameters.AddWithValue("@p4", YearOfFoundationid);
            komut1.ExecuteNonQuery();


            NpgsqlCommand komut2 = new NpgsqlCommand($"insert into public.\"Country\" (\"Name\",\"ID\") values(@p1,@p2)", baglanti);
            komut2.Parameters.AddWithValue("@p1", textBoxUlke.Text);
            komut2.Parameters.AddWithValue("@p2", Countryid);
            komut2.ExecuteNonQuery();

            NpgsqlCommand komut3 = new NpgsqlCommand($"insert into public.\"Province\" (\"Name\",\"ID\") values(@p1,@p2)", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBoxIl.Text);
            komut3.Parameters.AddWithValue("@p2", Provinceid);
            komut3.ExecuteNonQuery();

            NpgsqlCommand komut4 = new NpgsqlCommand($"insert into public.\"County\" (\"Name\",\"ID\") values(@p1,@p2)", baglanti);
            komut4.Parameters.AddWithValue("@p1", textBoxIlce.Text);
            komut4.Parameters.AddWithValue("@p2", Countyid);
            komut4.ExecuteNonQuery();

            NpgsqlCommand komut5 = new NpgsqlCommand($"insert into public.\"Place\" (\"ID\",\"CountryID\",\"ProvinceID\",\"CountyID\") values(@p1,@p2,@p3,@p4)", baglanti);
            komut5.Parameters.AddWithValue("@p1", Placeid);
            komut5.Parameters.AddWithValue("@p2", Countryid);
            komut5.Parameters.AddWithValue("@p3", Provinceid);
            komut5.Parameters.AddWithValue("@p4", Countyid);
            komut5.ExecuteNonQuery();

            NpgsqlCommand komut6 = new NpgsqlCommand($"insert into public.\"Company\" (\"Name\",\"PlaceID\",\"yearOfFoundationID\") values(@p1,@p2,@p3)", baglanti);
            komut6.Parameters.AddWithValue("@p1", textBoxName.Text);
            komut6.Parameters.AddWithValue("@p2", Placeid);
            komut6.Parameters.AddWithValue("@p3", YearOfFoundationid);
            komut6.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Şirket Ekleme İşlemi Başarıyla Gerçekleşmiştir.");
        }
    }
}
