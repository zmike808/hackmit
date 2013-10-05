using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DropNet;

namespace RPIHackMIT
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
            Application.Run(new Form1());
        }


        /*List<double> getPercentages(List<int> sizes, int maxsize)
        {
            List<double> percents = new List<double>();
            foreach (int x in sizes)
            {
                double p = (double)x/maxsize * 100;
                percents.Add(p);
            }
            return percents;
        }*/
    }
}
