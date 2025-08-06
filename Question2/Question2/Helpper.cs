using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public static class Helpper<T> where T : IComparable<T>
    {
        public static bool  IsInRange(T value,T min, T max)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
    }
}
