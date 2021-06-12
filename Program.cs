using System;

namespace InputANumberFromUserCheckIfTheNumberIsOddOrEven
{
    class Program
    {
        static void Main()
        {
            int number, reminder;
            Console.WriteLine("Please enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            reminder = number % 2;

            if (reminder == 0)
                Console.WriteLine("{0} is an Even Number", number);
            else
                Console.WriteLine("{0} is an Odd Number", number);
            Console.ReadLine();
        }
    }
}
