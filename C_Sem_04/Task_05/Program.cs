// Принимает на вход число и выдает произведение чисел от 1 до N
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int Result(int a)
{
    int x = 1;
    for(int i = 1; i <= a; i++)
    {
        x *= i;
    }
    return x;
}
Console.WriteLine($"Результат = {Result(N)}");
