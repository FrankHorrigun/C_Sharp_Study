// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
string a = Console.ReadLine();
int dayNumber = int.Parse(a);
if (dayNumber < 1 || dayNumber > 7) Console.WriteLine("Введенное число не соответсвует дню недели");
else if (dayNumber < 6) Console.WriteLine("Сегодня не выходной");
else Console.WriteLine("Сегодня выходной");
