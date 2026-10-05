/*
 * 6.   Skriv ett uttryck som kontrollerar om ett givet positivt heltal n (n≤100) är 
 *      ett primtal. Till exempel är 37 ett primtal.
*/

Console.Write("Ange ett heltal (mindre än eller lika med 100): ");
int number = int.Parse(Console.ReadLine());

bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(number); i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}

Console.WriteLine("{0} {1} ett primtal", number, isPrime ? "ÄR" : "Är INTE");
