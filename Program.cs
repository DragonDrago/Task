using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task("17");
        }

        static void Task( string input)
        {
            int numericValue;
            bool isNumber = int.TryParse(input, out numericValue);
            if (isNumber)
            {
                int intNum = Convert.ToInt32(input);
                if (IsPrimeOrNot(intNum))
                {
                    if (IsMersenne(intNum))
                    {
                        Console.WriteLine("It is a Mersenne Number");
                    }
                    else
                    {
                        Console.WriteLine("It is a regular prime number");
                    }
                }
                if (!IsPrimeOrNot(intNum))
                {
                    Console.WriteLine("It is not a prime");
                }
            }
            else
            {
                if (input == "quit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
        }

        public static bool IsPrimeOrNot(int num)
        {
            for(int i = 2;  i < num; i++)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMersenne(int number)
        {
            return Math.Log(number + 1, 2) % 1 == 0 || Math.Log(number - 1, 2) % 1 == 0;
        }
    }
}
