//  public static MyLib 
System.Console.WriteLine(" ? ");
int N = Convert .ToInt32(System.Console.ReadLine());
int [] array = new int [N+1];
for(int i =1; i <= N; i++)
{
  array [i-1] =  MyLib .numToStep(i, 3);
  System.Console.Write(" " + array [i-1]);
}