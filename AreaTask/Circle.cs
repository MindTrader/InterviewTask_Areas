using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public class Circle : Figure
    {
        public double R { get; }

        public Circle(double radius)
        {
            if (radius < MIN_LENGTH)
                throw new ArgumentException($"Некорректное значение: {nameof(radius)}. Минимальное значение: {MIN_LENGTH}");

            R = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
