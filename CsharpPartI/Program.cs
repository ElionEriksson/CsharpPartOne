using System;
using System.Collections.Generic;

namespace CsharpPartI
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWOrld();
            // Math();
            //MaxMin();
            //Conditions();
            //WhileandDoLoops();
            //SumOfNum();
            //Lists();
            BuildFib();
        }

        static void HelloWOrld()
        {
            Console.WriteLine("Hello World!!");
        }

        static void Math()
        {
            int a = 12;
            int b = 14;
            int sum = a + b;
            int product = a * b;
            float division = a / b;

            string aPrint = Convert.ToString(a);
            string bPrint = Convert.ToString(b);
            string sumPrint = Convert.ToString(sum);
            string productPrint = Convert.ToString(product);
            string divisionPrint = Convert.ToString(division);

            Console.WriteLine(aPrint);
            Console.WriteLine(bPrint);
            Console.WriteLine(sumPrint);
            Console.WriteLine(productPrint);
            Console.WriteLine(divisionPrint);
        }

        static void MaxMin()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");
        }

        static void Conditions()
        {
            //If statement 
            if (14 < 15)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // conditions with and and or && ||
            if (14 > 7 && 14 > 5)
            {
                Console.WriteLine("14 is biggest");
            }
        }

        static void WhileandDoLoops()
        {
            int a = 10;
            while (a > 5)
            {
                Console.WriteLine($"{a} is greater than 5");
                a--;
            };

            Console.WriteLine("This is the do loop");

            int b = 10;
            do
            {
                Console.WriteLine($"{b} is greater than 5");
                b--;
            } while (b > 5);

            Console.WriteLine($"This is the for loop");

            for (int iterator = 0; iterator < 10; iterator++)
            {
                Console.WriteLine($"{iterator} is less than 10");

            }

        }

        static void SumOfNum()
        {
            int sum = 0;
            for (int iterator = 1; iterator <= 20; iterator++)
            {
                if (iterator % 3 == 0)
                {
                    sum = sum + iterator;
                }
            }
            Console.WriteLine($"The sum of numbers between 1 and 20 divdeable by 3 is equal to: {sum}");
        }

        // it's time for collections using generic namespace
        static void Lists()
        {

            var names = new List<string> { "Johan", "Erik", "Kent" };
            //iterare över listan med foreach
            /*
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            } */

            // MOdify Lists
            names.Add("Per-Emil");
            names.Remove("Johan");
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"The list contains {names.Count} names!!");

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            //Sort the lsits in alphabetic order
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        static void BuildFib()
        {
            var fibList = new List<int> { };
            for (int iter = 0; iter < 20; iter++)
            {
                if (fibList.Count < 2)
                {
                    fibList.Add(1);
                }
                else
                {
                    fibList.Add(fibList[iter - 1] + fibList[iter - 2]);
                }
            }
            foreach (var item in fibList)
            {
                Console.WriteLine(item);
            }



        }
    }

}
