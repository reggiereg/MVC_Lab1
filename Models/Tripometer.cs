using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab.Models
{
    public class Tripometer
    {
        public int MPG { get; set; }
        public int Gallons { get; set; }
        public int TripDistance { get; set; }
        public int Range { get; set; }

        public Tripometer(int mpg, int gallons)
        {
            MPG = mpg;
            Gallons = gallons;
        }

        public double SetRange(int mpg, int gallons)
        {
            Range = mpg * gallons;
            return Range;
        }

    }
}
