int number = 25;
int number2 = 7;
int number3 = 23;

if(number % number2 == 0 || number % number3 == 0) // оператор "ИЛИ" ||  
    Console.WriteLine("Верно!");
else
System.Console.WriteLine("НЕ ВЕРНО!");

//Выполняется если хотя бы ОДНО значение выполняется, если оба нет то и ничего не выполнено, т.е. НЕ ВЕРНО
