//В одномерном массиве из 100 чисел подсчитайте
//количество элементов, удовлетворяющих условию 0 < M[i] < 125.

int counterSuitableNumbers = 0;

int[] arrayRandomsNumbers = new int[100];

for (int i = 0; i < 100; i++)
{
    Random rnd = new Random();
    int randomNumber = rnd.Next(-1000, 1000);
    arrayRandomsNumbers[i] = randomNumber;

    if (arrayRandomsNumbers[i] > 0 && arrayRandomsNumbers[i] < 125)
    {
        counterSuitableNumbers++;
    }
}

Console.WriteLine("Количесвто элементов, удовлетворяющих условию: " + counterSuitableNumbers);

//Результат работы программмы:
//Количесвто элементов, удовлетворяющих условию: 7
