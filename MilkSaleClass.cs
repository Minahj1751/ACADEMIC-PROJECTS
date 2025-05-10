using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class MilkSaleClass
    {
        public int Milk_S_ID { get; set; }
        public int S_ID { get; set; }
        public string Milk_S_Date { get; set; }
        public int M_Buyer_ID { get; set; }
        public string M_Buyer_Name { get; set; }
        public int Price_Per_Litter { get; set; }
        public float Milk_S_Quantity { get; set; }
        public float Milk_Total_Price { get; set; }


        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from Milk_SaleTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }


        public bool Insert(MilkSaleClass ms)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");


            try
            {
                string query = "Insert into Milk_SaleTBL (S_ID, Milk_S_Date, M_Buyer_ID, M_Buyer_Name, Price_Per_Litter, Milk_S_Quantity, Milk_Total_Price) values ( @SID, @MilkSDate, @MBuyerID, @MBuyerName, @PricePerLitter, @MilkSQuantity, @MilkTotalPrice)";

                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@SID", ms.S_ID);
                cmd.Parameters.AddWithValue("@MilkSDate", ms.Milk_S_Date);
                cmd.Parameters.AddWithValue("@MBuyerID", ms.M_Buyer_ID);
                cmd.Parameters.AddWithValue("@MBuyerName", ms.M_Buyer_Name);
                cmd.Parameters.AddWithValue("@PricePerLitter", ms.Price_Per_Litter);
                cmd.Parameters.AddWithValue("@MilkSQuantity", ms.Milk_S_Quantity);
                cmd.Parameters.AddWithValue("@MilkTotalPrice", ms.Milk_Total_Price);


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

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        public bool Remove(MilkSaleClass ms)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "Delete from Milk_SaleTBL where Milk_S_ID = @MilkSID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MilkSID", ms.Milk_S_ID); // Corrected parameter name

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
                // Handle exceptions appropriately, e.g., logging or throwing
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        // Add the following method to your MilkSaleClass
        public bool Update(MilkSaleClass ms)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            try
            {
                string query = "Update Milk_SaleTBL set S_ID = @SID, Milk_S_Date = @MilkSDate, M_Buyer_ID = @MBuyerID, M_Buyer_Name = @MBuyerName, Price_Per_Litter = @PricePerLitter, Milk_S_Quantity = @MilkSQuantity, Milk_Total_Price = @MilkTotalPrice where Milk_S_ID = @MilkSID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SID", ms.S_ID);
                cmd.Parameters.AddWithValue("@MilkSDate", ms.Milk_S_Date);
                cmd.Parameters.AddWithValue("@MBuyerID", ms.M_Buyer_ID);
                cmd.Parameters.AddWithValue("@MBuyerName", ms.M_Buyer_Name);
                cmd.Parameters.AddWithValue("@PricePerLitter", ms.Price_Per_Litter);
                cmd.Parameters.AddWithValue("@MilkSQuantity", ms.Milk_S_Quantity);
                cmd.Parameters.AddWithValue("@MilkTotalPrice", ms.Milk_Total_Price);
                cmd.Parameters.AddWithValue("@MilkSID", ms.Milk_S_ID);

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
                // Handle exceptions appropriately, e.g., logging or throwing
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }




    }
}
