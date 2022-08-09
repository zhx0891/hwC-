Console .WriteLine("Введи три числа");
int a = Convert .ToInt32(Console .ReadLine());
int b = Convert .ToInt32(Console .ReadLine());
int c = Convert .ToInt32(Console .ReadLine());
int max =0;
if(a > b) 
{
    max = a; 
}
else if (b > c)
{
    max = b;
}
else 
{
    max = c;     
}
Console .WriteLine($"Максимальное число {max}");