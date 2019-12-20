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

            Dictionary<string, double> result = new Dictionary<string, double>()
            {
                {"П", 41251200.0},
                {"У", 63319200.0},
                {"Х", 67052056.0},
                {"Н", 79912800.0},
                {"И", 263644547.0},
            };

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

            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                {"Д", 64960},
                {"Ю", 116993},
                {"В", 132348},
            };

            //Action

            var inf = Implementation.AmountOfCirculationByTheme();

            // Assert
            
            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void AverageAmountOfBooksByMonth_Test()
        {
            // Arrage

            Dictionary<int, int> result = new Dictionary<int, int>()
            {
                {1, 3560},
                {2, 5230},
                {3, 1023},
                {4, 4000},
                {5, 8030},
                {6, 9870},
                {7, 17000},
                {8, 5000},
                {9, 7000},
                {10, 6500},
                {11, 50000},
                {12, 2300},
            };

            // Action

            var inf = Implementation.AverageAmountOfBooksByMonth();

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void ShareOfYearForTheme_Test()
        {
            int month = 2;

            // Arrage 

            Dictionary<string, double> result = new Dictionary<string, double>()
            {
                {"Х", 50.536013876645718},
                {"И", 7.4359484744220437},
                {"У", 35.54468678022009},
                {"Н", 2.9004464412659594},
                {"П", 3.5829044274461852},
            };

            // ActionЫ

            var inf = Implementation.ShareOfYearForTheme(month);

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

            var inf = Implementation.ShareOfThemeForMonth();

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(inf);
            Assert.AreEqual(expected, actually);
        }
    }
}
