using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cube.Calculations;

namespace Cube
{
    /// <summary>
    /// Manages all the intersection operations ;)
    /// </summary>
    public class IntersectionManager<T>
    {
        private ICalculator<T> _calc;

        public IntersectionManager(ICalculator<T> calc)
        {
            _calc = calc;
        }
        /// <summary>
        /// Gets the volume of the intersection fo two cubes.
        /// </summary>
        /// <param name="s1">Size of the first cube.</param>
        /// <param name="x1">Center X coord of the first cube.</param>
        /// <param name="y1">Center Y coord of the first cube.</param>
        /// <param name="z1">Center Z coord of the first cube.</param>
        /// <param name="s2">Size of the second cube.</param>
        /// <param name="x2">Center X coord of the second cube.</param>
        /// <param name="y2">Center Y coord of the second cube.</param>
        /// <param name="z2">Center Z coord of the second cube.</param>
        /// <returns>Value of the volume of the intersection. If not intersected returns MinValue of the given numeric type.</returns>
        public T GetIntersectionVolumeOfCubes(T s1, T x1, T y1, T z1, T s2, T x2, T y2, T z2)
        {
            return GetIntersectionVolumeOfCubes(new Cube<T>(x1, y1, z1, s1, _calc), new Cube<T>(x2, y2, z2, s2, _calc));
        }

        private T GetIntersectionVolumeOfCubes(ICube<T> c1, ICube<T> c2)
        {
            return c1.IntersectionVolumeWith(c2);
        }
    }
}
