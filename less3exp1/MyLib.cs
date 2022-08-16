public static class MyLib
{
    public static int numToStep(int num, int step)
    {
        int incr = num;

        for (int i = 1; i != step; i++)
        {
            num = num * incr;
        }
        return num;
    }

    public static int getIndexes(int num)   
    {
        int digit = 10;
        int stp =1;  
        while (num > digit)
        {
            digit = numToStep (digit, stp);
        }
        return stp;
    }
}