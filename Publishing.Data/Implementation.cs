using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publishing.Data
{
    public class Implementation
    {
        public List<DataSpace> GetInformation(string age, string theme)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(info => info.Age == age)
                .Where(info => info.Theme == theme)
                .ToList() as List<DataSpace>;

            return result;
        }
        public Dictionary<string, double> SortByHigherTotalSum()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            Dictionary<string, double> result = data
                .GroupBy(x => x.Theme)
                .Select(g => new { Theme = g.Key, Sum = g.Sum(p => p.TotalSum) })
                .OrderBy(x => x.Sum)
                .ToDictionary(key => key.Theme, value => value.Sum);

            return result;
        }

        public Dictionary<string, int> AmountOfCirculationByTheme()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            Dictionary<string, int> result = data
                .GroupBy(x => x.Age)
                .Select(g => new { Age = g.Key, Circulation = g.Sum(p => p.Circulation) })
                .OrderBy(x => x.Circulation)
                .ToDictionary(key => key.Age, value => value.Circulation);

            return result;
        }

        public int AverageAmountOfBooksByMonth(int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            string art = "И";

            var result = data
                .Where(info => info.MonthOfPublishing == month)
                .Where(inf => inf.Theme == art)
                .Select(m => m.Circulation)
                .Sum();

            return result;
        }

        //public List<DataSpace> ShareOfBooksAndMonth(int month)
        //{
        //    List<DataSpace> data = new List<DataSpace>();
        //    Storage storage = new Storage();
        //    data = storage.Load();

        //    var result = data
        //        .Where(info => info.MonthOfPublishing == month)
        //        .ToList();

        //    return result;
        //}

        public int ShareOfYearForTheme(string theme, int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var count = data
                .Where(info => info.MonthOfPublishing == month)
                .Select(im => im.Circulation)
                .Sum();

            var result = data
                .Where(info => info.Theme == theme)
                .Where(inf => inf.MonthOfPublishing == month)
                .Select(im => im.Circulation)
                .Sum();

            return int.Parse(Math.Truncate((result * 1.0 / count) * 100).ToString());
        }

        public int ShareOfThemeForMonth(string theme, int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(inf => inf.Theme == theme)
                .Where(info => info.MonthOfPublishing == month)
                .Select(im => im.Circulation)
                .Sum();

            return result;
        }
    }
}
