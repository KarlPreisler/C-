/*
 * 15   Skriv ett program som hittar alla primtal i intervallet [1, 10 000 000]. 
 *      Använd algoritmen Eratosthenes såll (Wikipedia: https://sv.wikipedia.org/wiki/Eratosthenes_s%C3%A5ll)
 */

bool[] primes = new bool[2_000]; // new bool[10_000_000];

// Find all prime numbers to N
for (int i = 2; i < Math.Sqrt(primes.Length); i++)
{
    // Skip these which is not prime
    if (primes[i] == false)
    {
        for (int j = i * i; j < primes.Length; j += i)
            primes[j] = true;
    }
}

// Print all prime numbers to N
for (int i = 2; i < primes.Length; i++)
    if (!primes[i]) Console.Write(i + " ");



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
