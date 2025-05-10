using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Farm_Management_System
{
    class EggClass
    {
        public int Egg_C_ID { get; set; }
        public int G_ID { get; set; }
        public int F_ID { get; set; }
        public string CollectionDate { get; set; }
        public int AmEgg { get; set; }
        public int NoonEgg { get; set; }
        public int PmEgg { get; set; }
        public int TotalEgg { get; set; }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from EggTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(EggClass ec)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "Insert into EggTBL (G_ID,F_ID,Collection_date,AM_egg,Noon_egg,PM_egg,Total_egg)Values(@GID,@FID,@CollectionDate,@AmEgg,@NoonEgg,@PmEgg,@TotalEgg)";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@GId", ec.G_ID);
                cmd.Parameters.AddWithValue("@FID", ec.F_ID);
                cmd.Parameters.AddWithValue("@CollectionDate", ec.CollectionDate);
                cmd.Parameters.AddWithValue("@AmEgg", ec.AmEgg);
                cmd.Parameters.AddWithValue("@NoonEgg", ec.NoonEgg);
                cmd.Parameters.AddWithValue("@PmEgg", ec.PmEgg);
                cmd.Parameters.AddWithValue("@TotalEgg", ec.TotalEgg);

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


        public bool Update(EggClass ec)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "UPDATE EggTBL SET G_ID = @G_ID, F_ID = @F_ID, Collection_date = @CollectionDate, AM_egg = @AmEgg, Noon_egg = @NoonEgg, PM_egg = @PmEgg WHERE Egg_C_ID = @Egg_C_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Egg_C_ID", ec.Egg_C_ID);
                cmd.Parameters.AddWithValue("@G_ID", ec.G_ID);
                cmd.Parameters.AddWithValue("@F_ID", ec.F_ID);
                cmd.Parameters.AddWithValue("@CollectionDate", ec.CollectionDate);
                cmd.Parameters.AddWithValue("@AmEgg", ec.AmEgg);
                cmd.Parameters.AddWithValue("@NoonEgg", ec.NoonEgg);
                cmd.Parameters.AddWithValue("@PmEgg", ec.PmEgg);

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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }



    }


}

