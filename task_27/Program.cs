// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);

int summa=0;
int ostatok=0;
int result=0;
int n1=n;

int i=0;
int count=i;

while (n<10)
{ 
    if (count<3)
    {
        Console.WriteLine("Вы издеваетесь? Введено однозначное число, введите другое! ");
        n=Convert.ToInt32(Console.ReadLine());
        count=count+i;
        i++;
    }
    else
    {
        Console.WriteLine("Вы иcчерпали количество попыток ");  
        break;
    }  
    n1=n;
}

if (n==10)
{
    Console.WriteLine("Сумма цифр в числе 10 = 1"); 
}

while (n1>10)// 123 //12
{
    {
        ostatok = n1 % 10;//3  //2
        summa = summa + ostatok;//0+3 //3+2
        n1=n1/10;//123:10=12 //12:10=1
        i++;
    }
    if (n1<10)
    {   
        result=summa+n1;
        Console.WriteLine($"Сумма цифр во введенном числе {n} = " + result);
    }
}

