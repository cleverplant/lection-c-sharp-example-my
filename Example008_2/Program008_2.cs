/* 
ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
|          int       |   Max   |    (int   |      arg1,   |   int arg2, | int arg3)   */   
int Max(int arg1, int arg2, int arg3) //int Max(int arg1, int arg2, int arg3)

{
    int max_result = arg1; // int max = a;
    if (arg2 > max_result) max_result = arg2; // if(b > max) max = b;
    if (arg3 > max_result) max_result = arg3; // if(c > max) max = c;
   
    return max_result;
}
int a = 112;
int b = 211;
int c = 39;
// int max = a;
// if(b > max) max = b;
// if(c > max) max = c;
// Console.WriteLine(max);

int max = Max(a, b, c);
Console.WriteLine(Max(a, b, c));
Console.WriteLine(max);
