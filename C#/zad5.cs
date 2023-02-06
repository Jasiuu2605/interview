using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                string[] line = Console.ReadLine().Split();
                int m = int.Parse(line[0]);
                int n = int.Parse(line[1]);
                int count = 0;

                for (int i = m; i <= n; i++)
                {
                    // Beginner's mistake: Checking for primes only up to n, instead of the square root of n
                    for (int j = 2; j <= n; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                            break;
                        }
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
