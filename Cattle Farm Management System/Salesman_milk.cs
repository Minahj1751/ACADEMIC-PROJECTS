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
    public partial class Salesman_milk : Form
    {
        public Salesman_milk()
        {
            InitializeComponent();
        }
        MilkSaleClass ms = new MilkSaleClass();

        public void Clear()
        {
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
                ms.S_ID = int.Parse(txbx_SalerID.Text);
                ms.Milk_S_Date = salling_date.Value.ToString();
                ms.M_Buyer_ID = int.Parse(txbx_Buyer_ID.Text);
                ms.M_Buyer_Name = txbx_Buyer_Name.Text;
                ms.Price_Per_Litter = int.Parse(txbx_price.Text);
                ms.Milk_S_Quantity = float.Parse(txbx_Quantity.Text);
                ms.Milk_Total_Price = float.Parse(txbx_Total_price.Text);



                bool success = ms.Insert(ms);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = ms.Select();
                Milk_saleDGV.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Missing Information!");
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ms.Select();
            Milk_saleDGV.DataSource = dt;
        }

        private void Milk_saleDGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            txbx_Milk_S_ID.Text = Milk_saleDGV.Rows[row_index].Cells[0].Value.ToString();
            salling_date.Text = Milk_saleDGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_Buyer_ID.Text = Milk_saleDGV.Rows[row_index].Cells[2].Value.ToString();
            txbx_Buyer_Name.Text = Milk_saleDGV.Rows[row_index].Cells[3].Value.ToString();
            txbx_price.Text = Milk_saleDGV.Rows[row_index].Cells[4].Value.ToString();
            txbx_Quantity.Text = Milk_saleDGV.Rows[row_index].Cells[5].Value.ToString();
            txbx_Total_price.Text = Milk_saleDGV.Rows[row_index].Cells[6].Value.ToString();
            txbx_SalerID.Text = Milk_saleDGV.Rows[row_index].Cells[7].Value.ToString();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            ms.Milk_S_ID = int.Parse(txbx_Milk_S_ID.Text);

            bool success = ms.Remove(ms);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");
                Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }

            DataTable dt = ms.Select();
            Milk_saleDGV.DataSource = dt;
        }

        private void brn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ms.Milk_S_ID = int.Parse(txbx_Milk_S_ID.Text);
                ms.S_ID = int.Parse(txbx_SalerID.Text);
                ms.Milk_S_Date = salling_date.Value.ToString();
                ms.M_Buyer_ID = int.Parse(txbx_Buyer_ID.Text);
                ms.M_Buyer_Name = txbx_Buyer_Name.Text;
                ms.Price_Per_Litter = int.Parse(txbx_price.Text);
                ms.Milk_S_Quantity = float.Parse(txbx_Quantity.Text);
                ms.Milk_Total_Price = float.Parse(txbx_Total_price.Text);

                bool success = ms.Update(ms);

                if (success == true)
                {
                    MessageBox.Show("Successfully data updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data update failed!");
                }

                DataTable dt = ms.Select();
                Milk_saleDGV.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Missing Information or Invalid Data!");
            }

        }
    }
}
