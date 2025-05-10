using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class SignUpClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public bool Insert(SignUpClass sp)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "Insert into LoginTBL (Name,Password,Role)values(@UserName,@UserPassword,@UserRole)";

                SqlCommand cmd = new SqlCommand(query, con);

               // cmd.Parameters.AddWithValue("@UserID", sp.ID);
                cmd.Parameters.AddWithValue("@UserName", sp.Name);
                cmd.Parameters.AddWithValue("@UserPassword", sp.Password);
                cmd.Parameters.AddWithValue("@UserRole", sp.Role);


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
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

    }
}
