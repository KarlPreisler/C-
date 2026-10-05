/*
 * Deklarera en bool-variabel som heter isBlonde och ge den ett värde som 
 * återspeglar din hårfärg
*/

using System.Threading.Tasks.Dataflow;
bool isBlonde;
char answer;

Console.Write("Är du blond? (j/n): ");
answer = Char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();
isBlonde = (answer == 'j' || answer == 'y');
//Console.WriteLine("Är du blond? " + isBlonde);

switch (answer.ToString())
{
    case "j":
    case "y":
        Console.WriteLine("Ja, du är blond");
        break;
    case "n":
        Console.WriteLine("Nej, du är inte blond");
        break;
    default:
        Console.WriteLine("Svarade du ja eller nej?");
        break;
}
