/*
 * 9    Skriv ett program som läser in fem heltal och kontrollerar ifall summan av någon 
 *      delmängd av talen är 0 (noll).
 *      
 *      Exempel: 3, -2, 1, 1, 8 -> 1+1-2=0
*/

int[] numbers = { 3, -2, 1, 1, 8 };
long subsets = (long)(Math.Pow(2, numbers.Length) - 1);

for (int i = 1; i <= subsets; i++)
{
    List<int> currentSum = new List<int>();

    for (int j = 0; j < numbers.Length; j++)
    {
        if ((i >> j & 1) == 1)
        {
            currentSum.Add(numbers[j]);
        }

    }

    if (currentSum.Sum() == 0)
    {
        Console.Write("Summa noll: ");
        for (int j = 0; j < currentSum.Count; j++)
        {
            Console.Write(j > 0 ?
                (currentSum[j] > 0 ? " + " + currentSum[j] + "" : " - " + Math.Abs(currentSum[j]) + "")
                : currentSum[j].ToString());
        }
        Console.WriteLine(" = 0\n");
        break;
    }
}





Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
