//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Применять Math.Pow нельзя!

int GetNaturValue(string message)
{
    Console.WriteLine(message);
    int inputB = int.Parse(Console.ReadLine());
    return inputB;
}


double GetValue(string message)
{
    Console.WriteLine(message);
    double inputA = double.Parse(Console.ReadLine());
    return inputA;

}bool IsInputValid(int x)
{
    if (x < 0)
        return false;
    return true;
}

double Calculate(double A, int B) 
{
    double result = A;
    if (B != 0)
        {
            for(int i = 2; i <= B; i++)
            {
                result *= A;
             }
        }     
    else result = 1;    
    return result;
}

double A = GetValue("Введите A");
int B = GetNaturValue("Введите B");

bool IsValid = IsInputValid(B);
if (IsValid)
    {
        Console.WriteLine(Calculate(A, B));
    }
    else Console.WriteLine("Invalid B");
