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
    public partial class Farmer_Chicken : Form
    {
        private int userId;
        public Farmer_Chicken(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        ChickenClass cc = new ChickenClass();

        public void Clear()
        {
            txbx_FID.Text = null;
            txbx_caste.Text = null;
            txbx_quantity.Text = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                cc.FID = int.Parse(txbx_FID.Text);
                cc.C_Caste = txbx_caste.Text;
                cc.C_Quantity = int.Parse(txbx_quantity.Text);
                cc.C_AddingDate = adding_date.Value.ToString();

                bool success = cc.Insert(cc);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = cc.Select();
                ChickenList_DGV.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Missing Information!");
            }


        }

        private void brn_update_Click(object sender, EventArgs e)
        {
            try
            {
                cc.GID = int.Parse(txbx_G_ID.Text);
                cc.FID = int.Parse(txbx_FID.Text);
                cc.C_Caste = txbx_caste.Text;
                cc.C_Quantity = int.Parse(txbx_quantity.Text);
                cc.C_AddingDate = adding_date.Value.ToString();

                bool success = cc.Update(cc);

                if (success)
                {
                    MessageBox.Show("Successfully data updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data update failed!");
                }

                DataTable dt = cc.Select();
                ChickenList_DGV.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Missing or invalid information for update!");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            cc.GID = int.Parse(txbx_G_ID.Text);

            bool success = cc.Delete(cc);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");
                Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = cc.Select();
            ChickenList_DGV.DataSource = dt;

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = cc.Select();
            ChickenList_DGV.DataSource = dt;

        }

        private void ChickenList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            txbx_G_ID.Text = ChickenList_DGV.Rows[row_index].Cells[0].Value.ToString();
            txbx_FID.Text = ChickenList_DGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_caste.Text = ChickenList_DGV.Rows[row_index].Cells[2].Value.ToString();
            txbx_quantity.Text = ChickenList_DGV.Rows[row_index].Cells[3].Value.ToString();
            adding_date.Text = ChickenList_DGV.Rows[row_index].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Farmer_Chicken_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = GetFarmerData(userId);

                if (dt.Rows.Count > 0)
                {
                    txbx_FID.Text = dt.Rows[0]["F_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private DataTable GetFarmerData(int userId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from FarmerTBL where ID = @UserId";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.Parameters.AddWithValue("@UserId", userId);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
    }
}

