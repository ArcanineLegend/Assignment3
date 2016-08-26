using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Redo
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("What year are you in!");
            int Year = PromptForInt();
            Console.WriteLine("What Month now?");
            int Month = PromptForInt();
            Console.WriteLine("What day?");
            int day = PromptForInt();
            DateTime daytime = new DateTime(Year, Month, day);
            TimeCard c = new TimeCard(daytime);
            bool finished = false;
            while(!finished){
                Console.WriteLine("Would you like to add(press 1) or remove(press 2) exit(press 0)");
                int choice = PromptForIntInRange(0, 2);
                if (choice == 1)
                {
                    Console.WriteLine("Yo boi what day would you like to modifiiii!");
                    int addDay = PromptForIntInRange(1, 14);
                    Console.WriteLine("Regular: 1, Sick: 2, Vacation: 3");
                    choice = PromptForIntInRange(1, 3);
                    Day.TimeCodes timCody = Day.TimeCodes.REGULAR;
                    switch (choice)
                    {
                        case 1:
                            timCody = Day.TimeCodes.REGULAR;
                            break;
                        case 2:
                            timCody = Day.TimeCodes.SICK;
                            break;
                        case 3:
                            timCody = Day.TimeCodes.VACATION;
                            break;
                    }
                    Console.WriteLine("Yess thats good I think now give me how many hours m8..yes");
                    float amount = PromptForFloat();
                    c.AddHour((addDay - 1), timCody, amount);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Yo boi what day would you like to modifiiii!");
                    int removeDay = PromptForIntInRange(1, 14);
                    Console.WriteLine("Regular: 1, Sick: 2, Vacation: 3");
                    choice = PromptForIntInRange(1, 3);
                    Day.TimeCodes timCody = Day.TimeCodes.REGULAR;
                    switch (choice)
                    {
                        case 1:
                            timCody = Day.TimeCodes.REGULAR;
                            break;
                        case 2:
                            timCody = Day.TimeCodes.SICK;
                            break;
                        case 3:
                            timCody = Day.TimeCodes.VACATION;
                            break;
                    }
                    Console.WriteLine("Yess thats good I think now give me how many removed hours m8..yes");
                    float amount = PromptForFloat();
                    c.RemoveHours((removeDay - 1), timCody, amount);
                }
                else if (choice == 0)
                {
                    finished = true;
                }

                Console.WriteLine(c);
                Console.ReadLine();
            }
            
        }
        public static int PromptForInt()
        {
            int prompted = 0;
            string input = "";
            bool works = false;
            while(!works)
            {
                try
                {
                    input = Console.ReadLine();
                    prompted = Int32.Parse(input);
                    works = true;
                }
                catch
                {
                    Console.WriteLine("Umm... maybe you should input a number?????????");
                }
            }
            return prompted;
        }
        public static int PromptForIntInRange(int min, int max)
        {
            int choice = PromptForInt();
            while (choice < min || choice > max)
            {
                choice = PromptForInt();
                Console.WriteLine("Hey dud you brok me, pls keep it between " + min + " and " + max);
            }
            return choice;
        }
        public static float PromptForFloat()
        {
            float prompted = 0;
            string input = "";
            bool works = false;
            while (!works)
            {
                try
                {
                    input = Console.ReadLine();
                    prompted = float.Parse(input);
                    works = true;
                }
                catch
                {
                    Console.WriteLine("Umm... maybe you should input a number?????????");
                }
            }
            return prompted;
        }
    }
}
