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
        ArraysMax(ar);
}
    static void ArraysAvg(int[] ar)
    {
        double avg = ar.Average();
        Console.WriteLine(avg);
    }
    static void ArraysMax(int[] ar13)
    {
        int max = ar13.Max();
        Console.WriteLine(max);
    }

}