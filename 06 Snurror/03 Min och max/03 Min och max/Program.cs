/*
 * 3    Skriv ett program som läser en sekvens av N heltal från konsolen och skriver ut 
 *      det minsta och största av dem
 */

Console.Write("Ange hur många tal du vill ha: ");
byte totalNumbers = byte.Parse(Console.ReadLine());

Console.Write("    1: ");
int min = int.Parse(Console.ReadLine());
int max = min;

for (int i = 2; i <= totalNumbers; i++)
{
    Console.Write("    {0}: ", i);
    int number = int.Parse(Console.ReadLine());

    if (number > max)
    {
        max = number;
    }
    else if (number < min)
    {
        min = number;
    }
}

Console.WriteLine("\nDet största talet: {0}", max);
Console.WriteLine("Det minsta talet: {0}", min);




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();