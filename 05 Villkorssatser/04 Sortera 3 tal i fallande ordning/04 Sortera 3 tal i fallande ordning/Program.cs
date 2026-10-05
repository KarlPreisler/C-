/*
 * 4 Sortera 3 flyttal i STIGANDE ordning genom att använda nästlade if
*/

using System.ComponentModel.Design;

Console.WriteLine("Ange tre flyttal:");
Console.Write("   1: "); double first = double.Parse(Console.ReadLine());
Console.Write("   2: "); double second = double.Parse(Console.ReadLine());
Console.Write("   3: "); double third = double.Parse(Console.ReadLine());
double swap = 0;

// Tänker oss att vi matar in 3 2 1
if (first > second)
{
    if (first > third)
    {
        swap = first;
        first = third;
        third = swap;       // Nu har vi 1 2 3
    }

    if (first > second)
    {
        swap = first;
        first = second;
        second = swap;
    }
}
else if (second > third)
{
    if (first > third)
    {
        swap = first;
        first = third;
        third = swap;
    }

    if (second > third)
    {
        swap = second;
        second = third;
        third = swap;
    }
}

Console.WriteLine("\nTalen i stigande ordning: {0} < {1} < {2}", first, second, third);

//// Alternativ lösning:
//Console.WriteLine("ALTERNATIV LÖSNING\nAnge tre heltal: ");
//int[] numbers = new int[3];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write("    Tal nummer {0}", i);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//// Sortera:
//numbers.Sort



Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
