
using System;
using System.Linq;
using System.Globalization;

namespace AbsoluteUnit1
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal decValA = 0;
            decimal decValB = 0;
            decimal decValC = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("Enter a number & press Enter: ");
                string inputA = Console.ReadLine();
                if (decimal.TryParse(inputA, out decValA))
                {
                    decValA = Math.Round(decValA, 2);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Not a number. Try again.");
                }

                Console.WriteLine("Enter a number & press Enter again: ");
                string inputB = Console.ReadLine();
                if (decimal.TryParse(inputB, out decValB))
                {
                    decValB = Math.Round(decValB, 2);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Not a number. Try again.");
                }
                Console.WriteLine("Enter a number & press Enter one more time, I swear: ");
                string inputC = Console.ReadLine();
                if (decimal.TryParse(inputC, out decValC))
                {
                    decValC = Math.Round(decValC, 2);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Not a number. Try again.");
                }
            }

            decimal total = decValA + decValB + decValC;
            decimal average = Math.Round((total / 3), 2);

            Console.WriteLine("The average is: " + average);


            decimal[] array1 = { decValA, decValB, decValC };
            Console.WriteLine("The highest number is: " + (array1.Max()));
            Console.WriteLine("The lowest number is: " + (array1.Min()));


            Console.WriteLine(total.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(total.ToString("C", new CultureInfo("da-DK")));

            Console.WriteLine(total.ToString("C", new CultureInfo("ja-jp")));

            Console.WriteLine(total.ToString("C", new CultureInfo("th-TH")));
        }
    }
}