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

        public List<DataSpace> GetThemePrice()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .ToList();

        //    var result = data
        //        .Select(info => info.Theme && info.Aver)
        //        .ToList() as List<double>;


        //    //var price = data
        //    //    .Where(info => info.Theme == theme)
        //    //    .Select(x => x.Price)
        //    //    .ToList() as List<double>;

        //    //var amount = data
        //    //    .Where(info => info.Theme == theme)
        //    //    .Select(y => y.Circulation)
        //    //    .ToList() as List<int>;

        //    //var result = price.Select(x => x * amount.Select(y => y)).ToList();
            
            return result;
        }

        public List<DataSpace> SortByHigherCirculation()
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            //var result = data
            //    .Where(info => info.Theme == theme)
            //    .OrderBy(g => g.Price)
            //    .ToList();

            var result = data
                .OrderBy(m => m.Aver)
                .ToList() as List<DataSpace>;

            return result;
        }

        public List<int> AmountOfCirculationByTheme(string age)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(info => info.Age == age)
                .Select(g => g.Theme)
                .Select(k => data.Select(m => m.Circulation)
                .Sum())
                .ToList() as List<int>;

            return result;
        }

        public List<DataSpace> AverageAmountOfBooksByMonth(int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            string art = "И";

            var result = data
                .Where(info => info.MonthOfPublishing == month)
                .Where(inf => inf.Theme == art)
                .ToList() as List<DataSpace>;

            return result;
        }

        public List<DataSpace> ShareOfBooksAndMonth(int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(info => info.MonthOfPublishing == month)
                .ToList();

            return result;
        }

        public int ShareOfYearForTheme(string theme, int month)
        {
            List<DataSpace> data = new List<DataSpace>();
            Storage storage = new Storage();
            data = storage.Load();

            var result = data
                .Where(info => info.Theme == theme)
                .Where(inf => inf.MonthOfPublishing == month)
                .Select(im => im.Circulation)
                .Sum();

            return result;
        }
    }
}
