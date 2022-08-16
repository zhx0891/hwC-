public static class MyLib
{
    public static int numToStep(int n, int step)
    {
        int incr = n;

        for (int i = 1; i!=step; i++)
        {
            n = n * incr;
        }
        return n;
    }

    public static int getIndexes(int num)   
    {
        int digit = 10;
        int stp =1;
        

        while (num > digit)
        {
            stp++;
            digit = numToStep (10, stp);
            System.Console.WriteLine(" "+digit+" "+stp);
        }
        return stp;
    }
}