using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class OrderClass
    {
        public int Order_ID { get; set; }
        public string B_Name { get; set; }
        public string B_Email { get; set; }
        public string B_Phone { get; set; }
        public int Egg { get; set; }
        public int Milk { get; set; }
        public string Address { get; set;  }
        public DateTime Order_Date { get; set; }


        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            DataTable dt = new DataTable();

            string query = "Select * from OrderTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);
            return dt;
        }

        public bool Insert(OrderClass oc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "insert into OrderTBL (B_Name,B_Email,B_Phone,Egg,Milk,Address,Order_Date)Values(@name,@email,@phone,@egg,@milk,@address,@date)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", oc.B_Name);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(B_Email) ? (object)DBNull.Value : B_Email);
                cmd.Parameters.AddWithValue("@phone", oc.B_Phone);
                cmd.Parameters.AddWithValue("@egg", oc.Egg != 0 ? (object)oc.Egg : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@milk", oc.Milk != 0 ? (object)oc.Milk : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@address", oc.Address);
                cmd.Parameters.AddWithValue("@date", oc.Order_Date);

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

    }
}



