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

    public partial class Profile : Form
    {
        private string connectionString = "Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True";
        private int userId;
        public Profile(int userId)
        {
            InitializeComponent();
            this.userId = userId;

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            FarmerProfile();
            SalesmanProfile();
            OwnerProfile();
        }
        public void OwnerProfile()
        {
            string query = "SELECT Owner_ID, Owner_Name,Owner_dob,Owner_email FROM OwnerTBL WHERE ID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))

            {
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    labelID.Text = row["Owner_ID"].ToString();
                    labelName.Text = row["Owner_Name"].ToString();
                    lvlDOB.Text = row["Owner_DOB"].ToString();
                    labelEmail.Text = row["Owner_Email"].ToString();
                }
                else
                {
                    // MessageBox.Show("No data found for the current user.");

                }

            }
        }
        public void SalesmanProfile()
        {
            string query = "SELECT S_ID, S_Name,S_dob,S_email FROM SalesmanTBL WHERE ID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))

            {
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    labelID.Text = row["S_ID"].ToString();
                    labelName.Text = row["S_Name"].ToString();
                    lvlDOB.Text = row["S_DOB"].ToString();
                    labelEmail.Text = row["S_email"].ToString();
                }
                else
                {
                   // MessageBox.Show("No data found for the current user.");

                }

            }

        }
        public void FarmerProfile()
        {
            string query = "SELECT F_ID, F_Name,F_dob,F_email FROM FarmerTBL WHERE ID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))

            {
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    labelID.Text = row["F_ID"].ToString();
                    labelName.Text = row["F_Name"].ToString();
                    lvlDOB.Text = row["F_DOB"].ToString();
                    labelEmail.Text = row["F_email"].ToString();
                }
                else
                {
                   // MessageBox.Show("No data found for the current user.");

                }

            }
        }
    
    
    
    
    }
}