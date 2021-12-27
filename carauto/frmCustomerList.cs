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
    public partial class frmCustomerList : Form
    {
        rentCar car_rent = new rentCar();
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = "select *from customer";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = car_rent.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Name Surname";
            dataGridView1.Columns[2].HeaderText = "Phone";
            dataGridView1.Columns[3].HeaderText = "Adress";
            dataGridView1.Columns[4].HeaderText = "Mail";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select *from customer where tc like '%"+txtSearch.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = car_rent.listele(adtr2, cumle);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cumle = "update customer set namesurname = @namesurname, phone = @phone, adress = @adress, mail = @mail where tc = @tc";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@namesurname", txtNS.Text);
            komut2.Parameters.AddWithValue("@phone", txtPhone.Text);
            komut2.Parameters.AddWithValue("@adress", txtAdress.Text);
            komut2.Parameters.AddWithValue("@mail", txtMail.Text);
            car_rent.add_remove_update(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTC.Text = satir.Cells[0].Value.ToString();
            txtNS.Text = satir.Cells[1].Value.ToString();
            txtPhone.Text = satir.Cells[2].Value.ToString();
            txtAdress.Text = satir.Cells[3].Value.ToString();
            txtMail.Text = satir.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            string cumle = "delete from customer where tc='"+satir.Cells["tc"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            car_rent.add_remove_update(komut2, cumle);
            // foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }
    }
}
