// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int Prompt(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value < 0)
    {
        Console.WriteLine("Incorrect Input " + message);
    }
    return value;
}




int SumOfNumbers(int input, int count)
{

    if (input % 10 == 0)
    {
        return input;
    }
    Console.WriteLine($"count = {count}");
    return input % 10 + SumOfNumbers(input / 10, ++count); ;
}

int N = Prompt("Input number: ");
int count = 1;
Console.WriteLine($"{SumOfNumbers(N, count)}");

