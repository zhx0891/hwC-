// Console.WriteLine("Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Нажмите ENTER");
// Console.ReadLine();
// System.Console.WriteLine();

// double[,] exmArr = new double[5, 5];

// exmArr = MyLib.giveMeFullTwoDimensionalArray(5, 5);
// System.Console.WriteLine();System.Console.WriteLine();

// Console.WriteLine("Массив создан. Нажмите ENTER");
// Console.ReadLine();
// System.Console.WriteLine();

// MyLib.sortLineDoubleArrayUptoDown(exmArr);
// System.Console.WriteLine();
// System.Console.WriteLine();
// Console.WriteLine("Строки массива отстортированы . Нажмите ENTER");
// Console.ReadLine();

// Console.WriteLine("Задача 2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Нажмите ENTER");
// Console.ReadLine();
// System.Console.WriteLine();



// double [] arrSumm = new double[exmArr .GetLength(0)];
// for (int i = 0; i < exmArr.GetLength(0); i++)
// {
//     double lineSum = 0;
//     for (int j = 0; j < exmArr.GetLength(1); j++)
//     {
//         lineSum =lineSum +exmArr[i,j];
//     }
//     arrSumm[i] = lineSum ;
   
// }
// int indMin = 0;
// double min = arrSumm[0];
// for (int i = 0; i < arrSumm.Length; i++)
// {
//      if(arrSumm[i] < min )
//      {
//         indMin = i;
//         min = arrSumm [i];
//      }
// }
// System.Console.WriteLine($" {indMin+1}  строка при отсчёте от 1");
// System.Console.WriteLine();
// System.Console.WriteLine();
Console.WriteLine("Задача 3.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Нажмите ENTER");
Console.ReadLine();
System.Console.WriteLine();
int [,,] arrForThirdTask = new int [2,2,2];
Random rand = new Random();
for (int i = 0; i < arrForThirdTask.GetLength(0); i++)
{
    for (int j = 0; j < arrForThirdTask.GetLength(1); j++)
    {
        for (int s = 0; s < arrForThirdTask.GetLength(2); s++)
        {
          arrForThirdTask[i,j,s] = rand.Next(10, 100);
          System.Console.WriteLine($"{arrForThirdTask[i,j,s]} ( {i},{j},{i})"); 
        }
    }
}



