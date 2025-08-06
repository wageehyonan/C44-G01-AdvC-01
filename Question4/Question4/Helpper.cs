using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public static class Helpper
    {
        public static void NewList_Even(int[] arr)
        {
            Console.WriteLine("Even Numbers are :");
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i]%2) == 0)
                {
                    Console.WriteLine(arr[i]+"\n");
                }
            }
        }
    }
}
