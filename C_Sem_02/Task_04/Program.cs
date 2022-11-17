// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int digit = int.Parse(number);
// int ost1 = digit % 7;
// int ost2 = digit % 23;
// if (ost1 == 0)
// {
//     if (ost2 == 0);
//     Console.WriteLine("Yes");
// }
// else Console.WriteLine("No");
int a = 7;
int b = 23;

if (digit % a == 0 && digit % b == 0) Console.WriteLine(digit + " кратное"); // && - это и
else Console.WriteLine(digit + " не кратное");