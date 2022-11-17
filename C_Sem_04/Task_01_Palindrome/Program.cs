
bool IsPalindrome(int number)
{
    int reversnumber = RereverseNumber(number);
    bool isEqual = reversnumber == number;
    return isEqual;
}

int RereverseNumber(int number)
{
    int reversnumber = 0;
    while(number > 0)
    {
        reversnumber = reversnumber*10 + number%10;
        number /=10;
    }
    return reversnumber;
}

bool IsNumberValid(int number)
{
    if(number < 10000 || number > 100000)
    return false;
    return true;
}

int Prompt()
{
    Console.WriteLine("Введите пятизначное число");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Prompt();

if(IsNumberValid(number))
{
    if(IsPalindrome(number))
        Console.WriteLine("Yes");
    else 
        Console.WriteLine("No");

}
else 
    Console.WriteLine("InvalidNumber");


