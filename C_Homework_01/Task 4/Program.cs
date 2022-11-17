// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число ");
string value1 = Console.ReadLine();
int N1 = int.Parse(value1);

Console.WriteLine("Введите второе число ");
string value2 = Console.ReadLine();
int N2 = int.Parse(value1);

Console.WriteLine("Введите третье число ");
string value3 = Console.ReadLine();
int N3 = int.Parse(value3);

int max = N1;

if (N2 > max)
{
    max = N2;
}
if (N3 > max)
{
    max = N3;
}

Console.WriteLine(max);
