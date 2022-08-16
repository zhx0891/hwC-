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
        }
        return stp;
    }

    public static int [] intToArray(int num, int count)
{
int [] arr = new int [count];
for(int i = (count-1); i >=0; i--)
{
 System.Console.WriteLine(i);
//  int r =numToStep (10, count ); 
//  System.Console.WriteLine(r);  
}
return arr ;
}
}