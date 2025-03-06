using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!!");
        Console.WriteLine("Hello, World!!!");
        Console.WriteLine("Hello, World!!!!");
        Console.WriteLine("Hello, World!!!!!");
        Console.WriteLine("Hello, World!!!!!!");
        Console.WriteLine("Hello, World!!!!!!!");
        Console.WriteLine("Hello, World!!!!!!!!");
        int[] ar = [1, 2, 3, 4, 5];
        ArraysAvg(ar);
}
    static void ArraysAvg(int[] ar1)
    {
        double avg = ar1.Average();
        Console.Write(avg);
    }

}