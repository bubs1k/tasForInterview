//Есть 2 массива, необходимо их обьединить

int[] firstArrrayRandomNumbers = { 3, 2, -11 };
int[] secondArrayRandomsNumber = { 7, 6, 11 };

int[] megaArray = firstArrrayRandomNumbers.Concat(secondArrayRandomsNumber).ToArray();

foreach (int i in megaArray)
{
    Console.WriteLine(i);
}

//Результат работы программы:
//3
//2
//- 11
//7
//6
//11