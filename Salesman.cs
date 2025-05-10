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
    public partial class Salesman : Form
    {
        private int userId;
        private bool isCollapsed;
        public Salesman(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            DisplayUserID();
        }
        private void DisplayUserID()
        {
            label1.Text = userId.ToString();
        }
        public void LoadSalesman(Object Form)
        {
            if (this.S_mainpanel.Controls.Count > 0)
                this.S_mainpanel.Controls.RemoveAt(0);

            Form s = Form as Form;
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;
            this.S_mainpanel.Controls.Add(s);
            this.S_mainpanel.Tag = s;
            s.Show();


        }

        private void gbtn_milk_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Salesman_milk());
        }

        private void gbtn_egg_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Salesman_egg());
        }
        private void gbtn_CPassword_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Change_password());
        }
       
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadSalesman(new OrderList());
        }

        private void gbtn_Product_Click(object sender, EventArgs e)
        {
            productimer.Start();
        }
        private void productimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                gbtn_Product.Image = Resources.rsz_1rsz_dropup;
                Product_panel.Height += 10;
                if (Product_panel.Size == Product_panel.MaximumSize)
                {
                    productimer.Stop();
                    isCollapsed = false;
                  
                }
                
            }
            else
            {
                gbtn_Product.Image = Resources.rsz_dropdown___copy;
                Product_panel.Height -= 10;
                if (Product_panel.Size == Product_panel.MinimumSize)
                {
                    productimer.Stop();
                    isCollapsed = true;
                    LoadSalesman(new Profile(userId));
                }
            
            }
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbtn_Logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Incom(userId));
        }
        private void gbtn_Notification_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Notification());
        }

        private void gbtn_mail_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Mail(userId));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Profile(userId));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadSalesman(new Price());
        }
    }
}
