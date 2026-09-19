using System;

class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    static int TasksCount = 4;

    private void Run()
    {
        while (true)
        {
            int currentTask = 0;
            Console.WriteLine($"Введите номер задачи 1/{TasksCount}");

            try
            {
                currentTask = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine($"Нужно ввести номер задачи 1/{TasksCount}");
                continue;
            }

            switch (currentTask)
            {
                case 1:
                    FirstTask();
                    break;
                case 2:
                    SecondTask();
                    break;
                case 3:
                    ThirdTask();
                    break;
                case 4:
                    FourTask();
                    break;
                default:
                    Console.WriteLine($"Нужно вводить номер задачи 1/{TasksCount}");
                    break;
            }
        }
    }

    private void FirstTask() // Упражнение 1 с сайта https://metanit.com/sharp/practice/1.2.php
    {
        int bankPercent = 7;
        decimal userValue = 0;
        int months = 0;

        Console.WriteLine("Введите ваш вклад:");
        try
        {
            userValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Теперь введите кол-во месяцев:");
            months = Convert.ToInt16(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Нужно вводить число!");
            return;
        }

        for (int i = 0; i < months; i++)
        {
            userValue += (userValue / 100) * bankPercent;
        }
        Console.WriteLine($"Ваша конечная сумма вклада за {months} месяц(а/ев): {userValue}");
    }

    private void SecondTask() // Упражнение 2 с сайта https://metanit.com/sharp/practice/1.2.php
    {
        int bankPercent = 7;
        decimal userValue = 0;
        int months = 0;

        Console.WriteLine("Введите ваш вклад:");
        try
        {
            userValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Теперь введите кол-во месяцев:");
            months = Convert.ToInt16(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Нужно вводить число!");
            return;
        }

        int operationCounter = 0;
        while (true)
        {
            if (operationCounter == months)
                break;

            userValue += (userValue / 100) * bankPercent;
            operationCounter++;
        }
        Console.WriteLine($"Ваша конечная сумма вклада за {months} месяц(а/ев): {userValue}");
    }

    private void ThirdTask() // Упражнение 3 с сайта https://metanit.com/sharp/practice/1.2.php
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i}*{j}={i * j} \n");
            }
            Console.WriteLine();
        }
    }

    private void FourTask() // Упражнение 4 с сайта https://metanit.com/sharp/practice/1.2.php
    {
        while (true)
        {
            int value1 = 0, value2 = 0;
            Console.WriteLine("Введите первое число в диапазоне 0-10");

            try
            {
                value1 = Convert.ToInt32(Console.ReadLine());

                if (value1 < 0 || value1 > 10)
                {
                    Console.WriteLine("Число должно быть в диапазоне 0-10");
                    continue;
                }

                Console.WriteLine("Теперь введите второе число в диапазоне 0-10");
                value2 = Convert.ToInt32(Console.ReadLine());

                if (value2 < 0 || value2 > 10)
                {
                    Console.WriteLine("Число должно быть в диапазоне 0-10");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Нужно вводить именно числа!!!");
                continue;
            }

            Console.WriteLine($"Оба числа в диапазоне 0-10 {value1}*{value2}={value1*value2}");
            break;
        }
    }
}