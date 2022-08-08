/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма равна " + sumNum(num));


int sumNum(int number)
{
    int i = 0;
    int sum = 0;
    while (number > 0)
    {
        i = number % 10;
        sum = sum + i;
        number = number / 10;
    }
    return sum;
}