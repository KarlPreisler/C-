/*
 * 3.   Skriv ett uttryck som beräknar arean av en rektangel utifrån inmatade bredd och höjd
*/

Console.Write("Ange rektangelns bredd: ");
double bredd = double.Parse(Console.ReadLine());

Console.Write("Ange rektangelns höjd: ");
double höjd = double.Parse(Console.ReadLine());

Console.WriteLine($"Rektangelns area: {bredd * höjd}");
