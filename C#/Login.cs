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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Clear()
        {
            txBx_UserID.Text = null;
            txBx_Password.Text = null;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void order_Click(object sender, EventArgs e)
        {
            Order odr = new Order();
            this.Hide();
            odr.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(txBx_UserID.Text);
                string password = txBx_Password.Text;

                string role = GetUserRole(userId, password);

                if (!string.IsNullOrEmpty(role))
                {
                    switch (role)
                    {
                        case "Owner":
                            Owner Or = new Owner(userId);
                            this.Hide();
                            Or.Show();

                            break;
                        case "Farmer":
                            Farmer Fr = new Farmer(userId);
                            this.Hide();
                            Fr.Show();
;

                            break;
                        case "Salesman":
                            Salesman Sr = new Salesman(userId);
                            this.Hide();
                            Sr.Show();

                            break;
                        default:
                            MessageBox.Show("Invalid role for the user.");
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("User ID can not correct formet!!");
            }

           

        }

        private string GetUserRole(int userId, string password)
        {
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            {
                con.Open();

                string query = "SELECT Role FROM LoginTBL WHERE ID = @UserID AND Password = @UserPassword";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@UserPassword", password);

                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
                con.Close();
            }
            
          
        }
        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            this.Hide();
            sn.Show();
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txBx_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txBx_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
