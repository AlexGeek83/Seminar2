// Найти вторую цифру справа
// 123456 -> 2

int num = 4258;
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

