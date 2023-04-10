﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ExpTo(int numA, int numB)
{
  int result = 1;
  for(int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = ExpTo(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {exponentiation}");