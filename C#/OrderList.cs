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
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }
        OrderClass oc = new OrderClass();

        private void btn_shaw_Click(object sender, EventArgs e)
        {
             DataTable dt = oc.Select();
             OrderList_DGV.DataSource = dt;
           
        }

        private void OrderList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;

                txbx_orderid.Text = OrderList_DGV.Rows[row_index].Cells[0].Value.ToString();
                txbx_B_name.Text = OrderList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_milk.Text = OrderList_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_egg.Text = OrderList_DGV.Rows[row_index].Cells[4].Value.ToString();
               
            }
            catch (Exception)
            {

            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
              try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

                    string totalMilkQuery = "SELECT SUM(Total_milk) FROM MilkTBL";
                    string totalEggQuery = "SELECT SUM(Total_egg) FROM EggTBL";

                    SqlCommand totalMilkCmd = new SqlCommand(totalMilkQuery, con);
                    SqlCommand totalEggCmd = new SqlCommand(totalEggQuery, con);

                    con.Open();
                    int totalMilk = Convert.ToInt32(totalMilkCmd.ExecuteScalar());
                    int totalEgg = Convert.ToInt32(totalEggCmd.ExecuteScalar());
                    con.Close();

                    int requestedMilk = Convert.ToInt32(txbx_milk.Text);
                    int requestedEgg = Convert.ToInt32(txbx_egg.Text);

                    if (totalMilk >= requestedMilk && totalEgg >= requestedEgg)
                    {
                       
                        string query = "INSERT INTO OrderConfirmTBL VALUES ('" + txbx_orderid.Text + "', '" + txbx_B_name.Text + "' , '" + txbx_milk.Text + "', '" + txbx_egg.Text + "', '" + txbx_e_price.Text + "' , '" + txbx_m_price.Text + "' , '" + txbx_S_ID.Text + "' , '" + confirmDate.Text + "')";

                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();

                        if (con.State == ConnectionState.Open)
                        {
                            int rows = cmd.ExecuteNonQuery();

                            if (rows >= 0)
                            {
                               
                                string updateMilkQuery = "UPDATE MilkTBL SET Total_milk = Total_milk - " + requestedMilk;
                                string updateEggQuery = "UPDATE EggTBL SET Total_egg = Total_egg - " + requestedEgg;

                                SqlCommand updateMilkCmd = new SqlCommand(updateMilkQuery, con);
                                SqlCommand updateEggCmd = new SqlCommand(updateEggQuery, con);

                                updateMilkCmd.ExecuteNonQuery();
                                updateEggCmd.ExecuteNonQuery();

                                MessageBox.Show("Insertion is successful. Quantities updated.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient quantity of milk or egg. Order cannot be fulfilled.");
                    }
                }
                catch (Exception)
                {
                 
                }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

                string query = "delete from OrderTBL where Order_ID ='" + txbx_orderid.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Delete is successfull");
                    else
                        MessageBox.Show("Delete is not successfull");
                }
            }
            catch(Exception)
            {

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txbx_orderid.Text = null;
            txbx_B_name.Text = null;
            txbx_egg.Text = null;
            txbx_milk.Text = null;
            txbx_e_price.Text = null;
            txbx_m_price.Text = null;
            txbx_order_confirm_id.Text = null;
            txbx_S_ID.Text = null;
            confirmDate.Text = null;
        }

        private void qShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            

                string eggQuery = "SELECT SUM(Total_egg) FROM EggTBL";
                SqlCommand eggCmd = new SqlCommand(eggQuery, con);
                con.Open();
                int totalEggs = Convert.ToInt32(eggCmd.ExecuteScalar());
                con.Close();


                string milkQuery = "SELECT SUM(Total_milk) FROM MilkTBL";
                SqlCommand milkCmd = new SqlCommand(milkQuery, con);
                con.Open();
                int totalMilk = Convert.ToInt32(milkCmd.ExecuteScalar());
                con.Close();

                MessageBox.Show($"Total Eggs: {totalEggs}\nTotal Milk: {totalMilk}");
            }
            catch (Exception)
            {
              
            }
        }
    }
}

