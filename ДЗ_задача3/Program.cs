// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int number = 78;

if(number > 100 && number < 1000)
System.Console.WriteLine($"число {number} 3-х значное и 3-е число = {number % 10}");  

if(number / 100 > 0)
System.Console.WriteLine($"Третьей цифрой числа {number} является цифра {number % 1000 / 100}");
else System.Console.WriteLine($"У числа {number} нет третьей цифры");
