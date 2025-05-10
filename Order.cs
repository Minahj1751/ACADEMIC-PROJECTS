using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    public partial class Order : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        public Order()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        OrderClass oc = new OrderClass();

        private void btn_Exit_OrderFrom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        public void Clear()
        {
            txbx_name.Text = null;
            txbx_email.Text = null;
            txbx_phone.Text = null;
            txbx_Egg.Text = null;
            txbx_Milk.Text = null;
            txbx_address.Text = null;
            order_date.Text = null;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txbx_name.Text) || string.IsNullOrWhiteSpace(txbx_phone.Text))
            {
                MessageBox.Show("Please fill in all the fields before signing up.");
                return;
            }
            try
            {
                oc.B_Name = txbx_name.Text;
                oc.B_Email = txbx_email.Text;
                oc.B_Phone = txbx_phone.Text;
                oc.Egg = int.Parse(txbx_Egg.Text);
                oc.Milk = int.Parse(txbx_Milk.Text);
                oc.Address = txbx_address.Text;
                oc.Order_Date = order_date.Value;

                bool success = oc.Insert(oc);

                if (success == true)
                {
                    MessageBox.Show("Successfully Order Send!");

                }
                else
                {
                    MessageBox.Show("Order Does not send!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You Need to Fillup Minimum Quantity as '0''");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure You Want To Clear All?");
            if (false)
            {

            }
            else
            {
                Clear();
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float yPosition = 50;

            e.Graphics.DrawString("Name: " + txbx_name.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Email: " + txbx_email.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Phone: " + txbx_phone.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Egg Quantity: " + txbx_Egg.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Milk Quantity: " + txbx_Milk.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Address: " + txbx_address.Text, font, brush, 50, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Order Date: " + order_date.Value.ToShortDateString(), font, brush, 50, yPosition);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
            Clear();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            pm.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            {
                con.Open();


                string EggQuery = "SELECT Egg FROM PriceTBL";
                using (SqlCommand command = new SqlCommand(EggQuery, con))
                {
                    int Egg = (int)command.ExecuteScalar();
                    eggp.Text = $": {Egg}";
                }
                string MilkQuery = "SELECT Milk FROM PriceTBL";
                using (SqlCommand command = new SqlCommand(MilkQuery, con))
                {
                    int Milk = (int)command.ExecuteScalar();
                    milkp.Text = $": {Milk}";
                }

                con.Close();
            }
        }
    }
}









