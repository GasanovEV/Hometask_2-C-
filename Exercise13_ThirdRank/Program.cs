﻿Console.Clear();
Console.WriteLine("Введите  число ");
string userInput = Console.ReadLine()??"";
int number = int.Parse(userInput);

if (number<=100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
while (number > 999)
{
    number /= 10;

}
int result = number % 10;

Console.WriteLine($"{number} -> {result}");
}



