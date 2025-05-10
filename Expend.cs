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
    public partial class Expend : Form
    {
        public int userId;
        public Expend(int UserId)
        {
            InitializeComponent();
            this.userId = UserId;

        }
        ExpandClass ex = new ExpandClass();
        private void incList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            txbx_UID.Text = ExpList_DGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_purpose.Text = ExpList_DGV.Rows[row_index].Cells[2].Value.ToString();
            txbx_amount.Text = ExpList_DGV.Rows[row_index].Cells[3].Value.ToString();
            Exp_date.Text = ExpList_DGV.Rows[row_index].Cells[4].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                ex.ID = int.Parse(txbx_UID.Text);
                ex.ExpendDate = Exp_date.Value.ToString();
                ex.ExpendPurpose = txbx_purpose.Text;
                ex.ExpendAmount = float.Parse(txbx_amount.Text);

                bool success = ex.Insert(ex);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = ex.Select();
                ExpList_DGV.DataSource = dt;
            }
            catch(Exception)
            {

            }

        }

        private void brn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ex.ID = int.Parse(txbx_UID.Text);
                ex.ExpendDate = Exp_date.Value.ToString();
                ex.ExpendPurpose = txbx_purpose.Text;
                ex.ExpendAmount = float.Parse(txbx_amount.Text);

                bool success = ex.Update(ex);

                if (success)
                {
                    MessageBox.Show("Successfully updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

                DataTable dt = ex.Select();
                ExpList_DGV.DataSource = dt;
            }
            catch (Exception)
            {
                // Handle exception
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ex.Select();
            ExpList_DGV.DataSource = dt;
        }

        public void Clear()
        {
            txbx_UID.Text = null;
            txbx_purpose.Text = null;
            txbx_amount.Text = null;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Expend_Load(object sender, EventArgs e)
        {
            try
            {
                string role = GetUserRole(userId);
                if (!string.IsNullOrEmpty(role))
                {
                    switch (role)
                    {
                        case "Owner":
                            DataTable dt = GetOwnerData(userId);
                            if (dt.Rows.Count > 0)
                            {
                                txbx_UID.Text = dt.Rows[0]["ID"].ToString();
                            }
                            break;

                        case "Farmer":
                            DataTable dt1 = GetFarmerData(userId);
                            if (dt1.Rows.Count > 0)
                            {
                                txbx_UID.Text = dt1.Rows[0]["ID"].ToString();
                            }
                            break;

                        case "Salesman":
                            DataTable dt2 = GetSalesmanData(userId);
                            if (dt2.Rows.Count > 0)
                            {
                                txbx_UID.Text = dt2.Rows[0]["ID"].ToString();
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
        private DataTable GetOwnerData(int userId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from OwnerTBL where ID = @UserId";

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
