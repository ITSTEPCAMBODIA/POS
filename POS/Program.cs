using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing;
using System.Drawing;


namespace POS
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
            Application.Run(new POS.Satya.tbFoodPrice());
            //Receipt R = new Receipt();
            // set logo
            //R.LogoImage = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");
            // set info
            //R.Infos["one"] = 123;
            //R.Infos["two"] = "asdfasd";
            //R.Infos["three"] = "faaoiwnsadfa";
            // set bills info
            //for (int i = 0; i < 5; i++)
            //    R.Bills.Add(new Bill($"test {i}", i, 2.3));
            // show dialog
            //R.ShowDialog();
            //Application.Run(R);
        }
    }
}
