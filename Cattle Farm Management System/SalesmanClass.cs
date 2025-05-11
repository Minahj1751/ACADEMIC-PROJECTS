using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Management_System
{
    class SalesmanClass
    {
        public int S_ID { get; set; }
        public int ID { get; set; }
        public string S_Name { get; set; }
        public string S_Salary { get; set; }
        public string S_join_dt { get; set; }
        public string S_dob { get; set; }
        public string S_email { get; set; }
        public bool S_status { get; set; }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
           
            DataTable dt = new DataTable();

            string query = "Select * from SalesmanTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        public bool Delete(SalesmanClass s)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
            try
            {
                string query = "Delete from SalesmanTBL where S_ID = @S_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@S_ID", S_ID);

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
            catch (Exception c)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        public bool Update(SalesmanClass s)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);
            try
            {
                string query = "Update SalesmanTBL set ID=@LoginID, S_Name=@SalesName, S_Salary=@SalesmanSalary, S_join_dt=@SalesmanJoinDt, S_dob=@SalesmanDOB, S_email=@SalesmanEmail, S_status=@SalesmanStatus where S_ID=@S_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@LoginID", s.ID);
                cmd.Parameters.AddWithValue("@SalesName", s.S_Name);
                cmd.Parameters.AddWithValue("@SalesmanSalary", s.S_Salary);
                cmd.Parameters.AddWithValue("@SalesmanJoinDt", s.S_join_dt);
                cmd.Parameters.AddWithValue("@SalesmanDOB", s.S_dob);
                cmd.Parameters.AddWithValue("@SalesmanEmail", s.S_email);
                cmd.Parameters.AddWithValue("@SalesmanStatus", s.S_status);
                cmd.Parameters.AddWithValue("@S_ID", s.S_ID);

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

        public bool Insert(SalesmanClass s)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                if (IsIDUnique(s.ID, "SalesmanTBL") && IsIDUnique(s.ID, "FarmerTBL"))
                {
                   
                    if (IsIDExistInLoginTBL(s.ID))
                    {
                        string query = "INSERT INTO SalesmanTBL (ID, S_Name, S_Salary, S_join_dt, S_dob, S_email, S_status) VALUES (@LoginID, @SalesName, @SalesmanSalary, @SalesmanJoinDt, @SalesmanDOB, @SalesmanEmail, @SalesmanStatus)";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@LoginID", s.ID);
                        cmd.Parameters.AddWithValue("@SalesName", s.S_Name);
                        cmd.Parameters.AddWithValue("@SalesmanSalary", s.S_Salary);
                        cmd.Parameters.AddWithValue("@SalesmanJoinDt", s.S_join_dt);
                        cmd.Parameters.AddWithValue("@SalesmanDOB", s.S_dob);
                        cmd.Parameters.AddWithValue("@SalesmanEmail", s.S_email);
                        cmd.Parameters.AddWithValue("@SalesmanStatus", s.S_status);

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
                        Console.WriteLine("ID does not exist in LoginTBL");
                    }
                }
                else
                {
                    Console.WriteLine("ID already exists in SalesmanTBL or FarmerTBL");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during insert: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;

        }

        private bool IsIDUnique(int id, string SalesmanTBL)
        {
            bool isUnique = true;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = $"SELECT COUNT(*) FROM SalesmanTBL and FarmerTBL WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        isUnique = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking uniqueness in Salesman: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isUnique;
        }

        private bool IsIDExistInLoginTBL(int id)
        {
            bool exists = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "SELECT COUNT(*) FROM LoginTBL WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        exists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking ID existence in LoginTBL: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return exists;
        }





    }
}




