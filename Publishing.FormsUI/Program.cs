using Publishing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publishing.FormsUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Storage storage = new Storage();
            List<DataSpace> info = new List<DataSpace>();

            var data = new List<DataSpace>()
            {
                new DataSpace
                {
                    Author = "Set",
                    Book = "50 shades of grey",
                    Age = "В",
                    Theme = "Х",
                    Price = 2.5,
                    Circulation = 10,
                    MonthOfPublishing = 3,
                }
            };

            storage.Save(data);
        }
    }
}
