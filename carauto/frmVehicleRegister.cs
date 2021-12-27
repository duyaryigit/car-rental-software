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
    public partial class frmVehicleRegister : Form
    {
        rentCar rentacar = new rentCar();
        public frmVehicleRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVehicleRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into car(numberplate, brand, series, year, color, km, fuel, rentprice, picture, date, durumu) values(@numberplate, @brand, @series, @year, @color, @km, @fuel, @rentprice, @picture, @date, @durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@numberplate", Nptxt.Text);
            komut2.Parameters.AddWithValue("@brand", Brandcombo.Text);
            komut2.Parameters.AddWithValue("@series", Seriescombo.Text);
            komut2.Parameters.AddWithValue("@year", Yeartxt.Text);
            komut2.Parameters.AddWithValue("@color", Colortxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@fuel", Fuelcombo.Text);
            komut2.Parameters.AddWithValue("@rentprice", int.Parse(RPtxt.Text));
            komut2.Parameters.AddWithValue("@picture", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            rentacar.add_remove_update(komut2, cumle);
            Seriescombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
