// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void OneArray(int[] array)
 {
     int length = array.Length;
     int i = 0;
     Console.WriteLine("Введите 8 элементов массива (ячейки от [0] до [7]):");
     while (i < length)
     {
         Console.Write($"[{i}]:");
         int n = Convert.ToInt32(Console.ReadLine());
         array[i] = n;
         i++;
     }
 }
 void PrintArray(int[] arr)
 {
     int count = arr.Length;
     int i = 0;
     while (i < count)
     {
         Console.Write(arr[i] + " ");
         i++;
     }
 }
 int[] array = new int[8];
 int count = array.Length;
 OneArray(array);
 PrintArray(array);

