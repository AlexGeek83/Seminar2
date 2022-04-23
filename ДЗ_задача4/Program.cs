// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

//System.Console.WriteLine("Введите цифру от 1 до 7 ");
//string number = Console.ReadLine();
//if(number == "1" && number == "2" && number == "3" && number == "4" && number == "5")
//{
 //   Console.WriteLine("Рабочий день!");
//}
//else
//{
//    Console.Write("Выходной день!");
//    Console.WriteLine(number == "6" && number == "7");
//} 


int numberday = 5;
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result = "";

if (numberday > 5) Result = $". Выходной день!";
else Result = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{numberday}-й день недели - это {Days[numberday - 1]}{Result}");
