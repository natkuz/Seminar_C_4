/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumDigitsInNumber(int numberForSumDigits)
{
    int result = 0;
    while (numberForSumDigits != 0)
    {
        int digit = numberForSumDigits % 10;
        result = result + digit;
        numberForSumDigits = numberForSumDigits / 10;
    }
    return result;
}

System.Console.WriteLine("Enter number:");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Sum digits in number = {SumDigitsInNumber(number)}");