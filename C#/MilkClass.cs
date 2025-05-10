using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class MilkClass
    {
        public int Milk_C_ID { get; set; }
        public int CowID { get; set; }
        public int FarmerID { get; set; }
        public string MilkColDate { get; set; }
        public int Am_Milk { get; set; }
        public int Noon_Milk { get; set; }
        public int Pm_Milk { get; set; }
        public int Total_Milk { get; set; }

    public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from MilkTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

    public bool Insert(MilkClass mc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "Insert into MilkTBL (Cow_ID,F_ID,M_Collection_date,AM_milk,Noon_milk,PM_milk,Total_milk)Values(@Cowid,@FID,@M_CollectionDate,@AMmilk,@Noonmilk,@PMmilk,@Totalmilk)";
                
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Cowid", mc.CowID);
                cmd.Parameters.AddWithValue("@FID", mc.FarmerID);
                cmd.Parameters.AddWithValue("@M_CollectionDate", mc.MilkColDate);
                cmd.Parameters.AddWithValue("@AMmilk", mc.Am_Milk);
                cmd.Parameters.AddWithValue("@Noonmilk", mc.Noon_Milk);
                cmd.Parameters.AddWithValue("@PMmilk", mc.Pm_Milk);
                cmd.Parameters.AddWithValue("@Totalmilk", mc.Total_Milk);

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
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        public bool Update(MilkClass mc)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "Update MilkTBL set Cow_ID=@Cowid,F_ID=@FID,M_Collection_date=@M_CollectionDate,AM_milk=@AMmilk,Noon_milk=@Noonmilk,PM_milk=@PMmilk,Total_milk=@Totalmilk where MC_ID =@MilkCID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Cowid", mc.CowID);
                cmd.Parameters.AddWithValue("@FID", mc.FarmerID);
                cmd.Parameters.AddWithValue("@M_CollectionDate", mc.MilkColDate);
                cmd.Parameters.AddWithValue("@AMmilk", mc.Am_Milk);
                cmd.Parameters.AddWithValue("@Noonmilk", mc.Noon_Milk);
                cmd.Parameters.AddWithValue("@PMmilk", mc.Pm_Milk);
                cmd.Parameters.AddWithValue("@Totalmilk", mc.Total_Milk);
                cmd.Parameters.AddWithValue("@MilkCID", mc.Milk_C_ID); // Add this line to include Milk_C_ID in the update condition

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