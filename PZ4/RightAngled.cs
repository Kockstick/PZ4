using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    public class RightAngled : Triangle
    {
        public double sqare { get; set; }

        public RightAngled()
        {
            first = 90;
            second = 45;
            third = 30;

            sqare = GetSqare();
        }

        public double GetSqare() =>
            (third * second) / 2;
    }
}
