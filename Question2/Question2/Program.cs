namespace Question2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Range rang = new Range(5,20);
           
           
            Console.WriteLine(Range<int>.IsInRange(11, 5, 20));
            Range<int>.Lenght(5,20);
           
        }
    }
}
