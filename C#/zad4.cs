using System;
using System.Collections.Generic;

class Zad4
{
    static void Main(string[] args)
    {
        HashSet<int> powersOfTwo = new HashSet<int>();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == null)
                break;
            int num = int.Parse(line);
            int i = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                    powersOfTwo.Add((int)Math.Pow(2, i));
                num >>= 1;
                i++;
            }
        }

        if (powersOfTwo.Count > 0)
        {
            List<int> sortedPowersOfTwo = new List<int>(powersOfTwo);
            sortedPowersOfTwo.Sort();
            Console.WriteLine(string.Join(", ", sortedPowersOfTwo));
        }
        else
            Console.WriteLine("NA");
    }
}
