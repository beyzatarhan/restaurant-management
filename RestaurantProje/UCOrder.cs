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
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbrestaurant; user ID=postgres; password=186029");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu1 = "select * from totalprice";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from myOrder";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btn_neworder_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into orders (id,meal_id,customer_id) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtOrder.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(TxtMeal.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(TxtCustomer.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Adding order was successful.");
        }
        private void btn_neworder_Click_1(object sender, EventArgs e)
        {
            string sorgu2 = "select meal.id,meal_name,price from meal";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView3.DataSource = ds2.Tables[0];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
