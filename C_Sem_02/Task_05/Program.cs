// Напишите программу, которая принимает на вход два в числа и проверяет, является ли одно число квадратом другого.


Console.WriteLine("Input first number");
string firstNumber = Console.ReadLine();
Console.WriteLine("Input second number");
string secondNumber = Console.ReadLine();
int Number1 = int.Parse(firstNumber);
int Number2 = int.Parse(secondNumber);
// int result1 = Number1*Number1;
// int result2 = Number2*Number2;
// if (result2 == Number1)
// {
//     Console.WriteLine("first number является квадратом второго");
// }
// else if  (result1 == Number2) 
//     {
//         Console.WriteLine(" второй number является квадратом первого");
//     }
// else Console.WriteLine("No");
if (Number1 * Number1 == Number2 || Number2 * Number2 == Number1) Console.WriteLine("Yes"); // зачок || означает или
else Console.WriteLine("No");
