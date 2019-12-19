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

            //var result = data
            //    .Where(info => info.Theme == theme)
            //    .OrderBy(g => g.Price)
            //    .ToList();

            var res = data
                .Select(info => info.Theme)
                .Distinct()
                .ToArray() as string[];

            Dictionary<string, double> rest = new Dictionary<string, double>(res.Length);

            for (int i= 0; i < res.Length; i++)
            {
                var mis = data
                    .Where(info => info.Theme == res[i])
                    .Select(g => g.TotalSum)
                    .Sum();

                rest.Add(res[i], mis);
            };

            rest.OrderBy(x => x.Value);

            return rest;
        }

        public int AmountOfCirculationByTheme(string age)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(info => info.Age == age)
                .Select(m => m.Circulation)
                .Sum();

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
