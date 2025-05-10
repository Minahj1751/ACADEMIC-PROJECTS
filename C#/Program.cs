using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new Loading());
                 //Application.Run(new Login());
            // Application.Run(new Mail());
           //  Application.Run(new Owner());
           //  Application.Run(new Farmer(userId));
           //  Application.Run(new Salesman());
            // Application.Run(new Farmer_Cows());
            // Application.Run(new Expend());
            // Application.Run(new Salesman_milk());
            // Application.Run(new Order());

        }
    }
}
