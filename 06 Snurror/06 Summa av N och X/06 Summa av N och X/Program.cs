/*
 * 6    Skriv ett program som, för två givna heltal n och x, beräknar summan
 *      s = 1 + 1!/x + 2!/x^2 + … + n!/x^n
 */


Console.Write("Ange N: ");
uint n = uint.Parse(Console.ReadLine());

Console.Write("Ange X: ");
uint x = uint.Parse(Console.ReadLine());

decimal sum = 1m;

for (int i = 1; i <= n; i++)
{
    // Beräkna fakulteten i!
    decimal fakultet = i;
    fakultet = CalculateFactorial(fakultet);

    sum = sum + fakultet / (decimal)Math.Pow(x, i);
}

Console.WriteLine("\nSum = {0}\n", sum);




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();


decimal CalculateFactorial(decimal number)
{
    if (number < 1) return 1;

    return number * CalculateFactorial(number - 1);
}
