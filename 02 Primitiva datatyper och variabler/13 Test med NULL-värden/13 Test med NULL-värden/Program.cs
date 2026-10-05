/*
 * 13 Skapa ett program som tilldelar null-värden till en int  och en double. 
 * Försök att skriva ut dem på konsolen. Försök också att addera några värden och 
 * observera vad som händer.
*/

Console.WriteLine("Null beter sig inte alltid som man tror att det ska göra!\n");

int? x = null;
double? y = null;

Console.WriteLine(x); // white space
Console.WriteLine(y); // white space

x = x + 5;
y = y + 0.55;

Console.WriteLine(x); // again white space
Console.WriteLine(y); // again white space

x = 5;
y = 0.55;

Console.WriteLine(x); // 5
Console.WriteLine(y); // 0.55
