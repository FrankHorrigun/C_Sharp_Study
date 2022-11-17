// Напишите программу, которая выводит целое случайное трёхзначное число и удаляет вторую цифру этого числа.

int digit = new Random().Next(100, 1000); // генерируем трехзначное число
Console.WriteLine("Случайное число = " +digit);
int thirdDigit = digit % 10;
int secondDigit = digit % 100;
int firstDigit = digit / 100;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine("Итоговое число = " +result);










