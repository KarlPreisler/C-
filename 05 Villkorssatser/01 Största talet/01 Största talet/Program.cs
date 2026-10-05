/*
 * 1    Skriv en if sats som jämför två heltalsvariabler och byter deras värden om 
 *      den första är större än den andra
 */
Console.WriteLine("Ange två heltal: ");
Console.Write("   Tal 1: ");
int first = int.Parse(Console.ReadLine());
Console.Write("   Tal 2: ");
int second = int.Parse(Console.ReadLine());

if (first > second)
{
    int swap = first;
    first = second;
    second = swap;
}

Console.WriteLine("\nStörsta talet: {0}", second);
Console.WriteLine("Minsta talet: {0}", first);





Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
