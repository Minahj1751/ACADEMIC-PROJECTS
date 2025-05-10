using System;
using System.Data;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    class CowClass
    {
        public int CowID { get; set; }
        public int FID { get; set; }
        public string CowName { get; set; }
        public string CowBreed { get; set; }
        public string CowColor { get; set; }
        public string CowAddingDate { get; set; }
        public float CowAge { get; set; }



        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from CowTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(CowClass cw)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "Insert into CowTBL (F_ID,cow_name,cow_breed,cow_color,cow_adding_date,cow_age)Values(@FID,@CowName,@CowBreed,@CowColor,@AddingDate,@CowAge)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FID", cw.FID);
                cmd.Parameters.AddWithValue("@CowName", cw.CowName);
                cmd.Parameters.AddWithValue("@CowBreed", cw.CowBreed);
                cmd.Parameters.AddWithValue("@CowColor", cw.CowColor);
                cmd.Parameters.AddWithValue("@AddingDate", cw.CowAddingDate);
                cmd.Parameters.AddWithValue("@CowAge", cw.CowAge);

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

        public bool Delete(CowClass c)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "Delete from CowTBL where Cow_ID = @Cowid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Cowid", CowID);

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

        public bool Update(CowClass cw)
        {
            bool isSuccess = false;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True"))
            {
                try
                {
                    string query = "UPDATE CowTBL SET F_ID=@FID, cow_name=@CowName, cow_breed=@CowBreed, cow_color=@CowColor, cow_adding_date=@AddingDate, cow_age=@CowAge WHERE Cow_ID=@CowID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CowID", cw.CowID);
                        cmd.Parameters.AddWithValue("@FID", cw.FID);
                        cmd.Parameters.AddWithValue("@CowName", cw.CowName);
                        cmd.Parameters.AddWithValue("@CowBreed", cw.CowBreed);
                        cmd.Parameters.AddWithValue("@CowColor", cw.CowColor);
                        cmd.Parameters.AddWithValue("@AddingDate", cw.CowAddingDate);
                        cmd.Parameters.AddWithValue("@CowAge", cw.CowAge);

                        con.Open();

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
            }

            return isSuccess;
        }



    }
}
