using System;

namespace TimeSheet
{

    public class Day
    {
        public float Total = 0;
        public float RegHours = 0;
        public float SickHours = 0;
        public float VacHours = 0;
        public enum type { SICK, VACATION, REGULAR }
        public DateTime Date { get; set; }
        public float HoursWorked { get; set; }
        public string HoursType { get; set; }
        public float hours = 8;
        public type value = type.REGULAR;
        public DateTime dateTime;

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public type TypeTest()
        {
            return value;
        }
        public float HoursTest()
        {
            return hours;
        }
        float[] HoursArray;

        public void Add(type TypeChoice, float hours)
        {
            if (HoursTest <= 24)
            {


                TotalHours += hours;
                if (TypeChoice == type.REGULAR)
                {
                    RegHours += hours;
                }
                else if (TypeChoice == type.SICK)
                {
                    SickHours += hours;
                }
                else if (TypeChoice == type.VACATION)
                {
                    VacHours += hours;
                }
            }
        }
        public bool Validate()
        {
            if (TotalHours <= 24 && TotalHours > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

