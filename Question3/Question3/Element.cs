using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public  class Element <T>
        {

        #region Parameters
        private T elem;
        #endregion
        #region Properits
        public T Elem
        {
            get { return elem; }
            set { elem = value; }
        }

        #endregion
        #region Constructors
        public Element(T el)
        { this.elem = el; }
        #endregion


        #region ToString
        public override string ToString()
        {
            return $"Element IS {Elem}";
        }
        #endregion

        public static void Reverse_Element(T []arr)
        {
            for (int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine($"Element Number {i} IS {arr[i]}");
            }
        }
    }
}
