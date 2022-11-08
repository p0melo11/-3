using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private double side1;
        private double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        double PerimeterCalculator()
        {
            return 2 * (this.side1 + this.side2);
        }
        public double Area
        {
            get { return this.AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }
    }
}