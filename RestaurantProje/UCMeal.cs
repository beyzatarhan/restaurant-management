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
    public partial class UCMeal : UserControl
    {
        public UCMeal()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbrestaurant; user ID=postgres; password=186029");

        private void BtnList_Click(object sender, EventArgs e)
        {
        string sorgu = "select * from meal";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into meal (id,meal_name,price) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", TxtName.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(TxtPrice.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Adding meal was successful.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from meal where id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The meal deletion was successful.");
        }
    }





}
