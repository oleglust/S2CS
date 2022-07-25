// выводит 2 числа и показывает, является ли 2 число кратным первому , если не кратно, то прога показывает остаток от деления

//int RANDOM = new Random().Next(1, 1000);
//int RANDOM2 = new Random().Next(1, 1000);
int RANDOM = int.Parse(Console.ReadLine());
int RANDOM2 = int.Parse(Console.ReadLine());
//Console.WriteLine(RANDOM);
//Console.WriteLine(RANDOM2);
int num1 = RANDOM%RANDOM2;

if ( num1 == 0)
{
    Console.WriteLine("NIIIICE");
}
Console.WriteLine(num1);
