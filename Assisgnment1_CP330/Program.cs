using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assisgnment1_CP330
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

            
            Ship s1 = new Ship();
            //IShip IS1 = (IShip)s1;
            withNano wN = new withNano(s1);
            //wN.PrntMe(); //testing program
            //Console.WriteLine();

            withSteel Ws = new withSteel(s1);
            //Ws.PrntMe(); //testing program

            //Console.WriteLine();

            withHoneycomb wH = new withHoneycomb(s1);
            //wH.PrntMe(); //testing program

        }
    }
}
