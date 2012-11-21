using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cube.Calculations;

namespace Cube
{
    class Cube<T> : ICube<T>
    {
        private Vertex<T> _center;
        private T _size;
        private ICalculator<T> _calc;

        public Vertex<T> Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public T Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        /// Calculates the intersection volume with other cube. If equals to MinValue then cubes do not intersect.
        /// </summary>
        /// <param name="other">Cube to check the intersection with.</param>
        /// <returns>Volume of the intersection or MinValue if not.</returns>
        public T IntersectionVolumeWith(ICube<T> other)
        {
            T x3 = CalculateOverlapOnSingleAxis(this.Center.X, this.Size, other.Center.X, other.Size);
            T y3 = CalculateOverlapOnSingleAxis(this.Center.Y, this.Size, other.Center.Y, other.Size);
            T z3 = CalculateOverlapOnSingleAxis(this.Center.Z, this.Size, other.Center.Z, other.Size);
            if (_calc.Lt0(x3) || _calc.Lt0(y3) || _calc.Lt0(z3))
                return _calc.MinValue;
            return _calc.Mul(new T[] { x3, y3, z3 });
        }

        /// <summary>
        /// Calculates the overlap of the cubes on single axis having one of the center coordinates and size.
        /// </summary>
        private T CalculateOverlapOnSingleAxis(T centerCoord1, T size1, T centerCoord2, T size2)
        {
            // basically there are two cases, when on a single axis one cube overlap entirelly the second one and when not :)
            // not really a rocket science :)

            T sDiff = _calc.Div2(_calc.Add(size1, size2));
            T xLeft1 = _calc.Sub(centerCoord1, _calc.Div2(size1));
            T xRight1 = _calc.Add(centerCoord1, _calc.Div2(size1));
            T xLeft2 = _calc.Sub(centerCoord2, _calc.Div2(size2));
            T xRight2 = _calc.Add(centerCoord2, _calc.Div2(size2));
            // first one overlap second
            if (_calc.Contains(xLeft1, xRight1, xLeft2, xRight2))
                return size2;
            // second overlap first
            else if (_calc.Contains(xLeft2, xRight2, xLeft1, xRight1))
                return size1;
            // they overlap partially or not at all
            else
            {
                T xDist = _calc.Abs(_calc.Sub(centerCoord1, centerCoord2));
                return _calc.Sub(sDiff, xDist);
            }
        }

        public Cube(T x, T y, T z, T size, ICalculator<T> calc)
        {
            _center = new Vertex<T>(x, y, z);
            _size = size;
            _calc = calc;
        }
    }
}
