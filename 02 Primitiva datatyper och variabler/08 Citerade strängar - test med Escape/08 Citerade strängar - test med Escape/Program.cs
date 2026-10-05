/*
 * 8    Deklarera två string variabler och sätt dem till:
 *          Att "använda" citattecken kan vara besvärligt.
 *      Gör det på två olika sätt: med och utan quoted strings (dvs med och utan ”@”)
*/

string withEscape = "Att \"använda\" citattecken kan vara besvärligt.";
string withoutEscape = @"Att ""använda"" citattecken kan vara besvärligt.";

Console.WriteLine(withEscape);
Console.WriteLine(withoutEscape);