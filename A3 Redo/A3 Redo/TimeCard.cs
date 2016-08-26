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
            while(DayOfWeek.Sunday != startDate.DayOfWeek)
            {
                startDate = startDate.AddDays(-1.0);
            }
            for(int i = 0; i <= days.Length - 1; i++)
            {
                 days[i] = new Day(startDate.AddDays(i));
            }
        }
        public void AddHour(int day, Day.TimeCodes type, float hours)
        {
            days[day].Add(type, hours);
        }
        public void RemoveHours(int day, Day.TimeCodes type, float hours)
        {
            days[day].Remove(type, hours);
        }
        public override string ToString()
        {
            string input = "";
            for(int i = 0; i < 14; i++)
            {
                input += days[i].ToString();
                input += "\n";
            }
            
            return input;
        }
    }
}
