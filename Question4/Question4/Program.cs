using System.Collections.Generic;

namespace Question4
{
    internal class Program
    {
       //4.	You are given a list of integers.Your task is to find and return a 
       //     new list containing only the even numbers from the given list.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Helpper.NewList_Even(arr);
        }
    }
}
