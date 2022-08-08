int max = 0, min =0;
int value1 = Convert.ToInt32(Console. ReadLine());
int value2 = Convert.ToInt32(Console .ReadLine());
if(value1 > value2) 
{
max = value1;
min = value2;
}
else
{
max = value2;
min = value1;   
}

 Console .WriteLine($"Максимальное число {max}  минимальное {min} ");