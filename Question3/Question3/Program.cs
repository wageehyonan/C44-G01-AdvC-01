namespace Question3
{
    internal class Program
    {/*
     1.	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList
        in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as
        input and modifies it to have the reversed order of elements. 
      */
        static void Main(string[] args)
        {
            Element<int> elm1 = new Element<int>(5);
            Console.WriteLine(elm1);

            Element<string> elm2 = new Element<string>("Test String Type");
            Console.WriteLine(elm2);

            Element<int>[] arr_el ={new Element<int>(5),
                                   new Element<int>(6),
                                   new Element<int>(7),
                                   new Element<int>(8),
                                   new Element<int>(9),
                                   new Element<int>(10),
                                   };
           
            int[] arr_ele = { 5, 6, 7, 8, 9, 10 };
            Element<int>.Reverse_Element(arr_ele);


        }
}
}
