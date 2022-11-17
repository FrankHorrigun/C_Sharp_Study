// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
string value1 = Console.ReadLine();
int N1 = int.Parse(value1);

Console.WriteLine("Введите второе число ");
string value2 = Console.ReadLine();
int N2 = int.Parse(value2);

Console.Write("Max = ");
if (N1 > N2)
{
    Console.WriteLine(N1);
}
else Console.WriteLine(N2);
