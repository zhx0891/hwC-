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
        for (i = (count-1); i >= 0; i--)
        {
            x++;
            // if (i == 0 )
            // {
                arr[i] = num % (numToStep(10, x));
            // }
            // else 
            // {
            //     arr[i] = arr[i]/numToStep(10, i+1);   
            // }
            System.Console.WriteLine(arr[i] + " " + i);
        }
        return arr;
    }
}