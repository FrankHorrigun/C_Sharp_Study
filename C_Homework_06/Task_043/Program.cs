// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2
// x*(k1-k2) = b2 - b1
// x = (b2 - b1)/(k1-k2)

double GetNumber(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

bool IsValid(double a, double b)
{
    if (a == b) return false;
    else return true;
}

string Result(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    string result = "(" +x +";" +y +")";
    return result;
}

double b1 = GetNumber("Введите b1");
double k1 = GetNumber("Введите k1");
double b2 = GetNumber("Введите b2");
double k2 = GetNumber("Введите k2");

if (IsValid(k1, k2) == false)
{
    Console.WriteLine("Ошибка ввода. k1 не должно быть равно k2 ");
}
else Console.WriteLine(Result(b1, k1, b2, k2));






