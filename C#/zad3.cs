using System;
using System.Linq;

class Zad3
{
    static void Main(string[] args)
    {
        int[] firstArray = new int[11];
        int[] secondArray = new int[11];

        // Read first array
        for (int i = 0; i < 11; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        // Read second array
        for (int i = 0; i < 11; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // Sort both arrays
        Array.Sort(firstArray);
        Array.Sort(secondArray);

        // Compare both arrays
        if (firstArray.SequenceEqual(secondArray))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
