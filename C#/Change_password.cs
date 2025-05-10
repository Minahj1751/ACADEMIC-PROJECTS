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
//using System.Data;

namespace Farm_Management_System
{
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();     
        }

      private bool ChangePassword(int ID, string oldPassword, string newPassword)
        {
            string connectionString = "Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE LoginTBL SET Password = '{newPassword}' WHERE ID = '{ID}' AND Password = '{oldPassword}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txbx_UI.Text);
            string oldPassword = txbx_old_Pass.Text;
            string newPassword = txbx_N_pass.Text;
            string confirmPassword = txbx_C_Pass.Text;

            if (oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            if (ChangePassword(ID, oldPassword, newPassword))
            {
                MessageBox.Show("Password changed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please check your old password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
