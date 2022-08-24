
System.Console.WriteLine("Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Нажмите ENTER ");
Console.ReadLine();
System.Console.WriteLine("Введите значение М");
int M = Convert .ToInt32(Console.ReadLine());
System.Console.WriteLine($" Чисел больше нуля было введено {MyLib .countMyNumGreaterZero(M)}");