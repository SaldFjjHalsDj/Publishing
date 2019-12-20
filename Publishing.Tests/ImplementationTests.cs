﻿using System;
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
                {"П", 9172800.0},
                {"Н", 26920800.0},
                {"У", 37500000.0},
                {"Х", 38454056.0 },
                {"И", 216604547.0},
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
                {"Д", 12560},
                {"В", 81068},
                {"Ю", 116993},
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
