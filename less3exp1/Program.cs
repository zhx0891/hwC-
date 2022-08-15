Console.WriteLine("?");
int a = Convert .ToInt32(Console.ReadLine());
int digit =10; 
int indexes  = 1;

while (a > digit )
{
    indexes ++;
    digit = digit * 10;
}
System.Console.WriteLine(indexes + " "+ digit  );