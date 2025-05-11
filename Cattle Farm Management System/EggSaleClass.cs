using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    class EggSaleClass
    {
        public int Egg_S_ID { get; set; }
        public int S_ID { get; set; }
        public string Egg_S_Date { get; set; }
        public int Egg_Buyer_ID { get; set; }
        public string E_Buyer_Name { get; set; }
        public int Price_Per_Pis { get; set; }
        public float Egg_S_Quantity { get; set; }
        public int Egg_Total_Price { get; set; }


        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            DataTable dt = new DataTable();

            string query = "Select * from EggSale_TBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(EggSaleClass es)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);


            try
            {
                string query = "Insert into EggSale_TBL (S_ID, Egg_S_Date, Egg_Buyer_ID, E_Buyer_Name, Price_Per_Pis, Egg_S_Quantity, Egg_Total_Price ) values (@SID, @EggSDate, @EggBuyerID, @EBuyerName, @PricePerPis, @EggSQuantity, @EggTotalPrice)";

                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@SID", es.S_ID);
                cmd.Parameters.AddWithValue("@EggSDate", es.Egg_S_Date);
                cmd.Parameters.AddWithValue("@EggBuyerID", es.Egg_Buyer_ID);
                cmd.Parameters.AddWithValue("@EBuyerName", es.E_Buyer_Name);
                cmd.Parameters.AddWithValue("@PricePerPis", es.Price_Per_Pis);
                cmd.Parameters.AddWithValue("@EggSQuantity", es.Egg_S_Quantity);
                cmd.Parameters.AddWithValue("@EggTotalPrice", es.Egg_Total_Price);

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

        public bool Update(EggSaleClass es)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "UPDATE EggSale_TBL SET S_ID=@SID, Egg_S_Date=@EggSDate, Egg_Buyer_ID=@EggBuyerID, E_Buyer_Name=@EBuyerName, Price_Per_Pis=@PricePerPis, Egg_S_Quantity=@EggSQuantity, Egg_Total_Price=@EggTotalPrice WHERE Egg_S_ID=@EggSID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SID", es.S_ID);
                cmd.Parameters.AddWithValue("@EggSDate", es.Egg_S_Date);
                cmd.Parameters.AddWithValue("@EggBuyerID", es.Egg_Buyer_ID);
                cmd.Parameters.AddWithValue("@EBuyerName", es.E_Buyer_Name);
                cmd.Parameters.AddWithValue("@PricePerPis", es.Price_Per_Pis);
                cmd.Parameters.AddWithValue("@EggSQuantity", es.Egg_S_Quantity);
                cmd.Parameters.AddWithValue("@EggTotalPrice", es.Egg_Total_Price);
                cmd.Parameters.AddWithValue("@EggSID", es.Egg_S_ID);

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




        public bool Remove(EggSaleClass es)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString);

            try
            {
                string query = "Delete from EggSale_TBL where Egg_S_ID = @EggSID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EggSID",es.Egg_S_ID);

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


    }
}
