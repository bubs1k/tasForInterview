//метод, работающий с переменным количеством параметров

int Sum(params int[] parametrs)
{
    int result = 0;

    for (int i = 0; i < parametrs.Length; i++)
    {
        result += parametrs[i];
    }

    return result;
}

Console.WriteLine(Sum(1, 3, -10));

//Результат работы программы:
//-6
