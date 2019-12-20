using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Publishing.Data
{
    [Serializable]
    public class DataSpace
    {
        public string Author { get; set; }
        
        public string Book { get; set; }

        public string Age { get; set; }

        public string Theme { get; set; }

        public double Price { get; set; }
       
        public int Circulation { get; set; }

        public int MonthOfPublishing { get; set; }

        public double TotalSum
        {

            get
            {
                return Price * Circulation;
            }
        }
    }
}
