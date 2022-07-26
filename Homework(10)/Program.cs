// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int RANDOM = new Random().Next(100, 1000);

Console.WriteLine(RANDOM);

int num1 = RANDOM / 10;
int num2 = num1 % 10;


Console.WriteLine(num2);

