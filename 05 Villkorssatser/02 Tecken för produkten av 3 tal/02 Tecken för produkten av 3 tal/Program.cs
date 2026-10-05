/*
 * 2    Skriv ett program som visar tecknet (+ eller -) för produkten av tre flyttal 
 *      utan att utföra multiplikationen. Använd en sekvens av if-satser
 *      
 *          0 negativa → produkten positiv
 *          1 negativt → produkten negativ
 *          2 negativa → produkten positiv
 *          3 negativa → produkten negativ
*/


// Första exemplet:
double first = -2.132;
double second = 4.523;
double third = -23.42;

//if (first * second * third < 0)
//{
//    Console.WriteLine($"{first} * {second} * {third} => NEGATIVT (< 0)");
//}
//else
//{
//    Console.WriteLine($"{first} * {second} * {third} => POSITIVT (> 0)");
//}
double[] numbers = { -2.132, 4.523, -23.42 };

int antalNegativa = 0;
//bool isNoll = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        antalNegativa++;
    }
}
if (antalNegativa % 2 == 0)
{
    Console.WriteLine($"{first} * {second} * {third} => POSITIVT (> 0)");
}
else
{
    Console.WriteLine($"{first} * {second} * {third} => NEGATIVT (< 0)");
}


Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
