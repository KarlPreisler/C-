/*
 *  1. Skriv ett uttryck som kollar om ett givet heltal är udda eller jämnt
*/

Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine());

//Console.WriteLine("Talet {0} är {1}", number, number % 2 == 0 ? "jämnt" : "udda");
Console.WriteLine($"Talet {number} är {(number % 2 == 0 ? "jämnt" : "udda")}");