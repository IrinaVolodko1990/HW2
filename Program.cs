//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {number}");
//int units = number % 10; //вычисляем единицы
//Console.Write (units);
int dozens = (number / 10) % 10; //вычисляем десятки
Console.WriteLine($"Second unit of this number is {dozens}");
//int hundreds = number / 100; //вычисляем сотни
//Console.Write (hundreds);


//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Input number from 1 to 7: ");
int day = Int32.Parse(Console.ReadLine());
if (day >= 1 && day <= 5)
{
    Console.WriteLine("It's not a day off");
}
else if (day == 6 || day == 7)
{ Console.WriteLine("It is a day off"); }
else { Console.WriteLine("Wrong number"); }