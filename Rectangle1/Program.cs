using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Перша сторона");
            var side1 = Console.ReadLine();

            Console.WriteLine("Друга сторона");
            var side2 = Console.ReadLine();

            var rectangle = new Rectangle(double.Parse(side1), double.Parse(side2));

            Console.WriteLine($"Площа: {rectangle.Area}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");
        }
    }
}
