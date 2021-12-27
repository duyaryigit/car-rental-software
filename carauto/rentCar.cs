using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carauto
{
    class rentCar
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0ISDN3S;Initial Catalog=rentCar;Integrated Security=True");
        DataTable tablo;
        public void add_remove_update(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();

            return tablo;
        }
        public void NRented_Car(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["numberplate"].ToString());
            }
            baglanti.Close();
        }
        public void TC_Search(TextBox tcsearch, TextBox tc, TextBox namesurname, TextBox phone, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                namesurname.Text = read["namesurname"].ToString();
                phone.Text = read["phone"].ToString();
            }
            baglanti.Close();
        }
        public void Price_Calculate(ComboBox comborentopt, TextBox price, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comborentopt.SelectedIndex == 0) price.Text = (int.Parse(read["rentprice"].ToString()) * 1).ToString();
                if (comborentopt.SelectedIndex == 1) price.Text = (int.Parse(read["rentprice"].ToString()) * 0.80).ToString();
                if (comborentopt.SelectedIndex == 2) price.Text = (int.Parse(read["rentprice"].ToString()) * 0.70).ToString();
            }
            baglanti.Close();
        }
        public void GetFromCombo(ComboBox vehicles, TextBox brand, TextBox series, TextBox year, TextBox color, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                brand.Text = read["brand"].ToString();
                series.Text = read["series"].ToString();
                year.Text = read["year"].ToString();
                color.Text = read["color"].ToString();
            }
            baglanti.Close();
        }

        public void salescalculate(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(finalprice) from sales", baglanti);
            lbl.Text = "Final Price= " + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }
    }
}
