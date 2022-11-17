// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string a = Console.ReadLine();
//Console.WriteLine(x);
int number = int.Parse(a);
int number1 = Math.Abs(number);
string number2 = number1.ToString();
int x = number2.Length;
if (x > 2) Console.WriteLine("Третий знак введенного числа = " +number2[2]);
else Console.WriteLine("Нет третьего знака");


