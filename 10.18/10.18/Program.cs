using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_цифр
{
    class Program
    {
        static int getSum(int a)
        {
            int suma = 0;
            do
            {
                suma += a % 10;
                a /= 10;
            }
            while ((a % 10) != 0);
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            if (getSum(a) > getSum(b))
                Console.WriteLine("Сумма цифр первого больше");

            if (getSum(a) < getSum(b))
                Console.WriteLine("Сумма цифр второго больше");

            if (getSum(a) == getSum(b))
                Console.WriteLine("Сумма цифр одинакова");

            Console.ReadLine();
        }
    }
}