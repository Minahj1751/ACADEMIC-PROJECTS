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
    public partial class Farmer_Cows : Form
    {
        private int userId;
        public Farmer_Cows(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        CowClass cw = new CowClass();

        private void CowList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int row_index = e.RowIndex;

                txbx_cowid.Text = CowList_DGV.Rows[row_index].Cells[0].Value.ToString();
                txbx_FID.Text = CowList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_CowName.Text = CowList_DGV.Rows[row_index].Cells[2].Value.ToString();
                txbx_breed.Text = CowList_DGV.Rows[row_index].Cells[3].Value.ToString();
                txbx_Color.Text = CowList_DGV.Rows[row_index].Cells[4].Value.ToString();
                adding_date.Text = CowList_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_age.Text = CowList_DGV.Rows[row_index].Cells[6].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        public void Clear()
        {
            txbx_cowid.Text = null;
            txbx_FID.Text = null;
            txbx_CowName.Text = null;
            txbx_breed.Text = null;
            txbx_Color.Text = null;
            adding_date.Text = null;
            txbx_age.Text = null;
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = cw.Select();
            CowList_DGV.DataSource = dt;
        }

        private void brn_update_Click(object sender, EventArgs e)
        {
            try
               {
                   cw.CowID = int.Parse(txbx_cowid.Text);
                   cw.FID = int.Parse(txbx_FID.Text);
                   cw.CowName = txbx_CowName.Text;
                   cw.CowBreed = txbx_breed.Text;
                   cw.CowColor = txbx_Color.Text;
                   cw.CowAddingDate = adding_date.Value.ToString();
                   cw.CowAge = float.Parse(txbx_age.Text);


                bool success = cw.Update(cw);

                   if (success)
                   {
                      MessageBox.Show("Successfully data Updated!");
                       Clear();
                   }
                   else
                   {
                      MessageBox.Show("Data Update failed!");
                   }
           
                DataTable dt = cw.Select();
                CowList_DGV.DataSource = dt;
               }
             catch (Exception ex)
               {
                  MessageBox.Show("Error during update: " + ex.Message);
               }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
                        {
                            cw.CowID = int.Parse(txbx_cowid.Text);

                            bool success = cw.Delete(cw);

                            if (success == true)
                            {
                                MessageBox.Show("Successfully data deleted!");

                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Data Deletion failed!");
                            }

                            DataTable dt = cw.Select();
                            CowList_DGV.DataSource = dt;
                        }
                        catch (Exception c)
                        {
                            MessageBox.Show("Dekation not Exicuterd");
                        }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            try
                {

                  cw.FID =int.Parse( txbx_FID.Text);
                  cw.CowName = txbx_CowName.Text;
                  cw.CowBreed = txbx_breed.Text;
                  cw.CowColor = txbx_Color.Text;
                  cw.CowAddingDate = adding_date.Value.ToString();
                  cw.CowAge = float.Parse(txbx_age.Text);

                  bool success = cw.Insert(cw);

                   if (success == true)
                      {
                         MessageBox.Show("Successfully data Inserted!");
                         Clear();
                      }
                   else
                      {
                           MessageBox.Show("Data Insertion failed!");
                      }

                           DataTable dt = cw.Select();
                           CowList_DGV.DataSource = dt;
                }
                catch(Exception ex)
                {
                   MessageBox.Show("Missing Information!");
                }   
        }

        private void txbx_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from FarmerTBL where ID like '%" +txbx_search.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CowList_DGV.DataSource = dt;
        }

        

        private void Farmer_Cows_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = GetFarmerData(userId);

                if (dt.Rows.Count > 0)
                {
                    txbx_FID.Text = dt.Rows[0]["F_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetFarmerData(int userId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from FarmerTBL where ID = @UserId";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.Parameters.AddWithValue("@UserId", userId);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
    }
}







