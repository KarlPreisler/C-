/*
 * 8    Skriv ett program som beräknar den största gemensamma nämnaren till två givna tal. 
 *      Använd Euklides algoritm (Googla!)
 *      
 *      På engelska heter det greatest common divisor, GCD
 */

Console.WriteLine("Ange två tal: ");
Console.Write("   1: "); uint a = uint.Parse(Console.ReadLine());
Console.Write("   2: "); uint b = uint.Parse(Console.ReadLine());

while (a != b)
{
    if (a > b)
    {
        a = a - b;
    }
    else
    {
        b = b - a;
    }
}

Console.WriteLine("\nStörsta gemensamma nämnare: {0}", a);



Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();