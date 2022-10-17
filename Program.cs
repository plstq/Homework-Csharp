// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int num1 = (number / 10) % 10;
// Console.WriteLine($"{number} = {num1}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = 645;
// int num3 = 78;
// int num4 = 32679;
// if (num1 == num2)
// {
//     int num = num2 % 10;
//     Console.WriteLine($"{num}");
// }
// if (num1 == num3)
// {
//     Console.WriteLine($"Третьей цифры нет");
// }
// if (num1 == num4)
// {
//     int num = (num4 / 100) % 10;
//     Console.WriteLine($"{num}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int num1 = 6;
// int num2 = 7;
// if ((number == num1) || (number == num2))
// {
//     Console.WriteLine($"{number} - Выходной");
// }
// else
// {
//     Console.WriteLine($"{number} - Не выходной");
// }
