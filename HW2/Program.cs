/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

Random random = new Random();
int random1 = random.Next(100,1000);

Console.WriteLine(random1);

int temp = random1 % 100;

int secondnumber = temp / 10;

Console.WriteLine(secondnumber); */

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6  

Console.WriteLine("Введите число, а я выведу третью цифру данного числа");

int number = int.Parse(Console.ReadLine());

int number1 = number;

if (number < 100){
    Console.WriteLine("Третьей цифры нет");
}
else { while (number1 > 999){
    number1 /= 10;
 }
number1 %= 10;
Console.WriteLine(number1);
}    */

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет   */

Console.WriteLine("Введите число, а я скажу является ли этот день выходным");

int a = int.Parse(Console.ReadLine());

if (a < 6 & a > 0){
    Console.WriteLine("Не является");
}

if (a < 8 & a > 5){
    Console.WriteLine("Является");
}

if (a < 1 | a > 7){
    Console.WriteLine("Такого дня недели не существует");
}