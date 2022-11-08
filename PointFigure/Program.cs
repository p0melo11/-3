using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointFigure
{
    class Program
    {
        public static void Main()
        {
            var figure = new Figure(new Point(2.5, 3.5), new Point(1.1, 1.4), new Point(9.4, 3.1), new Point(1.1, 2.1));

            Console.WriteLine(figure.Name);
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}
