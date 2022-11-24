//Пользователь вводит числа, и программа их запоминает.
//Как только пользователь укажет, что хочет узнать сумму, программа выведет сумму всех веденных чисел.

int sum = 0;

while (true)
{
    Console.Write("Введи число: ");
    int enteredNumber = int.Parse(Console.ReadLine());

    sum = sum + enteredNumber;

    Console.WriteLine("Желаете узнать сумму (да/нет)");
    string userAnswer = Console.ReadLine();

    if (userAnswer == "да")
    {
        Console.WriteLine(sum);
        break;
    }
}
