/*Random random = new Random();
int randomValue1 = random.Next(1,10);
int randomValue2 = random.Next(0,10);
int randomValue3 = random.Next(0,10);

Console.WriteLine($"{randomValue1}{randomValue2}{randomValue3}");

Console.WriteLine($"{randomValue1}{randomValue3}");*/




/*Задача No12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4

Random random = new Random();
int randomValue1 = random.Next(1,100);
int randomValue2 = random.Next(1,10);

Console.WriteLine($"{randomValue1},{randomValue2}");

int ost = randomValue1 % randomValue2;

if (ost == 0){
    Console.WriteLine("Кратно");
}
else {
    Console.WriteLine($"Не кратно, остаток {ost}");
}*/


/*Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.

while(true){
    Random random = new Random();
    int randomValue1 = random.Next(1,1000);

    int ost1 = randomValue1 % 7;
    int ost2 = randomValue1 % 23;

    Console.Write(randomValue1);
    if (ost1 == 0 & ost2 == 0){
    Console.WriteLine(" Да");
    break;
    }    
    else Console.WriteLine(" Нет");
}*/


/*Задача No16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет*/

while (true){
Random random = new Random();
int randomValue1 = random.Next(1,10);
int randomValue2 = random.Next(1,100);

Console.WriteLine($"{randomValue1},{randomValue2}");

if (randomValue1 * randomValue1 == randomValue2){
    Console.WriteLine("Да");
    break;
}
else Console.WriteLine("Нет");
}