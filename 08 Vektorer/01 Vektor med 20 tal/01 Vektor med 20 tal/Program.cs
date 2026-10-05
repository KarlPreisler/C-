/*
 * 1    Skriv ett program som allokerar en vektor med 20 heltal och initialiserar varje element 
 *      med sitt index gånger 5. Skriv ut resultatet på konsolen.
 */

int[] numbers = new int[20];
for (int i = 0; i < numbers.Length; i++)
    Console.WriteLine("Index: {0,2}  /  Number: {1,2}", i, numbers[i] = i * 5);


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
