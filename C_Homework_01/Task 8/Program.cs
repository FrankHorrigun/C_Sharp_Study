// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число ");
string value = Console.ReadLine();
int N = int.Parse(value);

int A = 2;
while (A <= N)
{
    Console.Write(A);
     A = A + 2;
    if (A <= N)
    {
        Console.Write(", ");
      
    }
    else Console.WriteLine("");
   }