using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }


        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < MIN_LENGTH)
                throw new ArgumentException($"Некорректное значение стороны: {nameof(sideA)}. Минимальное значение: {MIN_LENGTH}");

            if (sideB < MIN_LENGTH)
                throw new ArgumentException($"Некорректное значение стороны: {nameof(sideB)}. Минимальное значение: {MIN_LENGTH}");

            if (sideC < MIN_LENGTH)
                throw new ArgumentException($"Некорректное значение стороны: {nameof(sideC)}. Минимальное значение: {MIN_LENGTH}");

            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if ((sideA + sideB + sideC - maxSide) - maxSide <= 0d)
                throw new ArgumentException($"Каждая сторона треугольника должна быть меньше суммы двух других его сторон!");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2d; //полупериметр

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRectangular()
        {
            double maxSide = SideA, b = SideB, c = SideC;

            if (b - maxSide > CALCULATION_ACCURACY)
                Utils.Swap(ref maxSide, ref b);

            if (c - maxSide > CALCULATION_ACCURACY)
                Utils.Swap(ref maxSide, ref c);

            return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) <= CALCULATION_ACCURACY;
        }
    }
}
