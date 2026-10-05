/*
 * 4    Skriv ett program som beräknar n!/k! för givna värden på n och k (1 < k < n)
 * 
 *      KOM IHÅG: n!, n fakultet, definieras som 1 * 2 * … * n
 *      Eller eventuellt som n * n-1 * n-2 * … * 2 * 1
 */

using System.Numerics;

Console.WriteLine("Du behöver ange två tal (N > K > 1)");
Console.Write("-> K: ");
int k = int.Parse(Console.ReadLine());

Console.Write("-> N: ");
int n = int.Parse(Console.ReadLine());

if (n < k || n < 1 || k < 1)
{
    Console.WriteLine("\nFelaktiga värden! Villkoret är att (N > K > 1)...n");
    return;
}

BigInteger fakultet = 1;
for (int i = k + 1; i <= n; i++)
{
    fakultet *= i;
}

Console.WriteLine("\nResultat: {0}!/{1}! = {2}\n", k, n, fakultet);




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();