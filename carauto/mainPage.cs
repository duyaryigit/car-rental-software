using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carauto
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm add = new addForm();
            add.ShowDialog();
        }

        private void List_Click(object sender, EventArgs e)
        {
            frmCustomerList listele = new frmCustomerList();
            listele.ShowDialog();
        }

        private void CarReg_Click(object sender, EventArgs e)
        {
            frmVehicleRegister kayit = new frmVehicleRegister();
            kayit.ShowDialog();
        }

        private void CarList_Click(object sender, EventArgs e)
        {
            frmVehicleList listele = new frmVehicleList();
            listele.ShowDialog();
        }

        private void Agreement_Click(object sender, EventArgs e)
        {
            frmAgreement agreement = new frmAgreement();
            agreement.ShowDialog();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.ShowDialog();
        }
    }
}
