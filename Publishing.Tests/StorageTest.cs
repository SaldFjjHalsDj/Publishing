using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Publishing.Data;

namespace Publishing.Tests
{
    [TestClass]
    public class StorageTest
    {
        Storage storage = new Storage();
        
        [TestMethod]
        public void Storage_Test()
        {
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

            storage.Save(data, "datatest");
            var result = storage.Load("datatest");

            string expected = JsonConvert.SerializeObject(data);
            string actually = JsonConvert.SerializeObject(result);

            Assert.AreEqual(actually, expected);
        }
    }
}
