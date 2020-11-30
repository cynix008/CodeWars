using System;
using System.Runtime.CompilerServices;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "Skippy";
            //Console.Write($"Maskify {input}  { Maskify(input) }");
            var numbers = new int[] {1, 7, 3, 10, 6, 8};
            int target = 10;
            var result  = TwoSums.GetTwoNumbers(numbers, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }

        public static string Maskify(string cc)
        {
            if (cc.Length <= 4 || string.IsNullOrEmpty(cc))
            {
                return cc;
            }

            var length = cc.Length;
            var maskedString = string.Empty;
            for (int i = 0; i < length; i++)
            {
                maskedString += (i < length - 4) ? "#" : cc[i].ToString();
            }

            return maskedString;
        }

    }
}
