using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
                {
                    con.Open();


                    string FarmerCountQuery = "SELECT COUNT(*) FROM FarmerTBL";
                    using (SqlCommand command = new SqlCommand(FarmerCountQuery, con))
                    {
                        int FarmerCount = (int)command.ExecuteScalar();
                        lvlTotalFarmer.Text = $"Total: {FarmerCount}";
                    }

                    string SalesmanCountQuery = "SELECT COUNT(*) FROM SalesmanTBL";
                    using (SqlCommand command = new SqlCommand(SalesmanCountQuery, con))
                    {
                        int SalesmanCount = (int)command.ExecuteScalar();
                        lvlTotalSalesman.Text = $"Total: {SalesmanCount}";
                    }


                    string incomeCountQuery = "SELECT SUM(Inc_amount) FROM IncomeTBL";
                    using (SqlCommand command = new SqlCommand(incomeCountQuery, con))
                    {
                        object totalIncome = command.ExecuteScalar();
                        lvlTotalIncome.Text = $"Total Income: {totalIncome.ToString()}";
                    }




                    string ExpendCountQuery = "SELECT SUM(Expend_amount) FROM ExpendTBL";
                    using (SqlCommand command = new SqlCommand(ExpendCountQuery, con))
                    {
                        object totalExp = command.ExecuteScalar();
                        lvlTotalExp.Text = $"Expendeture: {totalExp.ToString()}";
                    }



                    string CowCountQuery = "SELECT COUNT(*) FROM CowTBL";
                    using (SqlCommand command = new SqlCommand(CowCountQuery, con))
                    {
                        int CowCount = (int)command.ExecuteScalar();
                        lvlTotalCow.Text = $"Total: {CowCount}";
                    }


                    string MilkCountQuery = "SELECT SUM(Total_Milk) FROM MilkTBL";
                    using (SqlCommand command = new SqlCommand(MilkCountQuery, con))
                    {
                        object totalMilk = command.ExecuteScalar();
                        lvlTotalMilk.Text = $"Liter: {totalMilk.ToString()}";
                    }


                    string EggCountQuery = "SELECT SUM(Total_Egg) FROM EggTBL";
                    using (SqlCommand command = new SqlCommand(EggCountQuery, con))
                    {
                        object totalEgg = command.ExecuteScalar();
                        lvlTotalEgg.Text = $"Pices: {totalEgg.ToString()}";
                    }

                    string ChickenCountQuery = "SELECT SUM(C_Quantity) FROM ChickenTBL";
                    using (SqlCommand command = new SqlCommand(ChickenCountQuery, con))
                    {
                        object totalChicken = command.ExecuteScalar();
                        lvlTotalChicken.Text = $"Pices: {totalChicken.ToString()}";
                    }

                    decimal income = Convert.ToDecimal(lvlTotalIncome.Text.Split(':')[1].Trim());
                    decimal expenditure = Convert.ToDecimal(lvlTotalExp.Text.Split(':')[1].Trim());
                    decimal totalBalance = income - expenditure;
                    lvlTotalBal.Text = $"Total Balance: {totalBalance.ToString()}";




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
