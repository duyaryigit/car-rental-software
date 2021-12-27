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
    public partial class addForm : Form
    {
        rentCar car_rent = new rentCar();
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into customer(tc,namesurname,phone,adress,mail) values(@tc,@namesurname,@phone,@adress,@mail)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc",txtTC.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNS.Text);
            komut2.Parameters.AddWithValue("@phone", txtPhone.Text);
            komut2.Parameters.AddWithValue("@adress", txtAdress.Text);
            komut2.Parameters.AddWithValue("@mail", txtMail.Text);
            car_rent.add_remove_update(komut2,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
