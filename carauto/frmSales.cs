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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        rentCar carr = new rentCar();
        private void frmSales_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from sales";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = carr.listele(adtr2, sorgu2);
            carr.salescalculate(label1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
