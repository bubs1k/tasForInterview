//Создайте переменную типа string, в которой хранится пароль 
//для доступа к тайному сообщению. Пользователь вводит пароль,
//далее происходит проверка пароля на правильность, и если пароль неверный,
//то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение.
//Если пользователь неверно ввел пароль 3 раза, программа завершается.

string password = "in my beginning my end";
string secretMessage = "you can";

int tryCount = 0;

while (tryCount < 3)
{
    Console.Write("Твой пароль:");
    string enteredPassword = Console.ReadLine();

    if (enteredPassword == password)
    {
        Console.WriteLine(secretMessage);
        break;
    }
    else
    {
        tryCount++;
    }
}

//Результат программы при вверно введеном пароле:
//Твой пароль:1
//Твой пароль:2
//Твой пароль:in my beginning my end
//you can
//(Если пользователь трижды вводит неверный пароль программа просто завершает работу)