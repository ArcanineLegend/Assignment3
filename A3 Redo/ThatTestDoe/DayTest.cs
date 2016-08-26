using A3_Redo;
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A3_Redo.Tests
{
    [TestClass()]
    public class DayTest
    {
        [TestMethod()]
        public void AddTest()
        {
            DateTime dateTime = new DateTime(2016,8,25);
            Day test = new Day(dateTime);
            test.Add(Day.TimeCodes.SICK, 7);
            string expected = "Day: " + test.dateTime + " Reg: " + 0 + " Sick: " + 7 + " Vac: " + 0 + " Total: " + 7; ;
            string result = test.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            DateTime dateTime = new DateTime(2016, 8, 25);
            Day test = new Day(dateTime);
            test.Remove(Day.TimeCodes.SICK, 7);
            string expected = "Day: " + test.dateTime + " Reg: " + 0 + " Sick: " + -7 + " Vac: " + 0 + " Total: " + -7; ;
            string result = test.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            DateTime dateTime = new DateTime(2016, 8, 25);
            Day test = new Day(dateTime);
            test.Remove(Day.TimeCodes.SICK, 7);
            string expected = "Day: 8/25/2016 12:00:00 AM Reg: 0 Sick: -7 Vac: 0 Total: -7";
            string result = test.ToString();
            Assert.AreEqual(expected, result);
        }
    }
}
