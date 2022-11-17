// Принимает на вход число и выдает колво цыфр в числе
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());

int result(int a)
{
    int count = 0;
    while (a != 0)// для отрицательных
    {
        a = a /10;
        count++;
    }
    return count;
}

Console.WriteLine($"Количество цифр = {result(A)}");
