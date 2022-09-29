// Доп задача 1: Напишите программу, в которой нужно ввести элемент массива и 
// отсортировать массив по убыванию.
// 165 163 160 160 157 157 155 154
// Ввести число 162

Console.Clear();
Console.WriteLine("Введите число n (рост ученика) от 150 до 200): ");
int n=Convert.ToInt32(Console.ReadLine());
int[] array = {165, 163, 160, 160, 157, 157, 155, 154, + n};

 void PrintArray(int[] array)
 {
     int count = array.Length;
     int i = 0;
     while (i < count)
     {
         Console.Write($"{array[i]}"+", ");
         i++;
     }
 Console.WriteLine();
 }

void SelectionSort(int[] array)
{
     for (int i=0; i<array.Length; i++)
     {
        int maxPosition = i;
           for (int j=i+1; j<array.Length; j++)
        {
            if (array[j]>array[maxPosition]) maxPosition=j;
            int temporary = array[i];
            array[i]=array[maxPosition];
            array[maxPosition]=temporary;
        }
    }
}

 //PrintArray(array);
 SelectionSort(array);
 PrintArray(array);

