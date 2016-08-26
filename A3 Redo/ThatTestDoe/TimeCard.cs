using A3_Redo;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A3_Redo.Tests
{
    [TestClass()]
    public class TimeCardTests
    {
        //ADD AND REMOVE TESTS

        [TestMethod()]
        public void ToStringTest()
        {
            DateTime dateTime = new DateTime(2016, 8, 21);
            TimeCard time = new TimeCard(dateTime);
            Day test = new Day(dateTime);
            string expected = ("Day: " + test.dateTime + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(1) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(2) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(3) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(4) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(5) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(6) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(7) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(8) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(9) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(10) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(11) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(12) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(13) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n"); ;
            string result = time.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AddHourTest()
        {
            DateTime dateTime = new DateTime(2016, 8, 21);
            Day test = new Day(dateTime);
            TimeCard time = new TimeCard(dateTime);
            time.AddHour(0, Day.TimeCodes.REGULAR, 8);
            string expected = ("Day: " + test.dateTime + " Reg: " + 8 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 8 +"\n" +
                "Day: " + test.dateTime.AddDays(1) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(2) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(3) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(4) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(5) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(6) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(7) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(8) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(9) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(10) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(11) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(12) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(13) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n");//reverts everything back to zero 
            string result = time.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RemoveHoursTest()
        {
            DateTime dateTime = new DateTime(2016, 8, 21);
            Day test = new Day(dateTime);
            TimeCard time = new TimeCard(dateTime);
            time.AddHour(0, Day.TimeCodes.REGULAR, 8);
            time.RemoveHours(0, Day.TimeCodes.REGULAR, 8);//should negate what is added.
            string expected = ("Day: " + test.dateTime + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(1) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(2) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(3) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(4) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(5) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(6) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(7) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(8) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(9) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(10) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(11) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(12) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n" +
                "Day: " + test.dateTime.AddDays(13) + " Reg: " + 0 + " Sick: " + 0 + " Vac: " + 0 + " Total: " + 0 + "\n");//reverts everything back to zero 
            string result = time.ToString();
            Assert.AreEqual(expected, result);
        }
    }
}
