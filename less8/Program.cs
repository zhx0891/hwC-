Console.WriteLine("Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Нажмите ENTER");
Console.ReadLine();
System.Console.WriteLine();

double[,] exmArr = new double[5, 5];

exmArr = MyLib.giveMeFullTwoDimensionalArray(5, 5);
System.Console.WriteLine();System.Console.WriteLine();

Console.WriteLine("Массив создан. Нажмите ENTER");
Console.ReadLine();
System.Console.WriteLine();

MyLib.sortLineDoubleArrayUptoDown(exmArr);
System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine("Строки массива отстортированы . Нажмите ENTER");
Console.ReadLine();
