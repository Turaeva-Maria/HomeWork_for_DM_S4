﻿// Задача 25. Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число (для возведения в степень): ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (саму степень): ");
int m=Convert.ToInt32(Console.ReadLine());

int result=1;
for (int i=1; i<=m;i++)
{
    result=result*n;
    
}

Console.WriteLine($"Число {n} в степени {m} равно = {result}");

