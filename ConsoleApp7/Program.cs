using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a number in US currency: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Second number in US currency: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Third number in US currency: ");
            double value3 = double.Parse(Console.ReadLine());

            double total = value1 + value2 + value3;
            double swedishTotal = total * 9.84893;
            double japanTotal = total * 106.31;
            double thaiTotal = total * 30.65;

            double average = total / 3;

            if (value1 > value2 && value1 > value3)
            {
                Console.WriteLine("The Lagest Number is $" + Math.Round(value1, 2));
            }
            else if (value2 > value1 && value2 > value3)
            {
                Console.WriteLine("The Lagest Number is $" + Math.Round(value2, 2));
            }
            else
            {
                Console.WriteLine("The Lagest Number is $" + Math.Round(value3, 2));
            }

            if (value1 < value2 && value1 < value3)
            {
                Console.WriteLine("The Smallest Number is $" + Math.Round(value1, 2));
            }
            else if (value2 < value1 && value2 < value3)
            {
                Console.WriteLine("The Smallest Number is $" + Math.Round(value2, 2));
            }
            else
            {
                Console.WriteLine("The Smallest Number is $" + Math.Round(value3, 2));
            }

            Console.WriteLine("Average = $ " + Math.Round(average, 2));
            Console.WriteLine("Totals");
            Console.WriteLine("US: $" + Math.Round(total, 2));
            Console.WriteLine("Swedish:" + Math.Round(swedishTotal, 2) + " kr");
            Console.WriteLine("Japanese: ¥" + Math.Round(japanTotal, 0));
            Console.WriteLine("Thai: ฿" + Math.Round(thaiTotal, 2));
            Console.ReadLine();

        }





    }
}
