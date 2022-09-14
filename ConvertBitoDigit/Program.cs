using System;

System.Console.WriteLine("Введите двоичное число");
string num = "1010101";
int [] biNum = new int [num.Length];
int leng=biNum.Length;
for (int i = 0; i < num.Length; i++)
{
    if((num[i].Equals('0'))||(num[i].Equals('1')))
    {
        biNum[(leng-i)-1]=(num[i]-'0');
    }
    else
    {
        System.Console.WriteLine("это не двоичное число");
    }
}

for (int i = 0; i < biNum.Length; i++)
{
    System.Console.Write(biNum[i] + " ");
}
int digNum=0;
for (int i = 0; i <biNum.Length; i++)
{
    int step =1;
    for (int j = 0; j < i; j++)
    {
    step=step*2;
    }
    
    digNum=digNum+(biNum[i]*step);
}
System.Console.WriteLine(digNum);
