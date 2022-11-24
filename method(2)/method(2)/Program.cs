//Создать метод, использующий переменное количество параметров в методе для поиска минимального значения из заданного списка.

int MyMethod(params int[] inputs)
{
    int max = inputs.Min();
    return max;
}

Console.WriteLine(MyMethod(1, 13, -10));

//Результат работы программы:
//-10