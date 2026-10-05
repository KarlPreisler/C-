/*
 * 2    Skriv ett program som skriver ut alla tal från 1 till n, som inte är samtidigt 
 *      delbara med 3 och 7

 */

Console.Write("Ange ett tal: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("\nAlla tal mellan [1] och [{0}], som inte är delbara med [21]: ", number);

for (int i = 1; i <= number; i++)
{
    if (i % 21 != 0)
    {
        Console.Write(i);
    }

    if (i < number && i % 21 != 0)
    {
        Console.Write(", ");
    }

}
Console.WriteLine();


Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();