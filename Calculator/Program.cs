using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("это Калькулятор элементарных (простых) действий");
            double a = 0;
            double b = 0;
            double q = 0;

            try
            {
                Console.WriteLine("Введите первое значение");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе значение");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
            }

            Console.WriteLine("Введите код из доступных к выполнению действий: \n1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
            int c = Convert.ToInt32(Console.ReadLine());

            bool f = true;
            if (c == 1)
            {
                q = a + b;
            }
            else if (c == 2)
            {
                q = a - b;
            }
            else if (c == 3)
            {
                q = a * b;
            }

            else if (c == 4 && b != 0)
            {
                q = a / b;
            }

            else if (c == 4 && b == 0)
            {
                Console.WriteLine("Ошибка - деление на ноль!");
                Console.ReadKey();
            }

            else
                f = false;

            if (f == true)
            {
                Console.WriteLine("Результат = {0:f2}", q);
            }
            else
            {
                Console.WriteLine("!Ошибка! Нет такого значения кода");
            }

            Console.ReadKey();
        }
    }
}
