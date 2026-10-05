/*
 * 7    Skriv ett program som läser ett tal n och beräknar summan av de n första talen i 
 *      Fibonacciserien: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …
 *      
 *      Varje tal i serien (utom de två första) är summan av de två föregående
 */

// Talet på plats nummer 1 är lika med 0
using System.Numerics;

Console.Write("Ange ett tal: ");
uint n = uint.Parse(Console.ReadLine());

BigInteger first = 0;
BigInteger second = 1;
BigInteger third = 0;
BigInteger sum = 0;


for (int i = 0; i < n - 1; i++)
{
    first = second;
    second = third;
    third = first + second;
    sum = sum + third;
}

Console.WriteLine("\nSumman av de {0} första talen i Fibonacciserien = {1}\n\n", n, sum);


Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();