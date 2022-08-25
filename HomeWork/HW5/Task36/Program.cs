﻿// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Введите количество элементов в массиве: ");
WriteLine($"Cумма элементов, стоящих на нечётных позициях в нашем массив: {SumOfNotEvenArrayElements(FillArrayWithRandomNumbers(int.Parse(ReadLine()!)))}");


int SumOfNotEvenArrayElements(int[] array)
{
    int sum = 0;
    //  Данное решение нерационально поскольку включает нулевой элемент массива и вообще проверяет каждый индекс элемента массива на нечётность:

    // for (int i = 0; i < array.Length; i++)
    // {
    //     sum += i % 2 == 0 ? 0 : array[i];
    // }

    // Нас в любом массиве не волнует нулевой элемент потому что фактически ноль — нечётное , не нечётное & не положительное и неотрицательное число...
    // Начнём цикл с единицы и сделаем шаг таким чтобы цикл обращался только к нечётному индексу и каждый элемент соответствующий такому индексу положим в сумму.

    for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
    return sum;
}


int[] FillArrayWithRandomNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    WriteLine($"Массив заполненный случайными числами в диапазоне [-10,10] выглядит вот так: [{String.Join(",", array)}]");
    return array;
}