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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SignUpClass Sc = new SignUpClass();
       
        private void btn_Sign_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbx_UserName.Text) || string.IsNullOrWhiteSpace(txbx_UserPassword.Text) || string.IsNullOrWhiteSpace(com_bx_UserRole.Text))
            {
                MessageBox.Show("Please fill in all the fields before signing up.");
                return;
            }

            Sc.Name = txbx_UserName.Text;
            Sc.Password = txbx_UserPassword.Text;
            Sc.Role = com_bx_UserRole.Text;

            bool success = Sc.Insert(Sc);

            if (success == true)
            {
                MessageBox.Show("Sign Up Successfully");
              
            }
            else
            {
                MessageBox.Show("Sign Up Cannot Succesed ! Please Try Again");
            }


        }
        public void Clear()
        {
            txbx_UserName.Text = null;
            txbx_UserPassword.Text = null;
            com_bx_UserRole.Text = null;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}




