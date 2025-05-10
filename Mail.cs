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
    public partial class Mail : Form
    {
        public int userId;
        public Mail(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }



        public int Mail_ID { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string date { get; set; }
        public string to { get; set; }

        public bool Insert()
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "insert into MailTBL(Subject , Message , Date , [To])Values(@subject , @message , @date , @to)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@subject ", subject);
                cmd.Parameters.AddWithValue("@message ", message);
                cmd.Parameters.AddWithValue("@date ", date);
                cmd.Parameters.AddWithValue("@to", to);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                subject = txbx_subject.Text;
                message = txbx_mgs.Text;
                date = MailDate.Value.ToString();
                to = txbx_sender.Text;

                bool success = Insert();

                if (success == true)
                {
                    MessageBox.Show("Successfully Mail Send!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Mail Does not Send!");
                }


            }
            catch(Exception)
            {

            }
        }
        public void Clear()
        {
            txbx_subject.Text = null;
            txbx_sender.Text = null;
            txbx_mgs.Text = null;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mail_Load(object sender, EventArgs e)
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
                                txbx_sender.Text = dt.Rows[0]["Owner_Email"].ToString();
                            }
                            break;

                        case "Farmer":
                            DataTable dt1 = GetFarmerData(userId);
                            if (dt1.Rows.Count > 0)
                            {
                                txbx_sender.Text = dt1.Rows[0]["F_email"].ToString();
                            }
                            break;

                        case "Salesman":
                            DataTable dt2 = GetSalesmanData(userId);
                            if (dt2.Rows.Count > 0)
                            {
                                txbx_sender.Text = dt2.Rows[0]["S_email"].ToString();
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



