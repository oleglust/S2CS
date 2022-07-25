// принимает 2 числа и показывает, является ли одно квадратом другого
Console.WriteLine("бахни число1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("бахни число 2");
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1*num1)
{
    Console.WriteLine("2 sq");
}
else if ( num1 == num2*num2 )
{
     Console.WriteLine("1 sq");
}
else 
{
     Console.WriteLine("DICK");
}