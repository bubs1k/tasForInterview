using System;
using System.Threading;
using System.Threading.Tasks;

/*Консольное приложение.Создать две фоновые асинхронные задачи первая пишет в канал числа от 1 до 10 в первый канал.
Вторая пишет во второй канал числа от 10 до 100 десятками.
В обеих задачах пауза между записью элементов это каждый раз случайное число миллисекунд от 500 до 1000. 
в основном методе сделать комбинированное чтения из обоих каналов..результат согласованного чтения выводить в консоль.
выход после завершения чтения из обоих каналов.*/



namespace TestTask2
{
    public class Program
    {
        static void WriteFirst()
        {

            for (int i = 1; i < 11; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(500, 1000);

                Thread.Sleep(random);

                Console.WriteLine("WriteFirst " + i);
            }
        }

        static void WriteSecond()
        {
            
            for (int i = 10; i < 110; i += 10)
            {
                Random rnd = new Random();
                int random = rnd.Next(500, 1000);

                Thread.Sleep(random);

                Console.WriteLine("WriteSecond " + i);
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(WriteFirst);
            Thread thread2 = new Thread(WriteSecond);

            thread1.Start();
            thread2.Start();
        }

    }

}

