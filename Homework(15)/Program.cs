// SНапишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Укажите число");

int num = int.Parse(Console.ReadLine());

if (num == 6)
{
    Console.WriteLine("да, это выходной(суббота)");
}
else if ( num == 7 )
{
     Console.WriteLine("Да, это выходной(Воскресенье)");
}
else 
{
     Console.WriteLine("Слышь, работать");
}