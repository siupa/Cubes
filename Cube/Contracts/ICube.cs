using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    interface ICube<T>
    {
        Vertex<T> Center { get; set; }
        T Size { get; set; }
        T IntersectionVolumeWith(ICube<T> other);
    }
}
