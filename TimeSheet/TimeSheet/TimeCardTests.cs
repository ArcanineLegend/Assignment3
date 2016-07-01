using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class Assert;
    class TimeCardTests
    {
        [TestMethod()]
        TestOverTime()
        {

        }
    }
    public void TestOverTime()
    {
        TimeCardTests t = new TimeCardTests();
        float expected = 44;
        //act
        foreach(Days d in Enum.GetValues(typeof(DayOfWeek)))
        {
            d.Add(Days.type.REGULAR, 12);
        }
        //assert
        Assert.AreEqual(expected,t.CalculateOverTime());

    }
}
