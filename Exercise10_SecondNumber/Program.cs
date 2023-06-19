﻿Console.Clear();
Console.WriteLine("Введите трехзначное число ");
string userInput = Console.ReadLine()??"";
int number = int.Parse(userInput);
if (100>number | number>999)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
int a1 = number / 100;
int a2 = number / 10;

int result = a1*10-a2;


Console.WriteLine($"{number} -> {result}");
}