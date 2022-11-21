using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());           
            double lenght=Circle.GetLenght(r);
            double square=Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности равна: {lenght}\nПлощадь круга равна: {square}");
            Console.Write("Введите координаты центра круга:\nxО=");
            double ox = Convert.ToDouble(Console.ReadLine());
            Console.Write("yО=");
            double oy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты точки:\nx=");
            double mx = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double my = Convert.ToDouble(Console.ReadLine());
            double point = Circle.GetPoint(ox, oy, mx, my);
            if (point <= r)
                Console.WriteLine("Точка принадлежит кругу!");
            else
                Console.WriteLine("Точка не принадлежит кругу!");
            Console.ReadKey();
        }
    }
}
