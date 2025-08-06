using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public static class FixedSizeList<T>
    {
       private static T[] fix_list=new T[5];
        private static int fix_length=5;
        private static int i = 0;
        public static T Fix_List
        {
            get;
            set;
        }
        public static void Add_Element(T elem)
        {if (i != fix_length)
            {
                fix_list[i] = elem;
                i++;
            }
        else
            {
                Console.WriteLine("Sorry ,List IS Full ");
            }
        }

        public static void Get_Element()
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Element NUM " + j + " is " + fix_list[j]);
            }
        }

    }
}
