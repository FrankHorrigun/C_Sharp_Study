// GetNumber функция
int PrintandGetValue(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

double GetLength(double X1, double Y1, double X2, double Y2) // Определение расстояния в 2 мерном пространстве между 2 точками
{
    double L = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));
    return L;
}

int X1 = PrintandGetValue("Введите Х1 ");
int Y1 = PrintandGetValue("Введите Y1 ");
int X2 = PrintandGetValue("Введите Х2 ");
int Y2 = PrintandGetValue("Введите Y2 ");

Console.WriteLine("Расстояние равно " +GetLength(X1, X2, Y1, Y2));


