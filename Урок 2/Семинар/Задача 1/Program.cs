﻿/*
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа. 
78 -> 8 12-> 2 85 -> 8
*/

int getRandomNumberFromRange(int minBorder, int MaxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder,MaxBorder + 1);
    return result;
}

int getmaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while (number > 0)
    {
        int currentDigit = number % 10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
    }
    return maxDigit;
}

int randomNumber = getRandomNumberFromRange(10,9999);
Console.WriteLine($"Случайное значение {randomNumber}");
int maxDigit = getmaxDigitFromNumber(randomNumber);
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit}");