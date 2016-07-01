using System;
namespace Timesheet
{
    public class Day
    {
        public enum TimeCodes { REGULAR, SICK, VACATION }

        private DateTime dateTime;

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public float HoursWorked { get; set; }

        public void Add(TimeCodes timeType, float hours)
        {

        }

        public bool Validate()
        {
            return true;
        }
    }
}
