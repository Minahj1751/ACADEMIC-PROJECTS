using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class FarmerClass
    {
        public int F_ID { get; set; }
        public int  ID { get; set; }
        public string F_Name { get; set; }
        public string F_Salary { get; set; }
        public string F_join_dt { get; set; }
        public string F_dob { get; set; }
        public string  F_email { get; set; }
        public bool F_status  { get; set; }

        public DataTable Select()
        {
            
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            DataTable dt = new DataTable();
           
            string query = "Select * from FarmerTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        public bool Insert(FarmerClass f)
        { 
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
            
            try
            {
                if (!IsIDExists(f.ID))
                {
                    string query = "Insert into FarmerTBL (ID,F_Name,F_Salary,F_join_dt,F_dob,F_email,F_Status)values(@LoginID,@FarmerName,@FarmerSalary,@FarmerJoinDt,@FarmerDOB,@FarmerEmail,@FarmerStatus)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginID", f.ID);
                    cmd.Parameters.AddWithValue("@FarmerName", f.F_Name);
                    cmd.Parameters.AddWithValue("@FarmerSalary", f.F_Salary);
                    cmd.Parameters.AddWithValue("@FarmerJoinDt", f.F_join_dt);
                    cmd.Parameters.AddWithValue("@FarmerDOB", f.F_dob);
                    cmd.Parameters.AddWithValue("@FarmerEmail", f.F_email);
                    cmd.Parameters.AddWithValue("@FarmerStatus", f.F_status);

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
                else
                {
                    Console.WriteLine("ID already exists. Cannot insert duplicate ID.");
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

        private bool IsIDExists(int id)
        {
            bool exists = false;

            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM LoginTBL WHERE ID = @ID AND NOT EXISTS (SELECT 1 FROM SalesmanTBL WHERE ID = @ID) AND NOT EXISTS (SELECT 1 FROM FarmerTBL WHERE ID = @ID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    exists = count > 0;
                }
            }

            return exists;
        }
        public bool Delete(FarmerClass f)
        {
           
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
            try
            {
                string query = "Delete from FarmerTBL where F_ID = @F_ID";
                
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@F_ID", f.F_ID);

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
        public bool Update(FarmerClass f)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "UPDATE FarmerTBL SET ID = @UserID, F_Name = @FName, F_Salary = @FSalary, F_join_dt = @FJoinDt, F_dob = @FDOB, F_email = @FEmail, F_Status = @FStatus WHERE F_ID = @FID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", f.ID);
                cmd.Parameters.AddWithValue("@FName", f.F_Name);
                cmd.Parameters.AddWithValue("@FSalary", f.F_Salary);
                cmd.Parameters.AddWithValue("@FJoinDt", f.F_join_dt);
                cmd.Parameters.AddWithValue("@FDOB", f.F_dob);
                cmd.Parameters.AddWithValue("@FEmail", f.F_email);
                cmd.Parameters.AddWithValue("@FStatus", f.F_status);
                cmd.Parameters.AddWithValue("@FID", f.F_ID);

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
            catch (Exception ex)
            {
               
                Console.WriteLine("Error during update: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

    }
}

