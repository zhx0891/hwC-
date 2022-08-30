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

Console.WriteLine("Задача 2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Нажмите ENTER");
Console.ReadLine();
System.Console.WriteLine();
double [] arrSumm = new double[exmArr .GetLength(0)];
for (int i = 0; i < exmArr.GetLength(0); i++)
{
    double lineSum = 0;
    for (int j = 0; j < exmArr.GetLength(1); j++)
    {
        lineSum =lineSum +exmArr[i,j];
    }
    arrSumm[i] = lineSum ;
    System.Console.WriteLine($"Строка с наименьшей суммой   {MyLib.giveMeMinMaxDoubleArr(arrSumm).min}");
}