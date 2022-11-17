// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = GetNumber("Введите N ");

Console.Write("Таблица кубов чисел от 1 до N равна: ");
if(N > 0)
{
    for(int x = 1; x < N; x++)
    {
        Console.Write(Math.Pow(x, 3) +", ");
    }
    Console.Write(Math.Pow(N, 3) +"");
}
else 
    {
    for(int x = 1; x > N; x--)
    {
        Console.Write(Math.Pow(x, 3) +", ");
    }
    Console.Write(Math.Pow(N, 3) +"");
}    
Console.WriteLine("");
