using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timesheet;

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
