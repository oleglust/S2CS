// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());

string numText = Convert.ToString(num);
// переводим число в строку
if (numText.Length > 2){
  Console.WriteLine("Ответ: " + numText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}