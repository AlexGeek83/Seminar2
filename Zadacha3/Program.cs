int number = 161;
int number2 = 7;
int number3 = 23;

if(number % number2 == 0 && number % number3 == 0) // && - проверяются сразу два условия - оператор "И"
   // {
   // if(number % number3 == 00)
   // System.Console.WriteLine("Да кратны");
   // else System.Console.WriteLine("Нет что то не кратно");
   // }
    {
        System.Console.WriteLine($"Число {number} кратно числу {number2} и числу {number3}");
    }
    //else System.Console.WriteLine("Нет не кратно");
else
{
        System.Console.WriteLine($"Число {number} не кратно числу {number2} и/или числу {number3}");
    
}
//работат только тогда когда ОБА УСЛОВИЯ ВЫПОЛНЕНЫ в строке 5 иначе не выполняется
