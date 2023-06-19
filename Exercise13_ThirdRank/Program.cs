﻿Console.Clear();
Console.WriteLine("Введите  число ");
string userInput = Console.ReadLine()??"";
int number = int.Parse(userInput);
if (number<=100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number > 999)
{
int a1 = number / 10;
int a2 = number % 10;

int result = a1*10-a2;


Console.WriteLine($"{number} -> {result}");
}