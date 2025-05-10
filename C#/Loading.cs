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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
        }
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                lvl.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                loadingTimer.Stop();

                Login lg = new Login();
                this.Hide();
                lg.Show();

            }
        }

       
    }
}
