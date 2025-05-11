using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class ExpandClass
    {
        public int ExpendID { get; set; }
        public int ID { get; set; }
        public string ExpendPurpose { get; set; }
        public float ExpendAmount { get; set; }
        public string ExpendDate { get; set; }


        public DataTable Select()
        {

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            DataTable dt = new DataTable();

            string query = "Select * from ExpendTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        public bool Insert(ExpandClass ex)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
            try
            {

                string query = "Insert into ExpendTBL (ID,Expend_purpose,Expend_amount,Expend_date)values(@ID,@ExpendPurpose,@ExpendAmount,@ExpendDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", ex.ID);
                cmd.Parameters.AddWithValue("@ExpendPurpose", ex.ExpendPurpose);
                cmd.Parameters.AddWithValue("@ExpendAmount", ex.ExpendAmount);
                cmd.Parameters.AddWithValue("@ExpendDate", ex.ExpendDate);

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
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        public bool Update(ExpandClass ex)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "UPDATE ExpendTBL SET Expend_purpose=@ExpendPurpose, Expend_amount=@ExpendAmount, Expend_date=@ExpendDate WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", ex.ID);
                cmd.Parameters.AddWithValue("@ExpendPurpose", ex.ExpendPurpose);
                cmd.Parameters.AddWithValue("@ExpendAmount", ex.ExpendAmount);
                cmd.Parameters.AddWithValue("@ExpendDate", ex.ExpendDate);

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
            catch (Exception)
            {
                // Handle exception
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }



    }
}
