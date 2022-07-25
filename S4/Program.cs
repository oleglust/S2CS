// принимает на вход число и показывает, кратно ли оно одновременно и 7, и 23. только иф.


int num = int.Parse(Console.ReadLine());


int num1 = num%7;
int num2 = num%23;
int num3 = num1+num2;


if ( num3 == 0)
{
    Console.WriteLine("NIIIICE");
}
