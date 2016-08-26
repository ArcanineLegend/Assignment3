
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Redo
{
    public class Day
    {
        public float regularHours = 0;
        public float sickHours = 0;
        public float vacationHours = 0;
        public float totalHours = 0;
        public enum TimeCodes { REGULAR, SICK, VACATION }

        public DateTime dateTime { get; private set; }

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public float HoursWorked { get; set; }

        public void Add(TimeCodes timeType, float hours)
        {
            if (hours < 0)
            {
                Console.WriteLine("Hours cannot be under 0 while adding!!!");
                return;
            }
            hours = ((int)(hours / 0.25f)) * 0.25f;

                switch (timeType)
                {
                    case TimeCodes.REGULAR:
                        if ((regularHours + hours) > 24)
                        {
                            return;
                        }
                        regularHours += hours;
                        break;
                    case TimeCodes.SICK:
                        if ((sickHours + hours) > 24)
                        {
                            return;
                        }
                        sickHours += hours;
                        break;
                    case TimeCodes.VACATION:
                        if ((vacationHours + hours) > 24)
                        {
                            return;
                        }
                        vacationHours += hours;
                    break;
                 }
            totalHours += hours;
        }
        public void Remove(TimeCodes timeType, float hours)
        {
                if (hours < 0)
                {
                    return;
                }
                switch (timeType)
                {
                    case TimeCodes.REGULAR:
                    if (((regularHours + hours) > 24) && (((regularHours - hours) < 0)))
                    {
                        return;
                    }
                    regularHours -= hours;
                    break;
                    case TimeCodes.SICK:
                    if (((regularHours + hours) > 24) && (((regularHours - hours) < 0)))
                    {
                        return;
                    }
                    sickHours -= hours;
                    break;
                    case TimeCodes.VACATION:
                    if (((regularHours + hours) > 24) && (((regularHours - hours) < 0)))
                    {
                        return;
                    }
                    vacationHours -= hours;
                    break;
                }
            totalHours -= hours;
        }
        public override string ToString()
        {

            string input = "";
            input += "Day: " + dateTime + " Reg: " + regularHours + " Sick: " + sickHours + " Vac: " + vacationHours + " Total: " + totalHours;
            return input;
        }
    }
}
