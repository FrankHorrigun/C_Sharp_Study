// GetNumber функция
int PrintandGetValue(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int X = PrintandGetValue("Введите Х ");
int Y = PrintandGetValue("Введите Y ");

//конструкция SWITCH

switch (X)
{
    case 1:// свичим значения Х на 1,2,3,4 и при совпадении выполняем код для кейса
    Console.WriteLine("1 четверть");
    break;

    case 2:
    Console.WriteLine("4 четверть");
    break;

    case 3:
    Console.WriteLine("2 четверть");
    break;

    case 4:
    Console.WriteLine("3 четверть");
    break;

    default:
    Console.WriteLine("Error");
    break;
}



