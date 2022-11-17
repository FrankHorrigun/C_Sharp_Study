// See https://aka.ms/new-console-template for more information
int ReadandGetNumber(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int value = int.Parse(number);
    return value;
}

int N = ReadandGetNumber("Введите число N");
int count = 1;
int result = 0;
while(count <=N)
{
    int result = result + Math.Pow(count, 2);
    count++;
}
Console.WriteLine("Сумма квадратов от 1 до N равна " +result);
