﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000); // Не совсем понял только, число генерировать нужно или пользователю вводить. По условию задачи не ясно
Console.WriteLine("Сгенерировано новае случайное число " +number);
int secondDigit = number % 100 / 10;
Console.WriteLine("Вторая цифра числа " +number +" есть " +secondDigit);

