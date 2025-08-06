namespace Question5
{
    public class Program
    {
        //5.	implement a custom list called FixedSizeList<T> with a predetermined capacity. 
    //    This list should not allow more elements than its capacity and should provide 
    //    clear messages if one tries to exceed it or access invalid indices.
    //    Requirements:
    //        1.	Create a generic class named FixedSizeList<T>.
    //        2.	Implement a constructor that takes the fixed capacity of the list as a parameter.
    //        3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
    //        4.Implement a Get method that retrieves an element at a specific index in the list but throws 
    //        an exception for invalid indices.

        static void Main(string[] args)
        {
            char ch;
            bool flage1=false;
            bool flage_add,flage_int, flage_double,flage_float,flage_string;
            string tp="";
            //choose Type
            #region Choose Type
            do
            {
                Console.WriteLine("Please Enter Type Of Elements You Wanted To Add It\n int  ||  float  ||  double  ||  string  ");
                tp = Console.ReadLine();
                if (tp == "int" || tp == "float" || tp == "double" || tp == "string")
                {
                    flage1 = true;
                }
            } while (!flage1);
            //////////////////////// 
            #endregion
            Console.WriteLine("Type Which You Choosed Is : " + tp);
            ///Add Element And TYPE 
            do
            {
                Console.WriteLine("Press Button Add + To Add New Element OR Press Any Key To Finish");
                flage_add = char.TryParse(Console.ReadLine(), out ch);
                //FOR TYPE INTEGER
                #region FOR TYPE INTEGER
                if (ch == '+' && tp == "int")
                {
                    do
                    {
                        Console.WriteLine("Enter Element");
                        flage_int = int.TryParse(Console.ReadLine(), out int a);
                        FixedSizeList<int>.Add_Element(a);
                    } while (!flage_int);
                    flage_add = false;
                }
                else if (tp=="int")
                {
                    flage_add = true;
                    FixedSizeList<int>.Get_Element();
                }
                #endregion
                ///////////////////////////////
                //FOR TYPE float
                #region Type Float
                if (ch == '+' && tp == "float")
                {
                    do
                    {
                        Console.WriteLine("Enter Element");
                        flage_float = float.TryParse(Console.ReadLine(), out float b);
                        FixedSizeList<float>.Add_Element(b);
                    } while (!flage_float);
                    flage_add = false;
                }
                else if (tp == "float")
                {
                    flage_add = true;
                    FixedSizeList<float>.Get_Element();
                }
                #endregion
                ///////////////////////////////

                #region FOR TYPE DOUBLE
                if (ch == '+' && tp == "double")
                {
                    do
                    {
                        Console.WriteLine("Enter Element");
                        flage_double = double.TryParse(Console.ReadLine(), out double c);
                        FixedSizeList<double>.Add_Element(c);
                    } while (!flage_double);
                    flage_add = false;
                }
                else if (tp == "double")
                {
                    flage_add = true;
                    FixedSizeList<double>.Get_Element();
                }
                #endregion

                #region FOR TYPE String
                if (ch == '+' && tp == "string")
                {
                    
                        Console.WriteLine("Enter Element");
                        string d=Console.ReadLine();
                        FixedSizeList<string>.Add_Element(d);
                    
                    flage_add = false;
                }
                else if (tp == "string")
                {
                    flage_add = true;
                    FixedSizeList<string>.Get_Element();
                }
                #endregion

            } while (!flage_add);
            /////////////////////////////////////////
        }
    }
}
