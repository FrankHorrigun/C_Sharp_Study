// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}


void Order(int m, int n)
{

    if (n >= m)
    {
        Order(m, n - 1);
        Console.Write($"{n} ");
    }

}


int M = Prompt("Input number M");
int N = Prompt("Input number N");

Order(M, N);
