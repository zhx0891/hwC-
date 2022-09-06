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
     public static int akMan(int m, int n)
    {
        if (m < 0 || n < 0) { System.Console.WriteLine(" m и n должны быть больше нуля");};
        if (m == 0) return n + 1;
        if (n == 0) return akMan (m - 1, 1);
        return akMan (m - 1, akMan (m, n - 1));
    }
}
