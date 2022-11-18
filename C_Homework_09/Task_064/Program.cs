// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value < 0)
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

string NumbersFromMtoN(int m, int n)
{
    string numbers = string.Empty;
    if (n <= m)
    {
        return $"{n}";
    }
    return $"{n}, {NumbersFromMtoN(m, n - 1)}";
}


int M = Prompt("Input M:");
int N = Prompt("Input N:");
string result = NumbersFromMtoN(M, N);

if (IsValid(M, N) == false)
{
    Console.WriteLine("M должно быть не меньше N");
}
else Console.WriteLine(result);