//С помощью Random получить число randomNumber, которое не больше 100. 
//Найти сумму всех положительных чисел меньше меньше числа Random number (включая число), 
//которые кратные 3 или 5. (К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.)

Random rnd = new Random();

int sum = 0;

int randomNumber = rnd.Next(0, 99);

for (int i = randomNumber; i > 0; i--)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine(sum);

//Результат работы программы:
//1673