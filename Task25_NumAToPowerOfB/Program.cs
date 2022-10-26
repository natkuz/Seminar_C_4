/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int FirstToPowerOfSecond(int first, int second)
{
    if (second >= 1)
    {
        int result = 1;
        for (int i = 1; i <= second; i++)
        {
            result = result * first;
        }

        return result;
    }
    else
    {
        return -1;
    }
}

System.Console.WriteLine("Введите число а, затем его степень b:");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
System.Console.WriteLine($"Число а в степени b = {FirstToPowerOfSecond(numberA, numberB)}");