/*
 * 12   Skriv ett program som skapar en vektor som innehåller alla bokstäver i alfabetet (A-Ö). 
 *      Läs ett ord från konsolen och skriv indexet för var och en av dess bokstäver i vektorn.
 */


int[] letters = new int[255];
for (char i = 'A'; i <= 'Ö'; i++) letters[i - 65] = i;

Console.Write("Enter a word: ");
string word = Console.ReadLine();

for (int i = 0; i < word.Length; i++)
    Console.WriteLine("Letter '{0}' -> index: {1} / ASCII Index: {2}", word[i],
        Array.IndexOf(letters, char.ToUpperInvariant(word[i])), (int)word[i]);



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
