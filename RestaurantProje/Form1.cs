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

namespace RestaurantProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);

        }
        private void btn_meals_Click(object sender, EventArgs e)
        {
            UCMeal uCMeal = new UCMeal();
            addUC(uCMeal);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            UCSales uCSales = new UCSales();
            addUC(uCSales);
        }

        private void btncreateorder_Click(object sender, EventArgs e)
        {
            UCOrder uCOrder = new UCOrder();
            addUC(uCOrder);
        }

        private void btn_waiters_Click(object sender, EventArgs e)
        {
            UCWaiter uCWaiter = new UCWaiter();
            addUC(uCWaiter);
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            UCSupplier uCSupplier = new UCSupplier();
            addUC(uCSupplier);
        }
    }
}
