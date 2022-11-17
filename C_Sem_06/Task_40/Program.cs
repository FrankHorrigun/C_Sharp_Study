// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон

int GetNumber(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

bool CheckTriangle(int a, int b, int c)
{
    if(a>+c) return false;
    if(b>a+c) return false;
    if(c>a+b) return false;
    else return true;
}

int A = GetNumber("Введите А");
int B = GetNumber("Введите B");
int C = GetNumber("Введите C");

Console.WriteLine($"{CheckTriangle(A, B, C)}");
