// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int newnumber = 0;
System.Console.WriteLine($"случайное число {number} ");
System.Console.WriteLine($"и если из числа {number} убрать вторую цифру {number % 100 / 10},");
System.Console.WriteLine($"то получим число {newnumber = number / 100 * 10 + number % 10}");
