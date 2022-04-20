

int x = new Random().Next(10, 99);
System.Console.WriteLine(x + ",");
if (x % 10 > x / 10)
System.Console.WriteLine(x % 10);
else System.Console.WriteLine(x / 10);