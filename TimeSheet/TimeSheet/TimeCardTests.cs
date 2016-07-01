using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class TimeCardTests
    {
bool FirstDay = true;
        [TestMethod]
        
        TestOverTime()
        {

        }
        CollectDayData(bool FirstDay)
        {

        }
    }
    public void TestOverTime()
    {
        TimeCardTests t = new TimeCardTests();
        float expected = 44;
        //act
        foreach (Days.Day d in Enum.GetValues(typeof(DayOfWeek)))
        {
            d.Add(Days.Day.type.REGULAR, 12);
        }
        //assert
        Assert.AreEqual(expected, t.CalculateOverTime());

    }
    public void CollectDayData(bool FirstDay) {
        if (FirstDay == true) {
        if (d.DayOfWeek = "SUNDAY")
        {
            List<Day> DaysArray = new List<Day>();
            DaysArray.add(Day1);//changed according to next day name. Most likely named by the day of the week.
        }

    }
}
}
