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
using System.Data;

namespace Farm_Management_System
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }


        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");
            DataTable dt = new DataTable();

            string query = "Select * from MailTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);

            return dt;
        }
        

        private void btn_notification_Click(object sender, EventArgs e)
        {
            DataTable dt = Select();
            NotificationDGV.DataSource = dt;
        }

        private void NotificationDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            txbx_subject.Text = NotificationDGV.Rows[row_index].Cells[1].Value.ToString();
            txbx_sender.Text = NotificationDGV.Rows[row_index].Cells[4].Value.ToString();
            ShowMgs.Text = NotificationDGV.Rows[row_index].Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
