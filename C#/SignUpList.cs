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
    public partial class SignUpList : Form
    {
        public SignUpList()
        {
            InitializeComponent();
        }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-POO4TBO;Initial Catalog=CattleFarm;Integrated Security=True");

            DataTable dt = new DataTable();

            string query = "Select * from LoginTBL";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        private void show_Click(object sender, EventArgs e)
        {
            DataTable dt = Select();
            signupDGV.DataSource = dt;
        }
    }
}
