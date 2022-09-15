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
Elements .showArr(arr);