using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class TimeCardTests
    {
        [TestMethod]
        TestOverTime()
        {

        }
    }
    public void TestOverTime()
    {
        TimeCardTests t = new TimeCardTests();
        float expected = 44;
        //act
        foreach(Days.Day d in Enum.GetValues(typeof(DayOfWeek)))
        {
            d.Add(Days.Day.type.REGULAR, 12);
        }
        //assert
        Assert.AreEqual(expected,t.CalculateOverTime());

    }
}
