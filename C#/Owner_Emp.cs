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
    public partial class Owner_Emp : Form
    {
        public Owner_Emp()
        {
            InitializeComponent();
        }

        FarmerClass f = new FarmerClass();
       
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                f.ID = int.Parse(txbx_UID.Text);
                f.F_Name = txbx_UName.Text;
                f.F_Salary = txbx_salary.Text;
                f.F_join_dt = join_dt_pic.Value.ToString();
                f.F_dob = DOB_dt_pic.Value.ToString();
                f.F_email = txbx_email.Text;
                f.F_status = com_bx_status.Enabled;

                bool success = f.Insert(f);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = f.Select();
                Farmer_List_DGV.DataSource = dt;

            }
            catch(Exception)
            {

            }
            
        }

        public void Clear()
        {
            try
            {
                txbx_UID.Text = null;
                txbx_UName.Text = null;
                txbx_salary.Text = null;
                join_dt_pic.Text = null;
                DOB_dt_pic.Text = null;
                txbx_email.Text = null;
                com_bx_status.Text = null;
            }
           catch(Exception)
            {

            }
           
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
           
                DataTable dt = f.Select();
                Farmer_List_DGV.DataSource = dt;
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                f.F_ID = int.Parse(txbx_F_ID.Text);
                f.ID = int.Parse(txbx_UID.Text);
                f.F_Name = txbx_UName.Text;
                f.F_Salary = txbx_salary.Text;
                f.F_join_dt = join_dt_pic.Value.ToString();
                f.F_dob = DOB_dt_pic.Value.ToString();
                f.F_email = txbx_email.Text;
                f.F_status = com_bx_status.Enabled;

                bool success = f.Update(f);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Updated!");
                    Clear();
                }

                else
                {
                    MessageBox.Show("Data Update failed!");
                }


                DataTable dt = f.Select();
                Farmer_List_DGV.DataSource = dt;
            }
            catch(Exception)
            {
              
            }
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                f.F_ID = int.Parse(txbx_F_ID.Text);

                bool success = f.Delete(f);

                if (success == true)
                {
                    MessageBox.Show("Successfully data deleted!!");
                    
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Deletion failed");
                }

                DataTable dt = f.Select();
                Farmer_List_DGV.DataSource = dt;
            }
            catch(Exception)
            {
               
            }

        }

        private void Search_txbx_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            string query = "Select * from FarmerTBL where F_ID like '%" + Search_txbx.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Farmer_List_DGV.DataSource = dt;
        }

       

        private void Farmer_List_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;

                txbx_F_ID.Text = Farmer_List_DGV.Rows[row_index].Cells[0].Value.ToString();
                txbx_UID.Text = Farmer_List_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_UName.Text = Farmer_List_DGV.Rows[row_index].Cells[2].Value.ToString();
                txbx_salary.Text = Farmer_List_DGV.Rows[row_index].Cells[3].Value.ToString();
                join_dt_pic.Text = Farmer_List_DGV.Rows[row_index].Cells[4].Value.ToString();
                DOB_dt_pic.Text = Farmer_List_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_email.Text = Farmer_List_DGV.Rows[row_index].Cells[6].Value.ToString();
                com_bx_status.Text = Farmer_List_DGV.Rows[row_index].Cells[7].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void Farmer_List_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Owner_Emp_Load(object sender, EventArgs e)
        {

        }
    }
}
