//тоже самое что и в задаче 4, но с помощью цикла

int[] array1 = new int [100];   // определили массив на 10 эл-тов
int index = 0;  //присваиваем индексу номер
while(index <= 99)
{
    array1[index] = new Random().Next(1, 10);
    index++;
}

index = 0;
while (index <= 99)
{
    if (index % 10 == 0) System.Console.WriteLine();  //с помощью  if (index % 10 == 0) выводим по 10 
                                                      //чисел в строке
    System.Console.Write(array1[index] + " ");   //выводим значения на экран через пробел
    index++;
}

