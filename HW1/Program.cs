/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(degree(a, b));

int degree(int first, int second)
{
    int resss = 0;
    if (second == 1)
    {
        int resss = first;
    }
    else
    {
        for (int i = 2; i <= second; i++)
        {
            int resss = first * first;
        }
    }
    return resss;
}


