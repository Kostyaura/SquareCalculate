using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculate
{
    public abstract class Object
    {
        /// <summary>
        /// Площадь объекта
        /// </summary>
        public double Square => SquareCalc();

        protected abstract double SquareCalc();
    }
}
