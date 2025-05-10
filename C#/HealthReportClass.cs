using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farm_Management_System
{
    class HealthReportClass
    {
        public int ReportID { get; set; }
        public string Cattle_Type { get; set; }
        public string even { get; set; }
        public string reportdate { get; set; }
        public string diagnosis { get; set; }
        public string treatment { get; set; }
        public string vatname { get; set; }
        public float costtreatment { get; set; }


        public DataTable Select()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from ReportTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }
        public bool Insert(HealthReportClass hc)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            try
            {
                string query = "Insert into ReportTBL (Cattle_Type, Even, Diagnosis, Report_Date, Treatment, Vat_Name, Cost_of_Treatment) Values(@C_Type, @even, @diagnosis, @report_date, @treatment, @vat_name, @cost)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@C_Type", hc.Cattle_Type);
                cmd.Parameters.AddWithValue("@even", hc.even);
                cmd.Parameters.AddWithValue("@diagnosis", hc.diagnosis);
                cmd.Parameters.AddWithValue("@report_date", hc.reportdate);
                cmd.Parameters.AddWithValue("@treatment", hc.treatment);
                cmd.Parameters.AddWithValue("@vat_name", hc.vatname);
                cmd.Parameters.AddWithValue("@cost", hc.costtreatment);
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
        public bool Update(HealthReportClass hc)
        {
           
                bool isSuccess = false;

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

                try
                {
                    string query = "UPDATE ReportTBL SET Cattle_Type = @C_Type, Even = @even, Diagnosis = @diagnosis, Report_Date = @report_date, Treatment = @treatment, Vat_Name = @vat_name, Cost_of_Treatment = @cost WHERE Report_ID = @ReportID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ReportID", hc.ReportID);
                    cmd.Parameters.AddWithValue("@C_Type", hc.Cattle_Type);
                    cmd.Parameters.AddWithValue("@even", hc.even);
                    cmd.Parameters.AddWithValue("@diagnosis", hc.diagnosis);
                    cmd.Parameters.AddWithValue("@report_date", hc.reportdate);
                    cmd.Parameters.AddWithValue("@treatment", hc.treatment);
                    cmd.Parameters.AddWithValue("@vat_name", hc.vatname);
                    cmd.Parameters.AddWithValue("@cost", hc.costtreatment);
                    

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
