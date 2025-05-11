using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    public partial class Price : Form
    {
        public Price()
        {
            InitializeComponent();
        }

        public int Price_ID { get; set; }
        public int Egg { get; set; }
        public int Milk { get; set; }


        public bool Update()
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "UPDATE PriceTBL SET Egg = @egg, Milk = @milk WHERE Price_ID = @PriceID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@egg", Egg);
                cmd.Parameters.AddWithValue("@milk", Milk);
                cmd.Parameters.AddWithValue("@PriceID", Price_ID);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected by the update. Price_ID may not exist.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }




        public DataTable Select()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from PriceTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        private void price_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            txbx_egg.Text = price_DGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_milk.Text = price_DGV.Rows[row_index].Cells[2].Value.ToString();

        }

        public void Clear()
        {
            txbx_egg.Text = "";
            txbx_milk.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Egg = int.Parse(txbx_egg.Text);
                Milk = int.Parse(txbx_milk.Text);

                bool success = Update();

                if (success)
                {
                    MessageBox.Show("Successfully updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

                DataTable dt = Select();
                price_DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
