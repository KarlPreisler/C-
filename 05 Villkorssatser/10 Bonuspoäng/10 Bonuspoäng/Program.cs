/*
 * 10   Skriv ett program som lägger till bonus till givna poäng. Poängen är mellan 1 och 9. 
 *      Programmet läser en siffra som indata. Om siffran är 
 *      mellan 1 och 3: multiplicera med 10
 *      mellan 4 och 6: multiplicera med 100
 *      mellan 7 och 9: multiplicera med 1000
 *      noll eller inte en siffra: skriv ut felmeddelande
 *      
 *      Använd en switch och avsluta med att skriva ut det nya värdet på konsolen
 */

short digit;
Console.Write("Ange en siffra [1;9]: ");
bool isDigit = short.TryParse(Console.ReadLine(), out digit);

if (isDigit == false || digit > 9 || digit <= 0)
{
    Console.WriteLine("\nFel! Indata var inte i det tillåtna intervallet [1;9]...\n");
    return;
}

switch (digit)
{
    case 1:
    case 2:
    case 3:
        digit = (short)(digit * 10);
        break;

    case 4:
    case 5:
    case 6:
        digit = (short)(digit * 100);
        break;

    case 7:
    case 8:
    case 9:
        digit = (short)(digit * 1000);
        break;
}

Console.WriteLine("\nNytt värde: {0}\n", digit);


Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();

