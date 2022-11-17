// Напишите программу, которая будет принимать на вход два целочисленных числа и выводить,
// является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int digit1 = new Random().Next(10, 20);
Console.WriteLine("Первое число = " +digit1);
int digit2 = new Random().Next(1, 10);
Console.WriteLine("Второе число = " +digit2);
int ost = digit1 % digit2;
if (ost == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else Console.WriteLine("Не кратно, остаток от деления = " +ost);
