//twenty one game.

int countPointFirstUser = 0;//сумма очков первого пользователя
int countPointSecondUser = 0;//сумма очков второго пользователя

List<int> arrayCards = new List<int>() { 2, 2, 2, 2,
                                         3, 3, 3, 3,
                                         4, 4, 4, 4,
                                         6, 6, 6, 6,
                                         7, 7, 7, 7,
                                         8, 8, 8, 8,
                                         9, 9, 9, 9,
                                         10, 10, 10, 10,
                                         11, 11, 11, 11};//колода(массив карт)

Console.Write("Ник первого пользователя:");
string firstNickname = Console.ReadLine();//пользователь номер 1 вводит свой ник

while (true)
{
    Console.WriteLine("Сумма очков пользователя " + firstNickname + ": " + countPointFirstUser);
    Console.WriteLine("Хотите взять еще?(да/нет)");

    string userAnswer = Console.ReadLine();

    if (userAnswer == "да")
    {
        Random random = new Random();
        int randomCards = random.Next(0, 20);//создал переменную randomCards от 0 до 20 что бы
                                             //доставать случайную карту номиналом от 0й карты  до 20й  
        countPointFirstUser = countPointFirstUser + arrayCards[randomCards];

        arrayCards.Remove(arrayCards[randomCards]);//удаляю карту, которую взял пользователь из массива карт

        if (countPointFirstUser > 21)
        {
            Console.WriteLine("Сумма ваших очков больше 21. Вы проиграли." + " Сумма ваших очков составила " + countPointFirstUser);
            return;
        }
    }
    else
    {
        Console.WriteLine("Сумма очков пользователя пользователя " + firstNickname + " составила: " + countPointFirstUser);
        break;
    }




}

Console.WriteLine("");//обыкновенный отступ в строчку. для удобства восприятия пользователя

Console.Write("Ник второго пользователя:");
string secondNickname = Console.ReadLine();//пользователь номер 2 вводит свой ник

while (true)
{
    Console.WriteLine("Сумма очков пользователя " + secondNickname + ": " + countPointSecondUser);
    Console.WriteLine("Хотите взять еще?(да/нет)");

    string userAnswer = Console.ReadLine();

    if (userAnswer == "да")
    {
        Random random = new Random();
        int randomCards = random.Next(0, 20);//создал переменную randomCards от 0 до 20 что бы
                                             //доставать случайную карту номиналом от 0й карты  до 20й 
        countPointSecondUser = countPointSecondUser + arrayCards[randomCards];

        arrayCards.Remove(arrayCards[randomCards]);//удаляю карту, которую взял пользователь из массива карт

        if (countPointSecondUser > 21)
        {
            Console.WriteLine("Сумма ваших очков больше 21. Вы проиграли." + " Сумма ваших очков составила " + countPointSecondUser);
            break;
        }
    }
    else
    {
        Console.WriteLine("Сумма очков пользователя пользователя " + secondNickname + " составила: " + countPointSecondUser);
        break;
    }


}

if (countPointFirstUser > countPointSecondUser)
{
    Console.WriteLine("Пользовтель " + firstNickname + " победил");
    Console.WriteLine("У " + firstNickname + " " + countPointFirstUser + " очков," + " у " + secondNickname + " " + countPointSecondUser + " очков");

}
else
{
    Console.WriteLine("Пользователь " + secondNickname + " победил");
    Console.WriteLine("У " + firstNickname + " " + countPointFirstUser + " очков," + " У " + secondNickname + " " + countPointSecondUser + " очков");
}
