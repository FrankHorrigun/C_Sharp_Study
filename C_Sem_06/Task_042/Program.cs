// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 

int GetNumber(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

string IntToBin(int a)
{
    string res ="";
    do
    {   
        res = a%2 + res;//добавляем спереди чтоб не разворачивать
        a/=2;   
    }
    while(a>0);
    return res;
}

string ConvertToBin(int a)
{
    if(a ==0) return "0";
    int n = a%2;
    return n + ConvertToBin(a/2);//рекурсией
}

int A = GetNumber("Введите А");
string res = IntToBin(A);

Console.WriteLine(res);
Console.WriteLine(ConvertToBin(A));
Console.WriteLine("auto" +Convert.ToString(A, 2));//проверка конверт = преобразует число в двоичное

