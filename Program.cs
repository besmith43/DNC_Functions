using System;

namespace DNC_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;

            int num3 = add(num1, num2);

            Console.WriteLine($"The total is {num3}");

            int answer = getUserChoice();

            Console.WriteLine($"You chose {answer}");
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int getUserChoice()
        {
            int choice;

            Console.WriteLine("Pick a number between 1 and 10");
            string user_input = Console.ReadLine();

            try
            {
                choice = Int32.Parse(user_input);
            }
            catch
            {
                choice = 0;
            }

            return choice;
        }
    }
}
