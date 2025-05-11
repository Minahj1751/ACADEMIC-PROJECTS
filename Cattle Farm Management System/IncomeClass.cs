using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class IncomeClass
    {
        public int IncID { get; set; }
        public int ID { get; set; }
        public string IncPurpose { get; set; }
        public int IncAmount { get; set; }
        public string IncDate { get; set; }

        public DataTable Select()
        {

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            DataTable dt = new DataTable();



            string query = "Select * from IncomeTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        public bool Insert(IncomeClass ic)
        { 
                bool isSuccess = false;

                SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
                try
                {

                    string query = "Insert into IncomeTBL (ID,Inc_purpose,Inc_amount,Inc_date)values(@ID,@IncPurpose,@IncAmount,@IncDate)";
                 
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", ic.ID);
                    cmd.Parameters.AddWithValue("@IncPurpose", ic.IncPurpose);
                    cmd.Parameters.AddWithValue("@IncAmount", ic.IncAmount);
                    cmd.Parameters.AddWithValue("@IncDate", ic.IncDate);

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

        public bool Update(IncomeClass ic)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "UPDATE IncomeTBL SET Inc_purpose=@IncPurpose, Inc_amount=@IncAmount, Inc_date=@IncDate WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", ic.ID);
                cmd.Parameters.AddWithValue("@IncPurpose", ic.IncPurpose);
                cmd.Parameters.AddWithValue("@IncAmount", ic.IncAmount);
                cmd.Parameters.AddWithValue("@IncDate", ic.IncDate);

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

