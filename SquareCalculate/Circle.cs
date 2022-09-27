using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculate
{
    public class Circle : Object
    {
        private double _radius;

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="_radius">Радиус</param>
        /// <exception cref="ArgumentOutOfRangeException">Радиус не может быть отрицательным или 0</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Не может быть отрицательным");

            _radius = radius;
        }

        protected override double SquareCalc()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
