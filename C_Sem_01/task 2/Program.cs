Console.WriteLine("Ведите число ");
string value = Console.ReadLine();
int a = int.Parse(value);
if (a<0) 
{
    goto = 1;
}
int b = -a;
while(b<=a)
{
    Console.Write(b);
    Console.Write(", ");
    b++;
}
