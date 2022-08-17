public static class MyLib
{
    public static int numToStep(int n, int step)
    {
        int incr = n;

        for (int h = 1; h != step; h++)
        {
            n = n * incr;
        }
        return n;
    }

    public static int getIndexes(int num)
    {
        int digit = 10;
        int stp = 1;


        while (num > digit)
        {
            stp++;
            digit = numToStep(10, stp);
        }
        return stp;
    }

    public static int[] intToArray(int num, int count)
    {
        int i, x = 0;
        int[] arr = new int[count];
        for (i = 0; (count-1) > i; i++)
        {
            x++;
            arr[i] = num / (numToStep(10, x));
            if (i > 0)
            {
                arr[i] = arr[i]%10;
            }
            System.Console.WriteLine(arr[i]);
        }
        return arr;
    }
}