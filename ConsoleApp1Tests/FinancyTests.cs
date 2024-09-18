using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class FinancyTests
    {
        [TestMethod()]
        public void SplitMoneyTest()
        {
            // Arrange
            var financy = new Financy(new FakeCurrencyConverter());
            string expected = "553.444";

            // Act
            string result = financy.SplitMoney(100, 5).ToString();
            //取得結果後轉成字串，只取三位小數  
            result = result.Substring(0, result.IndexOf('.') + 4);

            // Assert
            Assert.AreEqual(expected, result);

        }
    }
}