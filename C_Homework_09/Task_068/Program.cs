// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 


int Prompt(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value < 0)
    {
        Console.WriteLine("Введите неотрицательное число ");
        Console.WriteLine(message);
    }
    return value;
}

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}


int M = Prompt("Input M:");
int N = Prompt("Input N:");
int resultAckerman = Ackerman(M, N);
Console.WriteLine($"Значение функции Аккермана от {M} и {N} равно {resultAckerman}");

