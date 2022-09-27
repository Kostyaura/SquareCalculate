using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculate
{
    public class Triangle : Object
    {
        private double _sideFirst;
        private double _sideSecond;
        private double _sideThird;

        public bool isTriangleRight = false;

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="_sideFirst">Сторона 1</param>
        /// <param name="_sideSecond">Сторона 2</param>
        /// <param name="_sideThird">Сторона 3</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение или 0</exception>
        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            if (sideFirst <= 0 || sideSecond <= 0 || sideThird <= 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной или 0");

            _sideFirst = sideFirst;
            _sideSecond = sideSecond;
            _sideThird = sideThird;
        }

        /// <summary>
        /// Проверка на прямоугольный треугольник
        /// </summary>
        public bool TriangleRight()
        {
            List<double> listSides = new List<double> { _sideFirst, _sideSecond, _sideThird };
            var maxSidePow = Math.Pow(listSides.Max(), 2);
            if (2 * maxSidePow == Math.Pow(_sideFirst, 2) + Math.Pow(_sideSecond, 2) + Math.Pow(_sideThird, 2))
                return true;
            return false;
        }

        protected override double SquareCalc()
        {
            //прямоугольные треугольники
            if (_sideFirst * _sideFirst + _sideSecond * _sideSecond == _sideThird * _sideThird)
            {
                isTriangleRight = true;
                return _sideFirst * _sideSecond / 2;
            }
            else if (_sideFirst * _sideFirst + _sideThird * _sideThird == _sideSecond * _sideSecond)
            {
                isTriangleRight = true;
                return _sideFirst * _sideThird / 2;
            }
            else if (_sideThird * _sideThird + _sideSecond * _sideSecond == _sideFirst * _sideFirst)
            {
                isTriangleRight = true;
                return _sideThird * _sideSecond / 2;
            }

            //равносторонный треугольник
            else if (_sideFirst == _sideSecond && _sideFirst == _sideThird)
            {
                return Math.Sqrt(3) * Math.Pow(_sideFirst, 2) / 4;
            }

            //остальные треугольники
            else
            {
                double p = (_sideFirst + _sideSecond + _sideThird) / 2;

                return Math.Sqrt(p * (p - _sideFirst) * (p - _sideSecond) * (p - _sideThird));
            }
        }
    }
}
