/*
 * 11 Deklarera två heltalsvariabler och ge dem värdena 5 respektive 10. 
 * Ordna sedan så att de byter värden med varandra.
*/

int x = 5;
int y = 10;

// Första sättet med hjälpvariabel
Console.WriteLine($"Metod 1 före byte: x = {x}, y = {y}");
int swap = x;
x = y;
y = swap;
Console.WriteLine($"Efter byte: x = {x}, y = {y}");


// Andra sättet med bitficklande
Console.WriteLine($"Metod 2 före byte: x = {x}, y = {y}");
x = x ^ y;
y = y ^ x;
x = x ^ y;
Console.WriteLine($"Efter byte: x = {x}, y = {y}");


// Tredje sättet med summor och skillnader
// OBS Funkar inte om första summan blir för stor för datatypen (dvs om vi får en Overflow)
Console.WriteLine($"Metod 3 före byte: x = {x}, y = {y}");
x = x + y;
y = x - y;
x = x - y;
Console.WriteLine($"Efter byte: x = {x}, y = {y}");


