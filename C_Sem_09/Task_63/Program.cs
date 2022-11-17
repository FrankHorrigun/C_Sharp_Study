// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void Order(int input)
{

    if (input > 0)
    {
        Order(input - 1);
        Console.Write($"{input} ");
    }

}

int N = Prompt("Input number");
Console.WriteLine(N);

Order(N);







