/*
 * 2.   Skriv ett booleskt uttryck som kollar om ett givet heltal är jämnt delbart 
 *      med 5 och 7 samtidigt
*/

Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine());

//bool isDivisible = number % 35 == 0;
bool isDivisible = (number % 5 == 0) && (number % 7 == 0);

Console.WriteLine("Talet {0} är delbart med 5 och 7 samtidigt: {1}", number, isDivisible);
//Console.WriteLine("Talet {0} är delbart med 5 och 7 samtidigt: {1}", number, number % 35 == 0);
//Console.WriteLine("Talet {0} är delbart med 5 och 7 samtidigt: {1}", number, 
//    (number % 5 == 0) && (number % 7 == 0));