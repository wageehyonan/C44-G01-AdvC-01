using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{           /*
             2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            The range should support basic operations such as checking if a value is within the range and determining 
                the length of the range.
 Requirements:
 1.	Create a generic class named Range<T> where T represents the type of values.
 2.	Implement a constructor that takes the minimum and maximum values to define the range.
 3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
 4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
 5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
                 */
    public class Range<T> where T : IComparable<T>
    {

        #region Variables
        public T minmum;
        private T maxmum;
        private T uservalue;

        #endregion
        #region Properties
        public T Minmum
        {
            get; set;
            // get { return minmum; }
            // set { minmum = value; }

        }
        public T Maxmum
        {
            get { return maxmum; }
            set { maxmum = value; }
        }
        public T UserValue
        {
            get { return uservalue; }
            set { uservalue = value; }

        }
        #endregion
        #region Constructors
        public Range(T minmum, T maxmum)
        {


            this.Minmum = minmum;
            this.Maxmum = maxmum;
        }
        #endregion



        


        #region TosTring
        public override string ToString()
        {
            return $"Minmum Is {Minmum} And Maxmum IS {Maxmum}";
        }
        #endregion

        public static bool IsInRange(T value, T min, T max)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
        public static void Lenght(T min, T max)
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float) || typeof(T) == typeof(decimal))
            {
                dynamic minVal = min;
                dynamic maxVal = max;
                T len = (maxVal - minVal);
                Console.WriteLine("Length is " + len);
            }

        }
    }
}
