using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube.Calculations
{
    /// <summary>
    /// Specific implementations of ICalculator (IntCalculator, DecimalCalculator, DoubleCalculator, FloatCalculator) allows to do the basic operations on unconstrained Template (T) type.
    /// Its needed for generic numerics (int, float, decimal, dobule) as they do not implement any interface that define the arithmetic operators and that can be used as a constraint for T types (without constraint treated as object) [bummer].
    /// </summary>
    /// <remarks>Implementations of the interface has only the methods and props used in the example.</remarks>
    public interface ICalculator<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mul(T[] a);
        T Div2(T a);
        bool Lt0(T a);
        T MinValue { get; }
        T Abs(T a);
        bool Contains(T a1, T b1, T a2, T b2);
    }

    public class IntCalculator : ICalculator<int>
    {
        public int Add(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mul(int[] a) { return a.Aggregate((j, k) => j * k); }
        public int Div2(int a) { return a / 2; }
        public bool Lt0(int a) { return a < 0; }
        public int Abs(int a) { return Math.Abs(a); }
        public int MinValue { get { return int.MinValue; } }
        /// <summary>
        /// Check if the range from a1 to b1 contains range from a2 to b2
        /// </summary>
        public bool Contains(int a1, int b1, int a2, int b2)
        {
            return a1 <= b1 && a1 <= a2 && a2 <= b2 && b1 >= b2;
        }
    }

    public class DecimalCalculator : ICalculator<decimal>
    {
        public decimal Add(decimal a, decimal b) { return a + b; }
        public decimal Sub(decimal a, decimal b) { return a - b; }
        public decimal Mul(decimal[] a) { return a.Aggregate((j, k) => j * k); }
        public decimal Div2(decimal a) { return a / 2; }
        public bool Lt0(decimal a) { return a < 0; }
        public decimal Abs(decimal a) { return Math.Abs(a); }
        public decimal MinValue { get { return decimal.MinValue; } }
        /// <summary>
        /// Check if the range from a1 to b1 contains range from a2 to b2
        /// </summary>
        public bool Contains(decimal a1, decimal b1, decimal a2, decimal b2)
        {
            return a1 <= b1 && a1 <= a2 && a2 <= b2 && b1 >= b2;
        }
    }

    public class DoubleCalculator : ICalculator<double>
    {
        public double Add(double a, double b) { return a + b; }
        public double Sub(double a, double b) { return a - b; }
        public double Mul(double[] a) { return a.Aggregate((j, k) => j * k); }
        public double Div2(double a) { return a / 2; }
        public bool Lt0(double a) { return a < 0; }
        public double Abs(double a) { return Math.Abs(a); }
        public double MinValue { get { return double.MinValue; } }
        /// <summary>
        /// Check if the range from a1 to b1 contains range from a2 to b2
        /// </summary>
        public bool Contains(double a1, double b1, double a2, double b2)
        {
            return a1 <= b1 && a1 <= a2 && a2 <= b2 && b1 >= b2;
        }
    }

    public class FloatCalculator : ICalculator<float>
    {
        public float Add(float a, float b) { return a + b; }
        public float Sub(float a, float b) { return a - b; }
        public float Mul(float[] a) { return a.Aggregate((j, k) => j * k); }
        public float Div2(float a) { return a / 2; }
        public bool Lt0(float a) { return a < 0; }
        public float Abs(float a) { return Math.Abs(a); }
        public float MinValue { get { return float.MinValue; } }
        /// <summary>
        /// Check if the range from a1 to b1 contains range from a2 to b2
        /// </summary>
        public bool Contains(float a1, float b1, float a2, float b2)
        {
            return a1 <= b1 && a1 <= a2 && a2 <= b2 && b1 >= b2;
        }
    }
}
