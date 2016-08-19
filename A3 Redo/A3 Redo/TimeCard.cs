using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Redo
{
    public class TimeCard
    {

        Day[] days = new Day[14];
        
     
        public TimeCard(DateTime startDate)
        {
            for(int i = 0; i <= days.Length - 1; i++)
            {

                 days[i] = new Day(startDate.AddDays(i));
            }
        }
    }
}
