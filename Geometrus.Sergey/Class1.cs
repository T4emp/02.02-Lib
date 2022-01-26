using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrus.Sergey
{
    public class Class1
    {
        public static void Plosh()
        {
            Console.WriteLine("Введите сторону квадрата: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine($"Площадь квадрата: {b2*b2}\nОбъем квадрата: {b2*b2*b2}");
        }
        public static void Chislo()
        {
            Console.WriteLine("Введите число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine($"Итог: {(b2*b2*b2)/2}");
        }
    }
}