/*
 * 8    Skriv ett program som, beroende på användarens val, läser in en int, double eller string 
 *      variabel. 
 *      Om variabeln är heltal eller flyttal, öka på det med 1. 
 *      Om det är en sträng så lägg till en "*" på slutet. 
 *      Programmet skall visa variabelns värde på konsolen. Använd en switch.
*/

double number = 0;
string text = string.Empty;

Console.WriteLine("Ange datatyp:");
Console.WriteLine("    1: int");
Console.WriteLine("    2: double");
Console.WriteLine("    3: string");
Console.Write("-> Ange ditt val: ");

switch (Console.ReadLine()) // istället för hjälpvariabel. Kanske inte världens bästra idé, men det funkar
{
    case "1":
        Console.Write("\nAnge ett heltal: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Nytt värde -> {0}\n", number + 1);
        break;
    case "2":
        Console.Write("\nAnge ett flyttal: ");
        number = double.Parse(Console.ReadLine());
        Console.WriteLine("Nytt värde -> {0}\n", number + 1);
        break;
    case "3":
        Console.Write("\nAnge en text: ");
        text = Console.ReadLine();
        Console.WriteLine("Nytt värde -> {0}*\n", text);
        break;


    default:
        Console.WriteLine("\nFel! Felaktigt menyval!\n");
        break;
}





Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
