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
    public partial class Farmer_Milk : Form
    {
        public Farmer_Milk()
        {
            InitializeComponent();
        }
        MilkClass mc = new MilkClass();
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                mc.CowID = int.Parse(txbx_Cow_ID.Text);
                mc.FarmerID = int.Parse(txbx_FID.Text);
                mc.MilkColDate = collection_date.Value.ToString();
                mc.Am_Milk = int.Parse(txbx_A_milk.Text);
                mc.Noon_Milk = int.Parse(txbx_N_milk.Text);
                mc.Pm_Milk = int.Parse(txbx_P_milk.Text);
                mc.Total_Milk = (int.Parse(txbx_A_milk.Text)) + (int.Parse(txbx_N_milk.Text)) + (int.Parse(txbx_P_milk.Text));

                bool success = mc.Insert(mc);
             
                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Your Given Data was Worng Formet!");
            }
            DataTable dt = mc.Select();
            MilkList_DGV.DataSource = dt;
        }
        public void Clear()
        {
            txbx_Cow_ID.Text= null;
            txbx_FID.Text = null;
            collection_date.Text = null;
            txbx_A_milk.Text = null;
            txbx_N_milk.Text = null;
            txbx_P_milk.Text = null;
            
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void MilkList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int row_index = e.RowIndex;

                txbx_MC_ID.Text = MilkList_DGV.Rows[row_index].Cells[0].Value.ToString();
                txbx_Cow_ID.Text = MilkList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_FID.Text = MilkList_DGV.Rows[row_index].Cells[2].Value.ToString();
                collection_date.Text = MilkList_DGV.Rows[row_index].Cells[3].Value.ToString();
                txbx_A_milk.Text = MilkList_DGV.Rows[row_index].Cells[4].Value.ToString();
                txbx_N_milk.Text = MilkList_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_P_milk.Text = MilkList_DGV.Rows[row_index].Cells[6].Value.ToString();

            }
            catch (Exception)
            {

            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            DataTable dt = mc.Select();
            MilkList_DGV.DataSource = dt;
        }

        private void txbx_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=StudentDB;Integrated Security=True");

            string query = "Select * from StudentInfo where FirstName like '%" + txbx_search.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MilkList_DGV.DataSource = dt;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                mc.Milk_C_ID = int.Parse(txbx_MC_ID.Text); // Ensure you have a hidden field in your form to store Milk_C_ID
                mc.CowID = int.Parse(txbx_Cow_ID.Text);
                mc.FarmerID = int.Parse(txbx_FID.Text);
                mc.MilkColDate = collection_date.Value.ToString();
                mc.Am_Milk = int.Parse(txbx_A_milk.Text);
                mc.Noon_Milk = int.Parse(txbx_N_milk.Text);
                mc.Pm_Milk = int.Parse(txbx_P_milk.Text);
                mc.Total_Milk = (int.Parse(txbx_A_milk.Text)) + (int.Parse(txbx_N_milk.Text)) + (int.Parse(txbx_P_milk.Text));

                bool success = mc.Update(mc);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Update failed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Data what do you want to update!");
            }
            DataTable dt = mc.Select();
            MilkList_DGV.DataSource = dt;


        }

        private void Farmer_Milk_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

                {
                    con.Open();


                    string FarmerIDQuery = "SELECT ID FROM FarmerTBL";
                    using (SqlCommand command = new SqlCommand(FarmerIDQuery, con))
                    {
                        int FarmerID = (int)command.ExecuteScalar();
                        txbx_FID.Text = FarmerID.ToString();

                    }
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
