using System;

namespace Days
{

    public class Days
    {
        public float TotalHours = 0;
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

        public Days(DateTime dateTime)
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

        public void Add(type TypeChoice, float hours)//change to set so its changaable.
        {
            if (HoursTest() <= (float)24)
            {


                TotalHours += hours;
                if (TypeChoice == type.REGULAR)
                {
                    RegHours += hours;
                    HoursArray[0] = RegHours;
                }
                else if (TypeChoice == type.SICK)
                {
                    SickHours += hours;
                    HoursArray[1] = SickHours;
                }
                else if (TypeChoice == type.VACATION)
                {
                    VacHours += hours;
                    HoursArray[2] = VacHours;
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