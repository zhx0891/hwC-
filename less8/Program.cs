MyLib.hideIt("Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Нажмите ENTER");
double[,] exmArr = new double[5, 5];
exmArr = MyLib.giveMeFullTwoDimensionalArray(5, 5);
MyLib.hideIt("Массив создан. Нажмите ENTER");
MyLib.sortLineDoubleArrayUptoDown(exmArr);
MyLib.hideIt("Строки массива отстортированы . Нажмите ENTER");
MyLib.hideIt("Задача 2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Нажмите ENTER");
double[] arrSumm = new double[exmArr.GetLength(0)];
arrSumm=MyLib.giveMeLineSumArr(exmArr);

int indMin = 0;
double min = arrSumm[0];
for (int i = 0; i < arrSumm.Length; i++)
{
    if (arrSumm[i] < min)
    {
        indMin = i;
        min = arrSumm[i];
    }
}

MyLib .hideIt ($" {indMin + 1}  строка при отсчёте от 1");

MyLib.hideIt("Задача 3.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Нажмите ENTER");
int[,,] arrForThirdTask = new int[2, 2, 2];
Random rand = new Random();
int count = 1;
for (int i = 0; i < arrForThirdTask.GetLength(0); i++)
{
    for (int j = 0; j < arrForThirdTask.GetLength(1); j++)
    {
        for (int s = 0; s < arrForThirdTask.GetLength(2); s++)
        {
            arrForThirdTask[i, j, s] = 10 * count;
            count++;
            System.Console.WriteLine($"{arrForThirdTask[i, j, s]} ( {i},{j},{s})");
        }
    }
}
MyLib .hideIt ("Задача 4. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Нажмите ENTER.");

exmArr =MyLib .multiplicationArray(exmArr,exmArr);
MyLib.hideIt("это было увлекательно");


