public static class Lib
{
    public static (int x, int y) moveRight(int x, int y, int[,] arr, int count)
    {
        int i = y;
        while ((arr[x, i] < arr.GetLength(1))&&(arr[x,i+1] < 1))
        {
            arr[x, i] = count++;
            i++;
        }
        Lib.turnRight();
    }
    public static (int x, int y) moveDown(int x, int y)
    {

    }
    public static (int x, int y) moveUp(int x, int y)
    {

    }
    public static (int x, int y) turnRight(int x, int y)
    {

    }
    public static (int x, int y) moveLeft(int x, int y)
    {

    }
}
