// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. 
//(нужно использовать функцию IsPalindrome, которая принимает число int или string, а возвращает bool)

string GetNumber(string message)
{
    Console.WriteLine(message);
    int N = Math.Abs(int.Parse(Console.ReadLine()));
    string input = N.ToString();
    if(input.Length!=5)
    {
        Console.WriteLine("Ошибка. Введите пятизначное число");
    }
    return input;
}

 bool IsPalindrome(string N)// метод работает для строк любой длины
    {
        int min = 0;
        int max = N.Length - 1;
        while (true)
        {
            if (min < max) // Стояло изначально >. Почему??? Поменял на < работает также
            {
                return true;
            }
            char a = N[min];
            char b = N[max];
            if (a != b)
            {
                return false;
            }
            min++;
            max--;
        }
    }

string N = GetNumber("Введите пятизначное число");
//Console.WriteLine("пятизначное число " +N);
Console.WriteLine("{0} = {1}", N, IsPalindrome(N));//  "{0} = {1}" что это за конструкция понять тоже не могу Х.Х
