/*
 3 Skriv ett program som på ett säkert sätt jämför flyttal med en noggrannhet av 0.000001. 
    Exempel: (5.3 och 6.01) ger false. (5.00000001 och 5.00000003) ger true
 */

Console.WriteLine("Test av jämförelser:");
float firstNumber = 5.3F;
float secondNumber = 6.01F;

Console.WriteLine("{0} är lika med {1} -> {2}",
    firstNumber, secondNumber, firstNumber == secondNumber);


firstNumber = 5.00000001F;
secondNumber = 5.00000003F;

Console.WriteLine("{0} är lika med {1} -> {2}",
    firstNumber, secondNumber, firstNumber == secondNumber);

double thirdNumber = 5.00000001;
double fourthNumber = 5.00000003;
Console.WriteLine("{0} är lika med {1} -> {2}",
    thirdNumber, fourthNumber, thirdNumber == fourthNumber);


Console.WriteLine("\nOther tests: ");

float f = 0.1F;
Console.WriteLine("{0}f is equal to {1} -> {2}", f, 0.1, f == 0.1); // returns false
Console.WriteLine("{0}f is equal to {1}f -> {2}", f, 0.1, f == 0.1F); // return true

double d1 = 1.000001;
double d2 = 0.000001;
Console.WriteLine("({0} - {1}) == 1.0 -> {2}",
    d1, d2, (d1 - d2) == 1.0); // this is exactly 1.0, but return false

double n1 = 0.55;
double n2 = 100;
double ans = n1 * n2; //ans should be 55.0, but it is 55.000000000000007

if (ans == 55.0)
{
    // This will not display the 'ans'
    Console.WriteLine(ans);
}

