Console.Clear();
Console.WriteLine("Введите  число целое число от 1 до 7 ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

if (number<1 | number>7)
{
    Console.WriteLine($"Ошибка ввода. Число {number} не является днем недели. ");
}

else switch (number)
    {
case 1:
Console.WriteLine("Нет!День рабочий.");
break;

case 2:
Console.WriteLine("Нет!День рабочий.");
break;

case 3:
Console.WriteLine("Нет!День рабочий.");
break;

case 4:
Console.WriteLine("Нет!День рабочий.");
break;

case 5:
Console.WriteLine("Нет!День рабочий.");
break;

case 6:
Console.WriteLine("Да!Сегодня выходной!");
break;

case 7:
Console.WriteLine("Да!Сегодня выходной!");
break;


}









/*if (number<1 | number>7)
{
    Console.WriteLine($"Ошибка ввода. Число {number} не является днем недели ");
}
else 
{

}
{
int a1 = number / 100;
int a2 = number / 10;

int result = a1*10-a2;


Console.WriteLine($"{number} -> {result}");
}*/