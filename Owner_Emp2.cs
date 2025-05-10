using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management_System
{
    public partial class Owner_Emp2 : Form
    {
        public Owner_Emp2()
        {
            InitializeComponent();
        }

        SalesmanClass s = new SalesmanClass();
        public void Clear()
        {
            txbx_UID.Text = null;
            txbx_UName.Text = null;
            txbx_salary.Text = null;
            join_dt_pic.Text = null;
            DOB_dt_pic.Text = null;
            txbx_email.Text = null;
            com_bx_status.Text = null;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {


            DataTable dt = s.Select();
            Salesman_List_DGV.DataSource = dt;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                s.S_ID = int.Parse(txbx_S_ID.Text);
                s.ID = int.Parse(txbx_UID.Text);
                s.S_Name = txbx_UName.Text;
                s.S_Salary = txbx_salary.Text;
                s.S_join_dt = join_dt_pic.Value.ToString();
                s.S_dob = DOB_dt_pic.Value.ToString();
                s.S_email = txbx_email.Text;
                s.S_status = com_bx_status.Enabled;

                bool success = s.Update(s);
                if (success == true)
                {
                    MessageBox.Show("Successfully data Updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Update failed!");
                }


                DataTable dt = s.Select();
                Salesman_List_DGV.DataSource = dt;
            }
            catch (Exception s)
            {
                MessageBox.Show("Data Update NOT Exicuted");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                s.ID = int.Parse(txbx_UID.Text);
                s.S_Name = txbx_UName.Text;
                s.S_Salary = txbx_salary.Text;
                s.S_join_dt = join_dt_pic.Value.ToString();
                s.S_dob = DOB_dt_pic.Value.ToString();
                s.S_email = txbx_email.Text;
                s.S_status = com_bx_status.Enabled;

                bool success = s.Insert(s);

                if (success)
                {
                    MessageBox.Show("Successfully added a new salesman!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add a new salesman!");
                }

                DataTable dt = s.Select();
                Salesman_List_DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Insert NOT Executed: " + ex.Message);
            }



        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                s.S_ID = int.Parse(txbx_S_ID.Text);

                bool success = s.Delete(s);

                if (success == true)
                {
                    MessageBox.Show("Successfully data deleted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Deletion failed!");
                }

                DataTable dt = s.Select();
                Salesman_List_DGV.DataSource = dt;
            }
            catch (Exception)
            { 
              
            }
        }

      
        
        private void Search_txbx1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");

            string query = "Select * from SalesmanTBL where ID like '%" + Search_txbx1.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Salesman_List_DGV.DataSource = dt;
        }

        private void Salesman_List_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            txbx_S_ID.Text = Salesman_List_DGV.Rows[row_index].Cells[0].Value.ToString();
            txbx_UID.Text = Salesman_List_DGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_UName.Text = Salesman_List_DGV.Rows[row_index].Cells[2].Value.ToString();
            txbx_salary.Text = Salesman_List_DGV.Rows[row_index].Cells[3].Value.ToString();
            join_dt_pic.Text = Salesman_List_DGV.Rows[row_index].Cells[4].Value.ToString();
            DOB_dt_pic.Text = Salesman_List_DGV.Rows[row_index].Cells[5].Value.ToString();
            txbx_email.Text = Salesman_List_DGV.Rows[row_index].Cells[6].Value.ToString();
            com_bx_status.Text = Salesman_List_DGV.Rows[row_index].Cells[7].Value.ToString();
        }
    }

}



