﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;
// Задача 25: 
Clear();

// void RaiseNumberInPower(int A, int B)
// {
//     double result = Math.Pow(A, B);
//     Write($"Число A  в степени B = {result:f2}");
// }
// WriteLine("Введите два числа (A и B) чтобы возвести число A в натуральную степень B: ");
// RaiseNumberInPower(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));

//  Что значит число A в степени B? Это значит число A умножается само на себя B раз... ( теперь мы знаем что происходит в теле цикла и точку выхода из цикла)
//  В первую степень можно возвести любое число. Каким бы ни было это число — целым, дробным, положительным, отрицательным, рациональным или иррациональным — при возведение в степень 1 в результате получаем то же самое число
//  При умножении чисел нет смысла начинать с нуля потому что при умножении на 0 также будет 0. Соответственно если у нас последовательность чисел перемножается  - то всё это обратилось бы в 0 ( Теперь мы знаем точку входа в цикл)

//  Мы циклически перемножаем введенное первое число на самого себя и результат этих действий добавляем в переменную счётчик с каждым витком цикла пока мы не выйдем из цикла
int RaiseNumberInPower(int a, int b)
{
    int result = 1;    // как вариант можно было положить в result наше число a
    for (int i = 0; i < b; i++) //  int result = a  --> тогда цикл начинался бы с единицы...
    {
        result *= a;
    }
    return result;
}
WriteLine("Введите два числа (a и b) чтобы возвести число a в натуральную степень b: ");
int answer = RaiseNumberInPower(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
Write(answer);