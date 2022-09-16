// Меняем первую и последнюю строку местами.
int temp = 0;
int[,] arr = new int[5, 5];
arr = Elements.giveMeFullArr();

int lastString = arr.GetLength(0) - 1;
for (int i = 0; i < arr.GetLength(1); i++)
{
    temp = arr[lastString, i];
    arr[lastString, i] = arr[0, i];
    arr[0, i] = temp;
}
System.Console.WriteLine();
Elements.showArr(arr);
// //Меняем строки на столбцы.
arr = Elements.replaceStrToRows(arr);
System.Console.WriteLine();
Elements.showArr(arr);
System.Console.WriteLine();
// найти наименьший элемент и удалить строку и столбец его содержащие
int minX = Elements.giveMeMin(arr).minX;
int minY = Elements.giveMeMin(arr).minY;
System.Console.WriteLine();
System.Console.WriteLine($"minX = {minX} minY = {minY}");
int[,] minArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
int count = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    if (i == minX) { i++; }
    if ((i == minX) && (i == (arr.GetLength(0) ^ 1))) { continue; }
    System.Console.WriteLine();
    int countY = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if ((j == minY) && (j == (arr.GetLength(0) ^ 1)))
        {
            continue;
        }
        else
        {
            if (j == minY) 
            {
                j++;
                minArr[count, countY] = arr[i, j];
                countY++;
            }
            else
            {
                minArr[count, countY] = arr[i, j];
                countY++;
            }
        }
        

    }
    count++;
}
Elements.showArr(minArr);
