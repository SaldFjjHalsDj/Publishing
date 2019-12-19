using Publishing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publishing.FormsUI
{
    public partial class Form1 : Form
    {

        CultureInfo CultureInfo = new CultureInfo("ru-RU");
        Storage storage = new Storage();

        public Form1()
        {
            InitializeComponent();
            ScreenSaver screensaver = new ScreenSaver();
            screensaver.ShowDialog();

            var saved = storage.Load();
            Information.DataSource = storage.Load();
            Information.AutoResizeColumns();

            for (int i = 0; i < storage.Load().Count - 1; i++)
            {
                var perem = Information[1, i].Value;
            }

            string[] ageNames = { "Детская", "Юношеская", "Взрослая" };

            AgeComboBox.Items.AddRange(ageNames);

            string[] theme = { "Учебная", "Художественная", "Публицистическая", "Книги по искусству", "Научно-популярная" };
            ThemeComboBox.Items.AddRange(theme);

            string[] month = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            MonthComboBox.Items.AddRange(month);
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string book = BookBox.Text;
            string age = AgeComboBox.Text.ToString()[0].ToString();
            string theme = ThemeComboBox.Text.ToString()[0].ToString();
            double price = double.Parse(PriceBox.Text);
            int amount = int.Parse(CirculationBox.Text);
            int month = int.Parse(MonthComboBox.Text);

            Information.Rows.Add(name, book, age, theme, price, amount, month);
        }
    }
}
