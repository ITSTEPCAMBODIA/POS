using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ListViewItem[] items = new ListViewItem[100];
            for (int i = 0; i < 100; i++)
            {
                items[i] = new ListViewItem(new[] { $"{i}",$"N0000{i}","15","French Fries","2.3$",DateTime.Now.ToString(),DateTime.Now.ToString()});
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new History.History(items));
        }
    }
}
