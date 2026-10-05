/*
 * 9 och 10 Inom kombinatoriken beräknar man Catalantalen enligt formeln
 *          C(n) = (2*n)!/(n+1)!*n!, för n >= 0
 *          
 *          Se https://sv.wikipedia.org/wiki/Catalantal för en enklare formel:
 *          C(0) = 1
 *          C(n+1) = 2*(2*n + 1)/(n + 2) * C(n)
 *          
 *          Notera: Uppgifterna 9 och 10 i presentationen är egentligen en uppgift
 */

using System.Numerics;

Console.Write("Ange ett tal: ");
uint n = uint.Parse(Console.ReadLine());

BigInteger catalan = Fakultet(2 * n) / (Fakultet(n + 1) * Fakultet(n));

Console.WriteLine("\nC({0}) = {1}\n", n, catalan);



Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

// Beräkna fakultet
BigInteger Fakultet(uint n)
{
    if (n < 1) return 1;

    return n * Fakultet(n - 1);
}
