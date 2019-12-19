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
        [DataMember]
        public string Author { get; set; }
        
        [DataMember]
        public string Book { get; set; }

        [DataMember]
        public string Age { get; set; }

        [DataMember]
        public string Theme { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Circulation { get; set; }

        [DataMember]
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
