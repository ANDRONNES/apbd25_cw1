﻿using System.Linq;

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
    static void ArraysAvg(int[] a)
    {
        double avg = a.Average();
        Console.WriteLine(avg);
    }
    static void ArraysMax(int[] b)
    {
        int max = b.Max();
        Console.WriteLine(max);
    }

}