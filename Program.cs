using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До якого числа рахувати ряд Фібоначчі?");
            int number = Convert.ToInt32(Console.ReadLine());

            int perv = 1;
            Console.Write("{0} ", perv);
            int vtor = 1;
            Console.Write("{0} ", vtor);
            int sum = 0;

            while (number >= sum)
            {
                sum = perv + vtor;

                Console.Write("{0} ", sum);

                perv = vtor;
                vtor = sum;
            }



            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Простые числа из диапазона ({0}, {1})", 0, n);
            for (var i = 0u; i < n; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();

        }


        public static bool IsPrimeNumber(uint n)
        {
            var result = true;
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
        
}
