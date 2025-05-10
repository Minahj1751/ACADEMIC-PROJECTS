using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class ChickenClass
    {
        public int GID { get; set; }
        public int FID { get; set; }
        public string C_Caste { get; set; }
        public int C_Quantity { get; set; }
        public string C_AddingDate { get; set; }
        



        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from ChickenTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(ChickenClass cc)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "Insert into ChickenTBL (F_ID,C_Caste,C_Quantity,C_Adding_Date)Values(@FID,@C_Caste,@C_Quantity,@C_Adding_Date)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FID", cc.FID);
                cmd.Parameters.AddWithValue("@C_Caste", cc.C_Caste);
                cmd.Parameters.AddWithValue("@C_Quantity", cc.C_Quantity);
                cmd.Parameters.AddWithValue("@C_Adding_Date",cc.C_AddingDate);

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

        public bool Delete(ChickenClass cc)
        {
            bool isSuccess = false;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM ChickenTBL WHERE G_ID = @GID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@GID", cc.GID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                        Console.WriteLine("Delete successful. Rows affected: " + rows);
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected by the DELETE operation.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during delete: " + ex.Message);
                   
                }
            }

            return isSuccess;
        }



        public bool Update(ChickenClass cc)
        {
            bool isSuccess = false;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    string query = "UPDATE ChickenTBL SET F_ID = @FID, C_Caste = @C_Caste, C_Quantity = @C_Quantity, C_Adding_Date = @C_Adding_Date WHERE G_ID = @GID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FID", cc.FID);
                    cmd.Parameters.AddWithValue("@C_Caste", cc.C_Caste);
                    cmd.Parameters.AddWithValue("@C_Quantity", cc.C_Quantity);
                    cmd.Parameters.AddWithValue("@C_Adding_Date", cc.C_AddingDate);
                    cmd.Parameters.AddWithValue("@GID", cc.GID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                        Console.WriteLine("Update successful. Rows affected: " + rows);
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected by the UPDATE operation.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during update: " + ex.Message);
                }
            }

            return isSuccess;
        }



    }
}
