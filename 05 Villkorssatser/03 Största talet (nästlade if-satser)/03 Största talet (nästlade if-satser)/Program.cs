/*
 *  3   Skriv ett program som hittar det största av tre heltal genom att använda nästlade if
*/

Console.WriteLine("Ange tre heltal:");
Console.Write("   1: "); decimal first = decimal.Parse(Console.ReadLine());
Console.Write("   2: "); decimal second = decimal.Parse(Console.ReadLine());
Console.Write("   3: "); decimal third = decimal.Parse(Console.ReadLine());

if (first > second)
{
    if (second > third)
    {
        Console.WriteLine("\nStörsta talet: {0}", first);   // 3 2 1
    }
    else
    {
        if (third > second)
        {
            if (third > first)
            {
                Console.WriteLine("\nStörsta talet: {0}", third);   // 2 1 3
            }
            else
            {
                Console.WriteLine("\nStörsta talet: {0}", first);   // 3 1 2
            }
        }
    }
}
else if (second > third)
{
    Console.WriteLine("\nStörsta talet: {0}", second);  // 1 3 2, 2 3 1
}
else
{
    Console.WriteLine("\nStörsta talet: {0}", third);   // 1 2 3
}




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
