public static class Lib
{
    public static void hideIt(string a)
    {
        System.Console.WriteLine();
        System.Console.WriteLine(a);
        Console.ReadLine();
        System.Console.WriteLine();
    }

    public static void taskOne(int m, int n)
    {
        if (m <= n)
        {
            System.Console.Write ($" {m} ");
            Lib.taskOne(m + 1, n);
        }
    }

    public static int taskTwo(int m, int n)
    {
        
        if ( m<=n) 
        {
            return m + Lib.taskTwo (m+1, n);
        }
        return 0 ;

    }
}
