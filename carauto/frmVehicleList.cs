using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carauto
{
    public partial class frmVehicleList : Form
    {
        rentCar rentacar = new rentCar();
        public frmVehicleList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            Nptxt.Text = satir.Cells["numberplate"].Value.ToString();
            Brandcombo.Text = satir.Cells["brand"].Value.ToString();
            Seriescombo.Text = satir.Cells["series"].Value.ToString();
            Yeartxt.Text = satir.Cells["year"].Value.ToString();
            Colortxt.Text = satir.Cells["color"].Value.ToString();
            Kmtxt.Text = satir.Cells["km"].Value.ToString();
            Fuelcombo.Text = satir.Cells["fuel"].Value.ToString();
            RPtxt.Text = satir.Cells["rentprice"].Value.ToString();
            pictureBox2.ImageLocation = satir.Cells["picture"].Value.ToString();
        }

        private void frmVehicleList_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            
                comboVehicles.SelectedIndex = 0;
        }

        private void YenileAraclarListesi()
        {
            string cumle = "select *from car";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = rentacar.listele(adtr2, cumle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cumle = "update car set brand=@brand, series=@series, year=@year, color=@color, km=@km, fuel=@fuel, rentprice=@rentprice, picture=@picture, date=@date where numberplate=@numberplate";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@numberplate", Nptxt.Text);
            komut2.Parameters.AddWithValue("@brand", Brandcombo.Text);
            komut2.Parameters.AddWithValue("@series", Seriescombo.Text);
            komut2.Parameters.AddWithValue("@year", Yeartxt.Text);
            komut2.Parameters.AddWithValue("@color", Colortxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@fuel", Fuelcombo.Text);
            komut2.Parameters.AddWithValue("@rentprice", int.Parse(RPtxt.Text));
            komut2.Parameters.AddWithValue("@picture", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            rentacar.add_remove_update(komut2, cumle);
            Seriescombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraclarListesi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from car where numberplate = '" + satir.Cells["numberplate"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            rentacar.add_remove_update(komut2, cumle);
            pictureBox2.ImageLocation = "";
            Seriescombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileAraclarListesi();
            
        }

        private void Seriescombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboVehicles.SelectedIndex==0)
                {
                    YenileAraclarListesi();
                }
                if (comboVehicles.SelectedIndex == 1)
                {
                    string cumle = "select *from car where durumu = 'BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacar.listele(adtr2, cumle);
                }
                if (comboVehicles.SelectedIndex == 2)
                {
                    string cumle = "select *from car where durumu = 'DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacar.listele(adtr2, cumle);
                }
            }
            catch 
            {

                ;
            }
        }

        private void Brandcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Seriescombo.Items.Clear();
                if (Brandcombo.SelectedIndex == 0)
                {
                    Seriescombo.Items.Add("Series A");
                    Seriescombo.Items.Add("Series B");
                    Seriescombo.Items.Add("CLA");
                }
                else if (Brandcombo.SelectedIndex == 1)
                {
                    Seriescombo.Items.Add("Cabrio");
                    Seriescombo.Items.Add("Touring");
                    Seriescombo.Items.Add("Gran Turismo");

                }
                else if (Brandcombo.SelectedIndex == 2)
                {
                    Seriescombo.Items.Add("Astra");
                    Seriescombo.Items.Add("Corsa");
                    Seriescombo.Items.Add("Crossland");

                }
                else if (Brandcombo.SelectedIndex == 3)
                {
                    Seriescombo.Items.Add("Polo");
                    Seriescombo.Items.Add("Golf");
                    Seriescombo.Items.Add("Caddy");

                }
            }
            catch
            {

                ;
            }
        }
    }
}
