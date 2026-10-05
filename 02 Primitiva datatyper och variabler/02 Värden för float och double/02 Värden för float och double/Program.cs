/*
 2 Till vilka av följande tal kan du använda en float? Vilka behöver en double? 
Talen är 34.567839023, 12.345, 8923.1234857,  3456.091
 */

double first = 34.567839023;
float second = 12.345F;
double third = 8923.1234857;
float fourth = 3456.091F;

Console.WriteLine(first + " -> " + first.GetTypeCode());
Console.WriteLine("{0} -> {1}", second, second.GetTypeCode());
Console.WriteLine($"{third:N9} -> {third.GetTypeCode()}");      // 8 923,123485700
Console.WriteLine(fourth + " -> " + fourth.GetTypeCode());