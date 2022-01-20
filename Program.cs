using System;

namespace Homework
{
    class Program
    {

        enum Seasons
        {
            Winter, Spring, Summer, Autumn
        }

        static void Main()
        {
            Console.WriteLine("Задание 1");
            {
                int n = 3;
                string[] fullName = new string[n];
                for (int i = 0; i < fullName.Length; i++)
                {
                    Console.WriteLine("Введите фамилию");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Введите имя");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Введите отчество");
                    string patronymic = Console.ReadLine();

                    if (string.IsNullOrEmpty(firstName.Trim(' ')) || string.IsNullOrEmpty(lastName.Trim(' ')) || string.IsNullOrEmpty(patronymic.Trim(' ')))
                    {
                        Console.WriteLine("Вы нчиего не ввели в одном из параметров, пожалйста, постарайтесь больше так не делать =)");
                        i--;
                    }
                    else
                    {
                        Console.WriteLine();

                        string tempFullName = GetFullName(lastName, firstName, patronymic);
                        Console.WriteLine("Полное имя пользователя");
                        Console.WriteLine(tempFullName);

                        fullName[i] = tempFullName;

                        Console.WriteLine();
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Полные имя 3-x пользователей : ");
                for (int i = 0;i< fullName.Length; i++)
                {
                    Console.WriteLine(i + " : " + fullName[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Задане 2");
            {
                Console.WriteLine("Введите набор чисел через пробел");

                bool isEmpty = true;

                while(isEmpty)
                {
                    string numbers = Console.ReadLine();

                    if (string.IsNullOrEmpty(numbers.Trim(' ')))
                    {
                        Console.WriteLine("У вас пустая строка, я не знаю, что с ней делать, пожалйста, повторить попытку");
                    }
                    else
                    {
                        Console.WriteLine("Сумма ваших чисел равна = " + SumNumbers(numbers.Trim()));
                        isEmpty = false;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Задание 3");
            {
                bool isNotTrueNumberOfSeason = true;

                while (isNotTrueNumberOfSeason)
                {
                    Console.WriteLine("Введите порядковый номер времени года");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number > 0 && number <=12)
                    {
                        Console.WriteLine(GetSeason(number));
                        isNotTrueNumberOfSeason = false;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Задание 4");
            {
                Console.WriteLine("Введите количество значений, которое вы хотите посчитать");

                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ваше число = " + GetFibonacciNumber(n));

            }
        }

        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }

        static int SumNumbers(string numbers)
        {
            numbers += " ";
            string number = "";
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == ' ')
                {
                    sum += Convert.ToInt32(number);
                    number = "";
                }
                else
                {
                    number += numbers[i];
                }
            }

            return sum;
        }

        static string GetSeason(int number) // всё делал исходя из методички.
        {
            if (number > 2 && number < 6)
            {
                return GetSeasonEnum(Seasons.Spring);
            }
            else if (number > 5 && number < 9)
            {
                return GetSeasonEnum(Seasons.Summer);
            }
            else if (number > 8 && number < 12)
            {
                return GetSeasonEnum(Seasons.Autumn);
            }
            else
            {
                return GetSeasonEnum(Seasons.Winter);
            }
        }

        static string GetSeasonEnum(Seasons seasons)
        {
            return seasons switch
            {
                Seasons.Winter => "Зима",
                Seasons.Spring => "Весна",
                Seasons.Summer => "Лето",
                Seasons.Autumn => "Осень",
                _ => "",
            };
        }

        static int GetFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }
    }
}