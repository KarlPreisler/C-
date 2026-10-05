/*
 * 7 Deklarera två string variabler och sätt dem till ”Hej” och ”Världen”. 
 * Deklarera en object variabel och sätt den till konkateneringen av 
 * de två första variablerna (kom ihåg att lägga till ett mellanslag). 
 * 
 * Deklarera en tredje string variabel och låt den få sitt startvärde 
 * från object-variabeln. 
 * (Du behöver läsa på om type casting för att få det att fungera)
*/

string first = "Hej";
string second = "Världen!";

object combined = first + " " + second; // Concatenate strings with a space
string result = (string)combined; // Type casting from object to string

Console.WriteLine(result);  