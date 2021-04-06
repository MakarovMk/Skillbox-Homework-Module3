using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {

        static void Main()
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!



            //link1:
            
                
            Console.Clear();
            Console.Write("Введите имя первого игрока: ");
            string user1 = Console.ReadLine();
            Console.Write("Введите имя второго игрока: ");
            string user2 = Console.ReadLine();

            int difficulty; //сложность
            int gameNumber = 0; //число, загадываемое компьютером
            int userTry_Min = 0; //минимальное число, которое может ввести игрок
            int userTry_Max = 0; //максимальное число, которое может ввести игрок

            Console.WriteLine("\nВыберите уровень сложности: \nлёгкий - 1 \nнормальный - 2 \nсложный - 3 ");
            difficulty = Convert.ToInt32(Console.ReadLine()); //игрок выбирает уровень сложности
            Random randomize = new Random();
            do
            {
                if (difficulty == 1)
                {
                    Console.WriteLine("Вы выбрали лёгкую сложность, будет загадано число от 10 до 20");
                    gameNumber = randomize.Next(10, 20);
                    userTry_Min = 1;
                    userTry_Max = 2;
                    break;
                }
                else
                    if (difficulty == 2)
                {
                    Console.WriteLine("Вы выбрали нормальную сложность, будет загадано число от 12 до 121");
                    gameNumber = randomize.Next(12, 121);
                    userTry_Min = 1;
                    userTry_Max = 4;
                    break;
                }
                else
                    if (difficulty == 3)
                {
                    Console.WriteLine("У вас много свободного времени, загадаем число побольше");
                    gameNumber = randomize.Next(100, 200);
                    Random randomize2 = new Random(); //доп. условие для высокого уровня сложности. Макс.число задаётся в диапазоне от 12 до 24
                    userTry_Min = 1;
                    userTry_Max = randomize2.Next(12, 25);
                    break;
                }
                else
                    if (difficulty < 1 || difficulty > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Такую сложность мы пока не придумали, введите число от 1 до 3");
                    difficulty = Convert.ToInt32(Console.ReadLine());
                }
            } while (difficulty > 1 || difficulty < 4);

            //do
            //{
            //    switch (difficulty) //выбор условий в зависимости от уровня сложности
            //    {
            //        case 1:
            //            Console.WriteLine("Вы выбрали лёгкую сложность, будет загадано число от 10 до 20");
            //            gameNumber = randomize.Next(10, 20);
            //            userTry_Min = 1;
            //            userTry_Max = 2;
            //            break;
            //        case 2:
            //            Console.WriteLine("Вы выбрали нормальную сложность, будет загадано число от 12 до 121");
            //            gameNumber = randomize.Next(12, 121);
            //            userTry_Min = 1;
            //            userTry_Max = 4;
            //            break;
            //        case 3:
            //            Console.WriteLine("У вас много свободного времени, загадаем число побольше");
            //            gameNumber = randomize.Next(100, 200);
            //            Random randomize2 = new Random(); //доп. условие для высокого уровня сложности. Макс.число задаётся в диапазоне от 12 до 24
            //            userTry_Min = 1;
            //            userTry_Max = randomize2.Next(12, 25);
            //            break;
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("Такую сложность мы пока не придумали, введите число от 1 до 3");
            //            difficulty = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //} while (difficulty > 1 || difficulty < 4);

            Console.WriteLine($"\nКомпьютер загадал число: {gameNumber}");

            int userTry; //число, вводимое игроками
            bool users = true;

            while (gameNumber > 0)
            {
                Console.Write($"\n{(users ? user1 : user2)}, ваш ход! Введите число от {userTry_Min} до {userTry_Max}: "); //игроки по очереди вводят числа
                userTry = Convert.ToInt32(Console.ReadLine());

                if (userTry < userTry_Min || userTry > userTry_Max)
                {
                    Console.WriteLine($"Такое число вводить нельзя, введите число от {userTry_Min} до {userTry_Max}"); //реакция на вводимое число, которое не попадает в указанный диапазон
                }
                else
                {
                    gameNumber -= userTry; //счётчик загаданного числа
                    Console.WriteLine($"\nОсталось: {gameNumber}"); 
                    users = !users;
                }
                if (gameNumber < 0) //когда загаданное число будет <0, победа присваивается игроку, который последним ввёл число, после которого загаданное максимально приблизилось к 0
                {
                    users = !users;
                    Console.WriteLine($"\nРезультат меньше нуля");
                    Console.WriteLine($"\nПобедил {(users ? user2 : user1)}, поздравляем!");
                    users = !users;
                    Console.WriteLine($"\n{(users ? user2 : user1)}, если хотите отыграться, напишите 'да'");
                    string revenge = Console.ReadLine();

                    if (revenge == "да")
                    {
                        Main();
                    }
                    else
                    {
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    if (gameNumber == 0) //условие победы
                    {
                        users = !users;
                        Console.WriteLine($"\nПобедил {(users ? user1 : user2)}, поздравляем!");
                        users = !users;
                        Console.WriteLine($"\n{(users ? user1 : user2)}, если хотите отыграться, напишите 'да'");
                        string revenge = Console.ReadLine();

                        if (revenge == "да")
                        {
                            Main();
                        }
                        else
                        {
                            Console.ReadKey();
                            break;
                        }
                    }
                  
                }
            }
        }
    }
}


