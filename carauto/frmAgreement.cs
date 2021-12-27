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
    public partial class frmAgreement : Form
    {
        public frmAgreement()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        rentCar car = new rentCar();
        private void frmAgreement_Load(object sender, EventArgs e)
        {
            NRented_Vehicles();
            Yenile();
        }

        private void NRented_Vehicles()
        {
            string sorgu2 = "select *from car where durumu='BOŞ'";
            car.NRented_Car(comboVehicles, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select *from agreement";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = car.listele(adtr2, sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from car where numberplate like '" + comboVehicles.SelectedItem + "'";
            car.GetFromCombo(comboVehicles, txtBrand, txtSeries, txtYear, txtColor, sorgu2);
        }

        private void comboRentOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from car where numberplate like '" + comboVehicles.SelectedItem + "'";
            car.Price_Calculate(comboRentOpt, txtRentPrice, sorgu2);
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TimeSpan days = DateTime.Parse(dateEnd.Text) - DateTime.Parse(dateStart.Text);
            int days2 = days.Days;
            txtDay.Text = days2.ToString();
            txtPrice.Text = (days2 * int.Parse(txtRentPrice.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dateEnd.Text = DateTime.Now.ToShortDateString();
            dateStart.Text = DateTime.Now.ToShortDateString();
            comboRentOpt.Text = "";
            txtRentPrice.Text = "";
            txtDay.Text = "";
            txtPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into agreement(tc, namesurname, phone, numberplate, brand, series, year, color, rentoption, rentprice, day, price, startdate, enddate) values(@tc, @namesurname, @phone, @numberplate, @brand, @series, @year, @color, @rentoption, @rentprice, @day, @price, @startdate, @enddate)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
            komut2.Parameters.AddWithValue("@phone", txtPhone.Text);
            komut2.Parameters.AddWithValue("@numberplate", comboVehicles.Text);
            komut2.Parameters.AddWithValue("@brand", txtBrand.Text);
            komut2.Parameters.AddWithValue("@series", txtSeries.Text);
            komut2.Parameters.AddWithValue("@year", txtYear.Text);
            komut2.Parameters.AddWithValue("@color", txtColor.Text);
            komut2.Parameters.AddWithValue("@rentoption", comboRentOpt.Text);
            komut2.Parameters.AddWithValue("@rentprice", int.Parse(txtRentPrice.Text));
            komut2.Parameters.AddWithValue("@day", int.Parse(txtDay.Text));
            komut2.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
            komut2.Parameters.AddWithValue("@startdate", dateStart.Text);
            komut2.Parameters.AddWithValue("@enddate", dateEnd.Text);
            car.add_remove_update(komut2, sorgu2);

            string sorgu3 = "update car set durumu='DOLU' where numberplate='"+comboVehicles.Text+"'";
            SqlCommand komut3 = new SqlCommand();
            car.add_remove_update(komut3, sorgu3);
            comboVehicles.Items.Clear();
            NRented_Vehicles();
            Yenile();


            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboVehicles.Text = "";
            Clear();
            MessageBox.Show("Agreement Complete!");


        }

        private void txtTCSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtTCSearch.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from customer where tc like '" + txtTCSearch.Text + "'";
            car.TC_Search(txtTCSearch, txtTc, txtNameSurname, txtPhone, sorgu2);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update agreement set tc=@tc, namesurname=@namesurname, phone=@phone, brand=@brand, series=@series, year=@year, color=@color, rentoption=@rentoption, rentprice=@rentprice, day=@day, price=@price, startdate=@startdate, enddate=@enddate where numberplate=@numberplate";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
            komut2.Parameters.AddWithValue("@phone", txtPhone.Text);
            komut2.Parameters.AddWithValue("@numberplate", comboVehicles.Text);
            komut2.Parameters.AddWithValue("@brand", txtBrand.Text);
            komut2.Parameters.AddWithValue("@series", txtSeries.Text);
            komut2.Parameters.AddWithValue("@year", txtYear.Text);
            komut2.Parameters.AddWithValue("@color", txtColor.Text);
            komut2.Parameters.AddWithValue("@rentoption", comboRentOpt.Text);
            komut2.Parameters.AddWithValue("@rentprice", int.Parse(txtRentPrice.Text));
            komut2.Parameters.AddWithValue("@day", int.Parse(txtDay.Text));
            komut2.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
            komut2.Parameters.AddWithValue("@startdate", dateStart.Text);
            komut2.Parameters.AddWithValue("@enddate", dateEnd.Text);
            car.add_remove_update(komut2, sorgu2);

            
            comboVehicles.Items.Clear();
            NRented_Vehicles();
            Yenile();


            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboVehicles.Text = "";
            Clear();
            MessageBox.Show("Agreement Updated!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtNameSurname.Text = satir.Cells[1].Value.ToString();
            txtPhone.Text = satir.Cells[2].Value.ToString();
            comboVehicles.Text = satir.Cells[3].Value.ToString();
            txtBrand.Text = satir.Cells[4].Value.ToString();
            txtSeries.Text = satir.Cells[5].Value.ToString();
            txtYear.Text = satir.Cells[6].Value.ToString();
            txtColor.Text = satir.Cells[7].Value.ToString();
            comboRentOpt.Text = satir.Cells[8].Value.ToString();
            txtRentPrice.Text = satir.Cells[9].Value.ToString();
            txtDay.Text = satir.Cells[10].Value.ToString();
            txtPrice.Text = satir.Cells[11].Value.ToString();
            dateStart.Text = satir.Cells[12].Value.ToString();
            dateEnd.Text = satir.Cells[13].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime enddate = DateTime.Parse(satir.Cells["enddate"].Value.ToString());
            int rentprice = int.Parse(satir.Cells["rentprice"].Value.ToString());
            TimeSpan daydiff = today - enddate;
            int _daydiff = daydiff.Days;
            int pricediff;
            pricediff = _daydiff * rentprice;
            txtPriceStatus.Text = pricediff.ToString();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtPriceStatus.Text) >= 0 || int.Parse(txtPriceStatus.Text) < 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
                int rentprice = int.Parse(satir.Cells["rentprice"].Value.ToString());
                int price = int.Parse(satir.Cells["price"].Value.ToString());
                DateTime startdate = DateTime.Parse(satir.Cells["startdate"].Value.ToString());
                TimeSpan day = today - startdate;
                int _day = day.Days;
                int lastprice = _day * rentprice;

                string sorgu1 = "delete from agreement where numberplate='" + satir.Cells["numberplate"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                car.add_remove_update(komut,sorgu1);

                string sorgu2 = "update car set durumu='BOŞ' where numberplate='"+satir.Cells["numberplate"].Value.ToString()+"'";
                SqlCommand komut3 = new SqlCommand();
                car.add_remove_update(komut3, sorgu2);


                string sorgu3 = "insert into sales(tc, namesurname, numberplate, brand, series, year, color, day, price, finalprice, date1, date2) values(@tc, @namesurname, @numberplate, @brand, @series, @year, @color, @day, @price, @finalprice, @date1, @date2)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@namesurname", satir.Cells["namesurname"].Value.ToString());
                komut2.Parameters.AddWithValue("@numberplate", satir.Cells["numberplate"].Value.ToString());
                komut2.Parameters.AddWithValue("@brand", satir.Cells["brand"].Value.ToString());
                komut2.Parameters.AddWithValue("@series", satir.Cells["series"].Value.ToString()); ;
                komut2.Parameters.AddWithValue("@year", satir.Cells["year"].Value.ToString());
                komut2.Parameters.AddWithValue("@color", satir.Cells["color"].Value.ToString());
                komut2.Parameters.AddWithValue("@day", _day);
                komut2.Parameters.AddWithValue("@price", rentprice);
                komut2.Parameters.AddWithValue("@finalprice", lastprice);
                komut2.Parameters.AddWithValue("@date1", satir.Cells["startdate"].Value.ToString());
                komut2.Parameters.AddWithValue("@date2", DateTime.Now.ToShortDateString());
                car.add_remove_update(komut2, sorgu3);

                MessageBox.Show("Delivery Complete!");
                comboVehicles.Text = "";
                comboVehicles.Items.Clear();
                NRented_Vehicles();
                Yenile();


                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboVehicles.Text = "";
                Clear();

                txtPriceStatus.Text = "";
            }
            else
            {
                MessageBox.Show("Please, choose", "Warning!");
            }
        }

        private void txtPriceStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
