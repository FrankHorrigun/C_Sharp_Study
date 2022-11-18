// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Incorrect Input ");
        Console.WriteLine(message);
    }
    return value;
}

bool IsValid(int m, int n)
{
    if (m > n) return false;
    else return true;
}

int SumOfElementsMtoN(int m, int n)
{
    if (n <= m)
    {
        return m;
    }
    return m + SumOfElementsMtoN(m + 1, n);
}


int M = Prompt("Input M:");
int N = Prompt("Input N:");
int result = SumOfElementsMtoN(M, N);

if (IsValid(M, N) == true)
{
    Console.WriteLine($"Сумма элементов от {M} до {N} равна {result}");
}
else Console.WriteLine("M должно быть не меньше N");