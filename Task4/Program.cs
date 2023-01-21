//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int number = new Random().Next(100, 999);
Console.WriteLine(number);
int third = number % 10;
int first = number / 100;
int result = first * 10 + third;
Console.WriteLine(result);
