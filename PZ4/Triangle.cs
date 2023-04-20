using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    public class Triangle
    {
        public double first { get; set; }
        public double second { get; set; }
        public double third { get; set; }

        public Triangle()
        {

        }

        public Triangle(double f, double s, double t)
        {
            first = f;
            second = s;
            third = t;
        }

        public double GetPerimetr() =>
            first + second + third;
    }
}
