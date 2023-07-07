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

