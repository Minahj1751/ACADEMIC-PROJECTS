using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management_System
{
    public partial class Salesman_egg : Form
    {
        public Salesman_egg()
        {
            InitializeComponent();
        }
        EggSaleClass es = new EggSaleClass();

      
        public void Clear()
        {
            txbx_Egg_S_ID.Text = null;
            txbx_SalerID.Text = null;
            salling_date.Text = null;
            txbx_Buyer_ID.Text = null;
            txbx_Buyer_Name.Text = null;
            txbx_price.Text = null;
            txbx_Quantity.Text = null;
            txbx_Total_price.Text = null;

        }

      
        private void btn_add_Click_1(object sender, EventArgs e)
        {


            try
            {
                es.S_ID = int.Parse(txbx_SalerID.Text);
                es.Egg_S_Date = salling_date.Value.ToString();
                es.Egg_Buyer_ID = int.Parse(txbx_Buyer_ID.Text);
                es.E_Buyer_Name = txbx_Buyer_Name.Text;
                es.Price_Per_Pis = int.Parse(txbx_price.Text);
                es.Egg_S_Quantity = int.Parse(txbx_Quantity.Text);
                es.Egg_Total_Price = int.Parse(txbx_Total_price.Text);

                bool success = es.Insert(es);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = es.Select();
                Egg_saleDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Missing Information!");
            }


        }

        private void brn_update_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Assuming you have the Egg_S_ID value in txbx_Egg_S_ID
                es.Egg_S_ID = int.Parse(txbx_Egg_S_ID.Text);
                es.S_ID = int.Parse(txbx_SalerID.Text);
                es.Egg_S_Date = salling_date.Value.ToString();
                es.Egg_Buyer_ID = int.Parse(txbx_Buyer_ID.Text);
                es.E_Buyer_Name = txbx_Buyer_Name.Text;
                es.Price_Per_Pis = int.Parse(txbx_price.Text);
                es.Egg_S_Quantity = int.Parse(txbx_Quantity.Text);
                es.Egg_Total_Price = int.Parse(txbx_Total_price.Text);

                bool success = es.Update(es);

                if (success)
                {
                    MessageBox.Show("Successfully updated data!");
                    Clear(); // Clear the form fields or perform any other necessary actions
                }
                else
                {
                    MessageBox.Show("Data update failed!");
                }

                // Refresh the DataGridView after update
                DataTable dt = es.Select();
                Egg_saleDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btn_show_Click_1(object sender, EventArgs e)
        {

            DataTable dt = es.Select();
            Egg_saleDGV.DataSource = dt;

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            es.Egg_S_ID = int.Parse(txbx_Egg_S_ID.Text);

            bool success = es.Remove(es);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");
                Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = es.Select();
            Egg_saleDGV.DataSource = dt;

        }

        private void Egg_saleDGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            txbx_Egg_S_ID.Text = Egg_saleDGV.Rows[row_index].Cells[0].Value.ToString();
            txbx_SalerID.Text = Egg_saleDGV.Rows[row_index].Cells[1].Value.ToString();
            salling_date.Text = Egg_saleDGV.Rows[row_index].Cells[2].Value.ToString();
            txbx_Buyer_ID.Text = Egg_saleDGV.Rows[row_index].Cells[3].Value.ToString();
            txbx_Buyer_Name.Text = Egg_saleDGV.Rows[row_index].Cells[4].Value.ToString();
            txbx_Total_price.Text = Egg_saleDGV.Rows[row_index].Cells[7].Value.ToString();
            txbx_Quantity.Text = Egg_saleDGV.Rows[row_index].Cells[6].Value.ToString();
            txbx_price.Text = Egg_saleDGV.Rows[row_index].Cells[5].Value.ToString();

        }
    }
}
