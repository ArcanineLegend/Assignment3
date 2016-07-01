using System;

namespace TimeSheetTests
{
    [TestClass]
    public class DayTests
    {
        [TestMethod]
        public void TestDayRegular()
        {
            /*
             * Done***How do I enter time for a day
             *
             * Pass(Testing stuff that's supposed to succeed)
             * Done***Simplest is 8 hours regular
             * 8 hours sick ive been sick allll quarterrrr
             * 24 hours regular nonee.
             * 
             * Fail(Testing stuff that's supposed to fail)
             * -1 hours regular, 0 fails too
             * 21 hours regular and 5 hours sick
             * 
             */

            //arrange
            Day d = new Day(new DateTime(2016, 5, 28));

            //act
            d.Add(Day.type.REGULAR, 8);

            //assert
            Assert.IsTrue(d.Validate());
        }
        [TestMethod]
        public void TestDaySick()
        {
            //arrange
            Day d = new Day(new DateTime(2016, 5, 28));

            //act
            d.Add(Day.type.SICK, 24);

            //assert
            Assert.IsTrue(d.Validate());
        }
        [TestMethod]
        public void TestDayOver25()
        {
            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.Add(Day.type.REGULAR, 21);
            d.Add(Day.type.SICK, 5);

            //assert
            Assert.IsFalse(d.Validate());
        }
        [TestMethod]
        public void TestBelow0()
        {
            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            try
            {
                d.Add(Day.type.REGULAR, -1);
            } catch(ArgumentOutOfRangeException e)
            {
                Assert.IsInstanceOfType(e, typeof(ArgumentOutOfRangeException));
            }

            

            //assert
            Assert.IsTrue(d.Validate());
        }
        [TestMethod]
        public void Test0()
        {
            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.Add(Day.type.REGULAR, 0);

            //assert
            Assert.IsTrue(d.Validate());
        }
    }
}
