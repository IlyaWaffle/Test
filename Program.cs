/*    Напишите программу, которая выводит случайное число из 
отрезка [10, 99] и показывает наименьшую цифру числа.  */

// Task 11
int n = new Random().Next(10, 100);

int left = n / 10;
int right = n % 10;

int dig = right;

if (left < right)
    dig = left;

Console.Write($"{n} -> {dig}");

