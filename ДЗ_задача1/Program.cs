// System.Console.WriteLine(1234 % 100);
// Console.WriteLine(1234 / 10);

// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine(782 % 100 / 10);


int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Второй цифрой числа {number} является {number % 100 / 10} ");


