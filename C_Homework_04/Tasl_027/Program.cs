// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNaturValue(string message)
{
    Console.WriteLine(message);
    int input = Math.Abs(int.Parse(Console.ReadLine()));
    return input;
}

int DigitSum(int x)
{
    int count = 1;
    int sum = 0;
    while(x != 0)
    {
        sum = sum + x%10;
        x = x/10;
        count++;
    }
    return sum;
}


int A = GetNaturValue("Введите A");
Console.WriteLine(DigitSum(A));


