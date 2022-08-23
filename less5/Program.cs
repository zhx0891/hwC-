
System.Console.WriteLine("Первая задача.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. Нажмите ENTER ");
System.Console.ReadLine();
int expFirst = 0;
int expSecond =0;
int[] workArr = new int[24];

workArr = MyLib.giveFullIntArray(3, 24);
for (int i = 0; i < workArr .Length; i++)
{
    if ((workArr[i] % 2) == 0) {expFirst = expFirst + workArr[i];}
}
System.Console.WriteLine($" сумма чётных чисел в массиве {expFirst}");
System.Console.WriteLine();
System.Console.WriteLine("Вторая задача. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. Нажмите ENTER ");
System.Console.ReadLine();
for (int i = 0; i < workArr.Length ; i++)
{
    if ((i%2)==0){expSecond= expSecond + workArr[i];} 
}
System.Console.WriteLine($" сумма чисел на чётных позициях в массиве равна {expSecond}");
System.Console.WriteLine();

