using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Publishing.Data;

namespace Publishing.Tests
{
    [TestClass]
    [Serializable]
    public class ImplementationTests
    {
        Implementation Implementation = new Implementation();
        Storage storage = new Storage();

        [TestMethod]
        public void GetInformation_Test()
        {

            string age = "В";
            string theme = "Х";

            // Arrange

            var result = new List<DataSpace>()
            {
                new DataSpace
                {
                    Author = "Лев Толстой",
                    Book = "Война и мир",
                    Age = "В",
                    Theme = "Х",
                    Price = 650,
                    Circulation = 10000,
                    MonthOfPublishing = 10,
                },

                new DataSpace
                {
                    Author = "Дмитрий Глуховский",
                    Book = "Текст",
                    Age = "В",
                    Theme = "Х",
                    Price = 899,
                    Circulation = 35544,
                    MonthOfPublishing = 2,
                },
            };

            // Action

            var inf = Implementation.GetInformation(age, theme);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void SortByHigherTotalSum_Test()
        {
            // Arrange

            var result = 4;

            // Action

            var inf = Implementation.SortByHigherTotalSum();

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void AmountOfCirculationByTheme_Test()
        {
            string age = "В";

            // Arrange

            int result = 81068;

            //Action

            var inf = Implementation.AmountOfCirculationByTheme(age);

            // Assert
            
            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void AverageAmountOfBooksByMonth_Test()
        {
            int month = 3;

            // Arrage

            int result = 1023;

            // Action

            var inf = Implementation.AverageAmountOfBooksByMonth(month);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void ShareOfYearForTheme_Test()
        {
            string theme = "У";
            int month = 2;

            // Arrage 

            int result = 35;

            // Action

            var inf = Implementation.ShareOfYearForTheme(theme, month);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void ShareOfThemeForMonth()
        {
            string theme = "У";
            int month = 2;

            // Arrage

            int result = 25000;

            // Action

            var inf = Implementation.ShareOfThemeForMonth(theme, month);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }
    }
}
