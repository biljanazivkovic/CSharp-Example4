using System;

namespace ex4
{
    class Program
    {
        /* If...Else */
        static void Main(string[] args)
        {
            if(20 > 18) 
            {
                Console.WriteLine("20 is greater than 18");
            }

            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater then y");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int t = 22;
            if (t < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (t < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int newTime = 20;
            string result = (newTime < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
