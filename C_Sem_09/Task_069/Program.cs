// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}


int PowRecursive(int number, int pow)
{

    if (pow == 1)
    {
        return number;
    }
    return number * PowRecursive(number, --pow);
}


int A = Prompt("Input number A");
int B = Prompt("Input number B");

int powResult = PowRecursive(A, B);

Console.WriteLine($"{A} в степени {B} равно {powResult}");
