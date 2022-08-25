
// System.Console.WriteLine("Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Нажмите ENTER ");
// Console.ReadLine();
// System.Console.WriteLine("Введите значение М");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($" Чисел больше нуля было введено {MyLib.countMyNumGreaterZero(M)}");
///////////////////////////////////////////////////////////////////////////////////////////////
System.Console.WriteLine("Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями. Нажмите ENTER ");
Console.ReadLine();
System.Console.WriteLine("Прямая задаётся формулой y=kx+b, задайте значения для k и b");
System.Console.WriteLine(" значение для k1");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" значение для b1");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" значение для k2");
double k2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" значение для b2");
double b2 = Convert.ToInt32(Console.ReadLine());
double [] arrPoint = new double [2];

arrPoint = MyLib.pointIntersectionLines(k1, k2, b1, b2).arr;
System.Console.WriteLine($"значение x = {MyLib.pointIntersectionLines(k1, k2, b1, b2).x} значение y = {MyLib.pointIntersectionLines(k1, k2, b1, b2).y}");
