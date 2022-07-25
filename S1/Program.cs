int RANDOM = new Random().Next(10, 99);

Console.WriteLine(RANDOM);

int num1 = RANDOM / 10;
int num2 = RANDOM % 10;
int max = num1;

Console.WriteLine($"num1 = {num1}, num2 = {num2}");

if (num2 > max)
{
    max = num2;
}

Console.WriteLine(max);
