// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string value = Console.ReadLine();
int N = int.Parse(value);
int ost = (N % 2);
if (ost == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");