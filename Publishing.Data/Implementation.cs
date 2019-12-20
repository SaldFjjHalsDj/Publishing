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

        public Dictionary<int, int> AverageAmountOfBooksByMonth()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            string art = "И";

            Dictionary<int, int> result = data
                .Where(m => m.Theme == art)
                .GroupBy(inm => inm.MonthOfPublishing)
                .Select(g => new { MonthOfPublishing = g.Key, Circulation = g.Sum(m => m.Circulation)})
                .OrderBy(x => x.MonthOfPublishing)
                .ToDictionary(key => key.MonthOfPublishing, value => value.Circulation);

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

        public Dictionary<string, double> ShareOfYearForTheme(int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var count = data
                .Where(info => info.MonthOfPublishing == month)
                .Select(im => im.Circulation)
                .Sum() ;

            //var result = data
            //    .Where(info => info.Theme == theme)
            //    .Where(inf => inf.MonthOfPublishing == month)
            //    .Select(im => im.Circulation)
            //    .Sum();

            Dictionary<string, double> result = data
                .Where(m => m.MonthOfPublishing == month)
                .GroupBy(inm => inm.Theme)
                .Select(g => new { Theme = g.Key, Circulation = g.Sum(m => m.Circulation) * 100.0 / count})
                .ToDictionary(key => key.Theme, value => value.Circulation);

            return result;
        }


        // Все еще переписываю
        public Dictionary<string, int> ShareOfThemeForMonth()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .GroupBy(m => m.Theme)
                .Select(g => new { Theme = g.Key, Circulation = g.Sum(m => m.Circulation) })
                .ToDictionary(key => key.Theme, value => value.Circulation);

            return result;
        }
    }
}
