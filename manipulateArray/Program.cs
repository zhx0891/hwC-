// Меняем первую и последнюю строку местами.
int temp = 0;
int[,] arr = new int[5, 5];
arr=Elements .giveMeFullArr();
int  lastString = arr.GetLength(0)-1;
for (int i = 0; i < arr.GetLength(1); i++)
{
    temp=arr[lastString,i];
    arr[lastString,i]=arr[0,i];
    arr[0,i]=temp;
}
System.Console.WriteLine();
Elements .showArr(arr);
//Меняем строки на столбцы.
arr=Elements .replaceStrToRows(arr);
System.Console.WriteLine();
Elements .showArr(arr);
System.Console.WriteLine();
// найти наименьший элемент и удалить строку и столбец его содержащие
int minX = Elements.giveMeMin(arr).minX;
int minY = Elements.giveMeMin(arr).minY;
int [,] minArr = new int [arr.GetLength(0)-1,arr.GetLength(1)-1];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(i!=minX||j!=minY)
        {
            minArr[i,j] = arr[i,j];
        }
    }
}
Elements.showArr(minArr);
