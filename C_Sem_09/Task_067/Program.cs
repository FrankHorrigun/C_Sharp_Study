// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int SumOfNumbers(int input)
{
    if (input % 10 != 0)
    {
        sum += input % 10;
        SumOfNumbers(input / 10);
    }
    return sum;
}

int N = Prompt("Input number");
int sum = 0;
Console.WriteLine($"{SumOfNumbers(N, sum)}");

