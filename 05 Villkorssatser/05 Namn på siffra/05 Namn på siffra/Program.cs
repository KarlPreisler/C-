/*
 * 5    Skriv ett program som frågar efter en siffra. Beroende på det inmatade talet 
 *      skriv ut namnet på siffran (på svenska) genom att använda en switch
*/

Console.Write("Ange en siffra [0 - 9]: ");
byte digit = byte.Parse(Console.ReadLine());

Console.Write("\nResultat: ");
GetNmeOfDigit(digit);

Console.WriteLine("\nLista över alla siffror:");
for (byte i = 0; i <= 9; i++)
{
    GetNmeOfDigit(i);
}




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();


void GetNmeOfDigit(byte digit)
{
    switch (digit)
    {
        case 0:
            Console.WriteLine("{0} -> Noll", digit);
            break;

        case 1:
            Console.WriteLine("{0} -> Ett", digit);
            break;

        case 2:
            Console.WriteLine("{0} -> Två", digit);
            break;

        case 3:
            Console.WriteLine("{0} -> Tre", digit);
            break;

        case 4:
            Console.WriteLine("{0} -> Fyra", digit);
            break;

        case 5:
            Console.WriteLine("{0} -> Fem", digit);
            break;

        case 6:
            Console.WriteLine("{0} -> Sex", digit);
            break;

        case 7:
            Console.WriteLine("{0} -> Sju", digit);
            break;

        case 8:
            Console.WriteLine("{0} -> Åtta", digit);
            break;

        case 9:
            Console.WriteLine("{0} -> Nio", digit);
            break;

        default:
            Console.WriteLine("Värdet {0} är utanför intervallet [0,9]...", digit);
            break;
    }
}