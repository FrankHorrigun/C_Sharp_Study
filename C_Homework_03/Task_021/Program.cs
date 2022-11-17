// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int PrintandGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double GetLength(double X1, double Y1, double Z1, double X2, double Y2, double Z2) // Определение расстояния в 3 мерном пространстве между 2 точками
{
    double L = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));
    double Dis = Math.Round(L, 2);
    return Dis;
}

int X1 = PrintandGetValue("Введите Х1 ");
int Y1 = PrintandGetValue("Введите Y1 ");
int Z1 = PrintandGetValue("Введите Z1 ");
int X2 = PrintandGetValue("Введите Х2 ");
int Y2 = PrintandGetValue("Введите Y2 ");
int Z2 = PrintandGetValue("Введите Z2 ");

Console.WriteLine("Расстояние равно " +GetLength(X1, Y1, Z1, X2, Y2, Z2));