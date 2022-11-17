// See https://aka.ms/new-console-template for more information
int RandomValue = new Random().Next(10, 100); // Генерирует от 10 до 99 (100 не включется)
Console.WriteLine(RandomValue);
int decadeDigit = RandomValue / 10;
int unitDigit = RandomValue % 10;
Console.WriteLine(decadeDigit);
Console.WriteLine(unitDigit);
//if (decadeDigit > unitDigit)
//{
//    Console.WriteLine(decadeDigit);
//}
//else Console.WriteLine(unitDigit);
int maxValue = decadeDigit;
if (maxValue < unitDigit)
{
    maxValue = unitDigit;
}
  Console.WriteLine("Max = " + maxValue);
