/*
 * 5.   Skriv ett uttryck som kontrollerar om en given punkt (x, y) ligger inom 
 *      en cirkel C((0, 0), 5) (dvs cirkel med centrum i (0, 0) och radien 5)
*/

Console.WriteLine("Ange punktens koordinater (x, y):");
Console.Write("   x = ");
double x = double.Parse(Console.ReadLine());
Console.Write("   y = ");
double y = double.Parse(Console.ReadLine());

bool isInside = x * x + y * y <= 5 * 5;    // Radien = 5...
Console.WriteLine("Punkten ({0}, {1}) {2} inuti cirkeln",
    x, y, isInside ? "ÄR " : "ÄR INTE ");