/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,10);
    }
    return arr;
}

int[] Array = FillArray(size);
for (int  i=0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}
