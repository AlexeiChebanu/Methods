using System;

namespace Methods1
{
    internal class Program
    {

        static void MaxMin(out int MinValue, out int MaxValue, params int[] parameters)//overload int
        {
            MinValue = parameters[0];

            MaxValue = parameters[0];

            for (int i = 0; i < parameters.Length; i++)
                if (parameters[i] < MinValue)
                    MinValue = parameters[i];

            for (int i = 0; i < parameters.Length; i++)
                if (parameters[i] > MaxValue)
                    MaxValue = parameters[i];
        }

        static void MaxMin(out double MinValue, out double MaxValue, params double[] parameters) // overload double
        {
            MinValue = parameters[0];

            MaxValue = parameters[0];

            for (int i = 0; i < parameters.Length; i++)
                if (parameters[i] < MinValue)
                    MinValue = parameters[i];

            for (int i = 0; i < parameters.Length; i++)
                if (parameters[i] > MaxValue)
                    MaxValue = parameters[i];
        }

        static void TrySumIfOdd(int a, int b, out bool EvenOdd) => EvenOdd = (a + b) % 2 == 0 ? true : false;// Is the sum of 2 random nums even or odd?

        static void Repeat(string x, int N)
        {
            string result = "";
            for (int i = 0; i < N; i++)
                result += x;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int MinValue, MaxValue;

            var ran = new Random();

            var a = ran.Next(0, 100);
            var b = ran.Next(0, 100);
            var c = ran.Next(0, 100);
            var d = ran.Next(0, 100);

            MaxMin(out MinValue, out MaxValue, a, b);
            Console.WriteLine($"MinValue is {MinValue}; \tMaxValue is {MaxValue}\nAmong these nums {a},\t {b}");

            MaxMin(out MinValue, out MaxValue, a, b, c);
            Console.WriteLine($"MinValue is {MinValue}; \tMaxValue is {MaxValue}\nAmong these nums {a},\t {b},\t {c}");

            MaxMin(out MinValue, out MaxValue, a, b, c, d);
            Console.WriteLine($"MinValue is {MinValue}; \tMaxValue is {MaxValue}\nAmong these nums {a},\t {b},\t {c},\t {d}");

            double MinValue1, MaxValue1;

            var ran1 = new Random();

            var e = ran1.NextDouble();
            var f = ran1.NextDouble();
            var g = ran1.NextDouble();
            var h = ran1.NextDouble();


            MaxMin(out MinValue1, out MaxValue1, e, f);
            Console.WriteLine($"MinValue is {MinValue1}; \tMaxValue is {MaxValue1}\nAmong these nums {e},\t {f}");

            MaxMin(out MinValue1, out MaxValue1, e, f, g);
            Console.WriteLine($"MinValue is {MinValue1}; \tMaxValue is {MaxValue1}\nAmong these nums {e},\t {f},\t {g}");

            MaxMin(out MinValue1, out MaxValue1, e, f, g, h);
            Console.WriteLine($"MinValue is {MinValue1}; \tMaxValue is {MaxValue1}\nAmong these nums {e},\t {f},\t {g},\t {h}");
//too many whitespaces




            bool EvenOdd = false;

            TrySumIfOdd(a, b, out EvenOdd);
            if (EvenOdd)
                Console.WriteLine($"The sum of those 2 nums({a}, {b}) is Even");
            else
                Console.WriteLine($"The sum of those 2 nums({a}, {b}) is Odd");
//too many whitespaces




            int j;
            Console.WriteLine("How many times do you want the method to run\nInput j: ");
            if (!Int32.TryParse(Console.ReadLine(), out j))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("What is the word do you want to show?");
            string x = Console.ReadLine();
            Repeat(x, j);

        }
    }
}
//checked
