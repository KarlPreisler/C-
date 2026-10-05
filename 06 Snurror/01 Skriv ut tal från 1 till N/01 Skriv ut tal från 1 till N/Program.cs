/*
 * 1    Skriv ett program som skriver ut alla tal från 1 till n
 */

Console.Write("Ange ett tal: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("\nAlla tal mellan [1] och [{0}]: ", number);

for (int i = 0; i <= number; i++)
{
    Console.Write(i);
    if (i < number)
    {
        Console.Write(", ");
    }

}
Console.WriteLine();


Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();