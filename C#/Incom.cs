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
    public partial class Incom : Form
    {
        private int userId;
        public Incom(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        IncomeClass ic = new IncomeClass();

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                ic.ID = int.Parse(txbx_ID.Text);
                ic.IncDate = inc_date.Value.ToString();
                ic.IncPurpose = txbx_purpose.Text;
                ic.IncAmount = int.Parse(txbx_amount.Text);


                bool success = ic.Insert(ic);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }


                DataTable dt = ic.Select();
                incList_DGV.DataSource = dt;
            }
            catch(Exception)
            {

            }
        }

        private void brn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ic.ID = int.Parse(txbx_ID.Text);
                ic.IncDate = inc_date.Value.ToString();
                ic.IncPurpose = txbx_purpose.Text;
                ic.IncAmount = int.Parse(txbx_amount.Text);

                bool success = ic.Update(ic);

                if (success)
                {
                    MessageBox.Show("Successfully updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

                DataTable dt = ic.Select();
                incList_DGV.DataSource = dt;
            }
            catch (Exception)
            {
                // Handle exception
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ic.Select();
            incList_DGV.DataSource = dt;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txbx_ID.Text = null;
            txbx_purpose.Text = null;
            txbx_amount.Text = null;       
        }
        private void incList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;

                txbx_ID.Text = incList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_purpose.Text = incList_DGV.Rows[row_index].Cells[2].Value.ToString();
                txbx_amount.Text = incList_DGV.Rows[row_index].Cells[3].Value.ToString();
                inc_date.Text = incList_DGV.Rows[row_index].Cells[4].Value.ToString();
            }
            catch(Exception)
            {

            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incom_Load(object sender, EventArgs e)
        {
            try
            {
                string role = GetUserRole(userId);
                if (!string.IsNullOrEmpty(role))
                {
                    switch (role)
                    {
                        
                        case "Farmer":
                            DataTable dt1 = GetFarmerData(userId);
                            if (dt1.Rows.Count > 0)
                            {
                                txbx_ID.Text = dt1.Rows[0]["ID"].ToString();
                            }
                            break;

                        case "Salesman":
                            DataTable dt2 = GetSalesmanData(userId);
                            if (dt2.Rows.Count > 0)
                            {
                                txbx_ID.Text = dt2.Rows[0]["ID"].ToString();
                            }
                            break;

                    }
                }
                else
                {

                }
            }

            catch (Exception)
            {

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
        private DataTable GetSalesmanData(int userId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from SalesmanTBL where ID = @UserId";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.Parameters.AddWithValue("@UserId", userId);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
        private string GetUserRole(int userId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            {
                con.Open();

                string query = "SELECT Role FROM LoginTBL WHERE ID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);


                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
                con.Close();
            }


        }
    }
}
