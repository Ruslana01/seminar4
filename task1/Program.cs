﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine());
int number = a;

for (int i = 1; i < b; i++)
{
number = number * a;
}
Console.WriteLine("A в степени B равно: " + number);