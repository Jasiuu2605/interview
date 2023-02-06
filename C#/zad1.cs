using System;

class Zad1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

        Array.Reverse(arr);

        Console.WriteLine(string.Join(" ", arr));
    }
}
