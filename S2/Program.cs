//программа выводит 3-хзначное число и убирает число посередине 
int RANDOM = new Random().Next(100, 1000);

Console.WriteLine(RANDOM);

int num1 = RANDOM / 100;
int num2 = RANDOM % 10;
int max = num1;

Console.WriteLine($"{num1}{num2}");

if (num2 > max)
{
    max = num2;
}

//Console.WriteLine(max);
