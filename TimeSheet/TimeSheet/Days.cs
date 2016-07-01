using System;

namespace Days
{

    public class Day
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

        public void Set(type TypeChoice, float hours)//change to set so its changaable.
        {
            if ((hours % .25) == 0) //simple check for the .25 increment requirment.
            {


                if (HoursTest() <= (float)24)
                {


                    TotalHours += hours;
                    if (TypeChoice == type.REGULAR)
                    {
                        RegHours = hours;
                        HoursArray[0] = RegHours;
                    }
                    else if (TypeChoice == type.SICK)
                    {
                        SickHours = hours;
                        HoursArray[1] = SickHours;
                    }
                    else if (TypeChoice == type.VACATION)
                    {
                        VacHours = hours;
                        HoursArray[2] = VacHours;
                    }
                }
            }
        }
       /* public void Commit()
        {
            List<Day> DaysArray = new List<Day>();
            DaysArray.add(Day);

        }
       */
       //moved to the TimeCardTests since thats the logical place to put it.
        public void Remove(type TypeChoice, float hours)//unnessasary if we just have one Set method that does all the requirments at once.
        {
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