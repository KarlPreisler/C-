/*
 * 13   Skriv ett program som beräknar för ett givet n hur många nollor det finns 
 *      på slutet av talet n! (n-fakultet)
 *      Exempel:
 *      n = 10 -> n! = 3 628 800 -> 2
 *      n = 20 -> n! = 2 432 902 008 176 640 000 -> 4
 *      n = 23 -> n! = 25 852 016 738 884 976 640 000 -> 4
 *      
 *      Fungerar ditt program för n = 50 000?
 *      
 *      Tips: Antalet avslutande nollor i n! är lika med hur många gånger talet kan delas med 5. 
 *      Fundera på varför!
 *
 */

Console.Write("Ange ett tal: ");
uint n = uint.Parse(Console.ReadLine());
byte zerosN = 0;

Console.Write("\nN = {0} -> {0}! -> ", n);

for (int i = 5; i <= n; i *= 5)
{
    zerosN += (byte)(n / i);
}

Console.WriteLine("{0} zeros\n", zerosN);




Console.Write("\n\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();