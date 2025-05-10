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
using System.Data.SqlClient;


namespace Farm_Management_System
{
    public partial class Farmer : Form
    {
        private bool isCollapsed;
        private int userId;
        public Farmer(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            DisplayUserID();
        }
        private void gbtn_Livestock_Click_1(object sender, EventArgs e)
        {
            Livestocktimer.Start();
        }

        private void DisplayUserID()
        {
            label1.Text = userId.ToString();
        }
        private void Livestocktimer_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                gbtn_Livestock.Image = Resources.rsz_1rsz_dropup;
               
                Livestock_panel.Height += 10;
                if (Livestock_panel.Size == Livestock_panel.MaximumSize)
                {
                    Livestocktimer.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                gbtn_Livestock.Image = Resources.rsz_dropdown___copy;
               
                Livestock_panel.Height -= 10;
                if (Livestock_panel.Size == Livestock_panel.MinimumSize)
                {
                    Livestocktimer.Stop();
                   
                    isCollapsed = true;
                   
                }
               

            }
           
        }
        private void gbtn_Transaction_Click(object sender, EventArgs e)
        {
            Transactiontimer.Start();
        }
        private void Transactiontimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                gbtn_Transaction.Image = Resources.rsz_1rsz_dropup;
                transaction_panel.Height += 10;
                if (transaction_panel.Size == transaction_panel.MaximumSize)
                {
                    Transactiontimer.Stop();
                    isCollapsed = false;
                }


            }
            else
            {
                gbtn_Transaction.Image = Resources.rsz_dropdown___copy;
                transaction_panel.Height -= 10;
                if (transaction_panel.Size == transaction_panel.MinimumSize)
                {
                    Transactiontimer.Stop();
                    LoadFarmer(new Profile(userId));
                    isCollapsed = true;
                }

            }
           
        }
        private void gbtn_Production_Click(object sender, EventArgs e)
        {
            Productiontimer.Start();
        }
        private void Productiontimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                gbtn_Production.Image = Resources.rsz_1rsz_dropup;
                production_panel.Height += 10;
                if (production_panel.Size == production_panel.MaximumSize)
                {
                    Productiontimer.Stop();
                    isCollapsed = false;
                  
                }
                
            }
            else
            {
                gbtn_Production.Image = Resources.rsz_dropdown___copy;
                production_panel.Height -= 10;
                if (production_panel.Size == production_panel.MinimumSize)
                { 
                    Productiontimer.Stop();                   
                    isCollapsed = true;
                    
                }

            }
            
        }


        public void LoadFarmer(object Form)
        {
            if (this.F_mainpanel.Controls.Count > 0)
                this.F_mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.F_mainpanel.Controls.Add(f);
            this.F_mainpanel.Tag = f;
            f.Show();
        }

        private void gbtn_Cows_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Farmer_Cows(userId) );
        }

        private void gbtn_Chicken_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Farmer_Chicken(userId));
        }

        private void gbtn_Income_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Incom(userId));
        }

        private void gbtn_Expend_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Expend(userId));
        }

        private void gbtn_Milk_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Farmer_Milk ());
        }

        private void gbtn_Egg_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Farmer_Egg());
        }

        private void gbtn_health_report_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Health_Report());
        }
        private void gbtn_CPassword_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Change_password());
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbtn_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void picbx_Farmer_profile_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Profile(userId));
        }

        private void Farmer_Load(object sender, EventArgs e)
        {
           
        }

        private void gbtn_notification_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Notification());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadFarmer(new Mail(userId));
        }
    }
}










