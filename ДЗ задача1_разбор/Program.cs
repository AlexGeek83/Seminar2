// Найти вторую цифру справа
// 123456 -> 2

//string number = Console.ReadLine();
//if (number.Length <= 1)
//    System.Console.WriteLine("Нет второй цифры!");
//else
//    System.Console.WriteLine(number[1]);

int num = 4258;
// num = Math.Abs(num);  // модуль числа
if(num <= 9)
{
    System.Console.WriteLine("Нет второй цифры");
}
else
{
    while (num >= 100)
    {
    num /=10;
    }
    Console.WriteLine($"Вторая цифра справа числа {num} будет {num % 10} ");
}

