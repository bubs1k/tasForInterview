﻿//Дано n(1 ≤ n ≤ 27). Найти количество трехзначных натуральных чисел,
//которые кратны n

Random rnd = new Random();
int n = rnd.Next(1, 27);

Console.WriteLine($"(Случайным числом является: {n})");

int count = 0;

for (int i = 100; i < 1000; i++)//все трехзначные числа находятся в диапозоне от 100 до 1000
{
    if (i % n == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел от 100 до 1000, которые кратны {n} составило: {count}");

//Результат работы программы:
//(Рандомным числом является: 18)
//Количество чисел от 100 до 1000, которые делятся на 18 составило: 50