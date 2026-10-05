/*
 * 7.   Skriv ett uttryck som beräknar arean på en parallelltrapets givet 
 *      sidorna a och b samt höjden h.
*/

Console.WriteLine("Parallelltrapetsens sidor:");
Console.Write("     a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("     b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("     höjd = ");
double h = double.Parse(Console.ReadLine());

Console.WriteLine($"Parallelltraptsens area är {(a + b) / 2 * h}");
