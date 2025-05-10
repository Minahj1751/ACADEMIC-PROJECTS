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
    public partial class Farmer_Egg : Form
    {
        public Farmer_Egg()
        {
            InitializeComponent();
        }
        EggClass ec = new EggClass();
        private void EggList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            try
            {
                int row_index = e.RowIndex;

                txbx_EC_ID.Text = EggList_DGV.Rows[row_index].Cells[0].Value.ToString();
                txbx_group_ID.Text = EggList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_FID.Text = EggList_DGV.Rows[row_index].Cells[2].Value.ToString();
                collection_date.Text = EggList_DGV.Rows[row_index].Cells[3].Value.ToString();
                txbx_A_egg.Text = EggList_DGV.Rows[row_index].Cells[4].Value.ToString();
                txbx_N_egg.Text = EggList_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_P_egg.Text = EggList_DGV.Rows[row_index].Cells[6].Value.ToString();

            }
            catch(Exception)
            {
              
            }

            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                ec.G_ID = int.Parse(txbx_group_ID.Text);
                ec.F_ID = int.Parse(txbx_FID.Text);
                ec.CollectionDate = collection_date.Value.ToString();
                ec.AmEgg = int.Parse(txbx_A_egg.Text);
                ec.NoonEgg = int.Parse(txbx_N_egg.Text);
                ec.PmEgg = int.Parse(txbx_P_egg.Text);
                ec.TotalEgg = (int.Parse(txbx_A_egg.Text) + int.Parse(txbx_N_egg.Text) + int.Parse(txbx_P_egg.Text));
                 bool success = ec.Insert(ec);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }
            }
            catch(Exception)
            {

            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Egg_C_ID =int.Parse(txbx_EC_ID.Text);
                ec.G_ID = int.Parse(txbx_group_ID.Text);
                ec.F_ID = int.Parse(txbx_FID.Text);
                ec.CollectionDate = collection_date.Value.ToString();
                ec.AmEgg = int.Parse(txbx_A_egg.Text);
                ec.NoonEgg = int.Parse(txbx_N_egg.Text);
                ec.PmEgg = int.Parse(txbx_P_egg.Text);

                bool success = ec.Update(ec);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Update failed!");
                }
            }
            catch(Exception)
            {

            }


        }

        public void Clear()
        {
            txbx_EC_ID.Text = null;
            txbx_group_ID.Text = null;
            txbx_FID.Text = null;
            collection_date.Text = null;
            txbx_A_egg.Text = null;
            txbx_N_egg.Text = null;
            txbx_P_egg.Text = null;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ec.Select();
            EggList_DGV.DataSource = dt;

        }

        private void EggList_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txbx_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=StudentDB;Integrated Security=True");

            string query = "Select * from StudentInfo where FirstName like '%" +txbx_search.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EggList_DGV.DataSource = dt;
        }

        private void Farmer_Egg_Load(object sender, EventArgs e)
        {
            
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

                    {
                        con.Open();


                        string FarmerIDQuery = "SELECT ID FROM FarmerTBL";
                        using (SqlCommand command = new SqlCommand(FarmerIDQuery, con))
                        {
                            int FarmerID = (int)command.ExecuteScalar();
                            txbx_FID.Text = FarmerID.ToString();

                        }
                    }

                }
                catch (Exception)
                {

                }
        }
    }
}
