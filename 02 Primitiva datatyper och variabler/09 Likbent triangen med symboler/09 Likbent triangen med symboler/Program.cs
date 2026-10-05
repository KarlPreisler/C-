/*
 * 9    Skriv ett program som skriver ut en likbent triangel av 9 stycken 
 * copyright-symboler ©. 
 * Använd Windows Teckenuppsättning för att hitta Unicodevärdet för ©. 
 * 
 * Observera: det är inte säkert att symbolen © visas korrekt
*/

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int thighLength = 5; // Length of the triangle's thigh (number of symbols in the base)
//char copyrightSymbol = '\u00A9'; // Unicode for copyright symbol ©
char copyrightSymbol = '©';

int cols = thighLength * 2 - 1; // Total number of columns in the triangle
int symbolOnRow = 1; // Number of symbols to print on the current row (Increase by 2 on each row)
Console.WriteLine("Likbent triangel byggd med symbolen " + copyrightSymbol + ":\n\n");

for (int col = 0; col <= thighLength; col++)
{
    int blankSpaces = cols - symbolOnRow / 2; // Calculate the number of leading blank spaces
    Console.Write(new string(' ', blankSpaces)); // Print leading blank spaces
    Console.WriteLine(new string(copyrightSymbol, symbolOnRow));

    symbolOnRow += 2; // Increase the number of symbols for the next row
}
