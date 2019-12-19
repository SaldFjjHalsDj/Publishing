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
        Implementation implementation = new Implementation();

        public Form1()
        {
            InitializeComponent();
            ScreenSaver screensaver = new ScreenSaver();
            screensaver.ShowDialog();

            var saved = storage.Load();
            Information.DataSource = saved;
            Information.AutoResizeColumns();

            string[] ageNames = { "Детская", "Юношеская", "Взрослая" };

            AgeComboBox.Items.AddRange(ageNames);

            string[] theme = { "Учебная", "Художественная", "Публицистическая", "Искусство", "Научно-популярная" };
            ThemeComboBox.Items.AddRange(theme);

            string[] month = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            MonthComboBox.Items.AddRange(month);

            comboBoxForMonth.Items.AddRange(month);

            comboBoxColumn.Items.AddRange(month);

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

            List<DataSpace> space = new List<DataSpace>()
            {
                new DataSpace 
                {
                    Author = name,
                    Book = book,
                    Age = age,
                    Theme = theme,
                    Price = price,
                    Circulation = amount,
                    MonthOfPublishing = month,
                }
            };

            var sav = Information.DataSource as List<DataSpace>;
            sav.AddRange(space);
            storage.Save(sav);

            Information.DataSource = storage.Load();
            Information.AutoResizeColumns();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            var data = storage.Load();
            chartGraph.Series[0].Points.Clear();
            chartGraph.ChartAreas[0].AxisX.Interval = 1;

            for(int i = 1; i <= 12; i++)
            {
                chartGraph.Series[0].Points.AddXY(i, implementation.AverageAmountOfBooksByMonth(i));
            }
        }

        private void buttonPieGraph_Click(object sender, EventArgs e)
        {
            var data = storage.Load();
            chartPie.Series[0].Points.Clear();

            string[] theme = { "У", "Х", "П", "И", "Н" };

            for (int i = 0; i < 5; i++)
            {
                chartPie.Series[0].Points.AddXY("", implementation.ShareOfYearForTheme(theme[i], int.Parse(comboBoxForMonth.Text)));
            }
        }

        private void buttonForColumn_Click(object sender, EventArgs e)
        {
            var data = storage.Load();
            chartColumn.Series[0].Points.Clear();
            chartColumn.Series[1].Points.Clear();
            chartColumn.Series[2].Points.Clear();
            chartColumn.Series[3].Points.Clear();
            chartColumn.Series[4].Points.Clear();

            string[] theme = { "У", "Х", "П", "И", "Н" };

            string[] month = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };


            chartColumn.ChartAreas[0].AxisX.Interval = 1;

            for (int i = 1; i <= 12; i++)
            {
                chartColumn.Series[0].Points.AddXY(month[i - 1], implementation.ShareOfThemeForMonth(theme[0], i));
                chartColumn.Series[1].Points.AddXY(month[i - 1], implementation.ShareOfThemeForMonth(theme[1], i));
                chartColumn.Series[2].Points.AddXY(month[i - 1], implementation.ShareOfThemeForMonth(theme[2], i));
                chartColumn.Series[3].Points.AddXY(month[i - 1], implementation.ShareOfThemeForMonth(theme[3], i));
                chartColumn.Series[4].Points.AddXY(month[i - 1], implementation.ShareOfThemeForMonth(theme[4], i));
            }
        }
    }
}
