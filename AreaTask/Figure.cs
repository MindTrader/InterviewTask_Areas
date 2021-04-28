using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public abstract class Figure
    {
        public const double MIN_LENGTH = 1e-10;
        public const double CALCULATION_ACCURACY = 1e-10;

        public abstract double GetArea();
    }
}
