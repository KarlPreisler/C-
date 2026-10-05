/*
 * 12   Skriv ett program som från konsolen läser ett positivt heltal n (n<20) och skriver ut 
 *      en matris enligt följande:
 *      
 *      Exempel:
 *      1 2 3 4
 *      2 3 4 5
 *      3 4 5 6
 *      4 5 6 7
 */

Console.Write("Ange ett tal (0 < N < 20): ");
byte n = byte.Parse(Console.ReadLine());

Console.WriteLine();
for (int row = 1; row <= n; row++)
{
    for (int col = row; col <= row + n - 1; col++)
    {
        Console.Write("{0,3}", col);
    }

    Console.WriteLine();
}
Console.WriteLine();




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();