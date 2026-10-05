/*
 * 5    Skriv ett program som beräknar n!*k!/(k-n)! för givna n och k (1 < n < k)
 */

// N = 6;
// K = 10;
// 1.2.3.4.5.6 * 1.2.3.4.5.6.7.8.9.10 => N * K
// (K-N)! => 4! => 1.2.3.4

using System.Numerics;

Console.WriteLine("Du behöver ange två tal (K > N > 1)");
Console.Write("-> K: ");
int k = int.Parse(Console.ReadLine());

Console.Write("-> N: ");
int n = int.Parse(Console.ReadLine());

if (k < n || n < 1 || k < 1)
{
    Console.WriteLine("\nFelaktiga värden! Villkoret är att (K > N > 1)...n");
    return;
}

BigInteger fakultet = 1;
for (int i = k - n + 1; i <= k; i++)
{
    fakultet *= i;
    if (i == k)
    {
        i = 2;
        while (i <= n)
        {
            fakultet *= i;
            i++;
        }

        break;
    }
}

Console.WriteLine("nResultat: {0}!*{1}!/({1}-{0})! = {2}\n", n, k, fakultet);





Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();