using Farm_Management_System.Properties;
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
    public partial class Owner : Form
    {
        private int userId;
        public Owner(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            DisplayUserID();

        }
        public bool isCollapsed;

        private void DisplayUserID()
        {
            label1.Text = userId.ToString();
        }

        public void LoadOwner(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
       
        private void gbtn_CPassword_Click(object sender, EventArgs e)
        {
            LoadOwner(new Change_password());
        }
        private void gbtn_FarmerList_Click(object sender, EventArgs e)
        {
            LoadOwner(new Owner_Emp());
        }
        private void gbtn_SalesmanList_Click(object sender, EventArgs e)
        {
            LoadOwner(new Owner_Emp2());
        }
        private void gbtn_Dashboard_Click(object sender, EventArgs e)
        {
            LoadOwner(new Dashboard());
        }
        private void gbtn_SignUpList_Click(object sender, EventArgs e)
        {
            LoadOwner(new SignUpList());

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadOwner(new Notification());
        }
        private void gbtn_mail_Click(object sender, EventArgs e)
        {
            LoadOwner(new Mail(userId));
        }
        private void gbtn_Logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Farmer fr = new Farmer();
            this.Hide();
           // fr.Show();
        }

        private void gbtn_Emp_Click(object sender, EventArgs e)
        {
            timerEmp.Start();
        }

        private void timerEmp_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                gbtn_Emp.Image = Resources.rsz_1rsz_dropup;

                Emp_panel.Height += 10;
                if (Emp_panel.Size == Emp_panel.MaximumSize)
                {
                    timerEmp.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                gbtn_Emp.Image = Resources.rsz_dropdown___copy;

                Emp_panel.Height -= 10;
                if (Emp_panel.Size == Emp_panel.MinimumSize)
                {
                    timerEmp.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void picbx_profile_Click(object sender, EventArgs e)
        {
            LoadOwner(new Profile(userId));
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure!");
            if(true)
            {
                Application.Exit();
            }
            else
            {
               
            }
        }

        private void gbtn_finance_Click(object sender, EventArgs e)
        {
            LoadOwner(new Expend(userId));
        }
    }

}
