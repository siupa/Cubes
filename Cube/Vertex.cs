using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class Vertex<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
        public Vertex(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
