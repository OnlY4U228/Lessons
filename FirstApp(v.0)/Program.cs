using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp_v._0_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выше не смотреть
            #region Простые Переменные
            //Тип Имя = значение;
            //Тип2 Имя2;
            //Имя2 = значение2;
            char c = 'a';                   //Символ
            string str = "string";          //Строка(несколько символов)
            int i = 1;                      //Целое число
            bool b = true;                  //Логическая переменная(true/false)
            float f = 1.3f;                 //Дробь
            const int con = 1;              //Константа типа int
            #endregion
            #region Математические Операции
            /*
                +                   Сложение
                -                   Вычитание
                *                   Умножение                  
                /                   Деление
                %                   Получение остатка от деления(17 % 4 = 1)
                ++                  Инкремент (+1)
                --                  Декремент (-1)   
            */
            #endregion
            #region Условные Выражения
            /*
                ==                  Равно 
                &&                  И
                ||                  Или
                !                   Не
                >                   Больше
                <                   Меньше
                >=                  Больше или Равно
                <=                  Меньше или Равно
                ^                   Хотя бы один равен true, но не оба одновременно
            */
            #endregion
            #region Базовые Комманды
            //Пока не заморачивайтесь почему именно так,потом все объясню ,пока просто юзайте 
            Console.Write(1);       //Выписывает в консоль текст(после себя не жмет ENTER)
            Console.WriteLine(2);   //Выписывает в консоль текст(после себя жмет ENTER)
            Console.ReadLine();     //Считывает !Строку!
            string test = Console.ReadLine();  //Теперь в Переменной test Лежит значение,которое ввел пользователь
            //Так как Console.ReadLine() считывает именно текст для ввода переменных другого типа мы используем преобразования
            int a = int.Parse("10");
            int aa = int.Parse(Console.ReadLine());
            //В Console.Write(Line)() мы можем вписывать целые выражения
            int q = 3;
            int y = 6;
            Console.WriteLine(q + y);//9
            #endregion
            #region ToDo 1
            /*
                1)Написать программу, которая получает на вход 2 значения ,затем выдает их сумму,разность,произведение и частное 
                2)Создать репозиторий и кинуть ссылку на него в телегу,файлы в него можете закаидывать вручную,но изучите буквально 5 комманд для загрузки и обновления
                3)когда будет готов второй урок, этот файл я обновлю и вы сможете его спулить
            */
            #endregion
            //Условные Операторы
            #region if-else
                int first = 3;
                int second = 5;
                if(first > second)       //Если
                {
                    Console.WriteLine(first /*сложение строк,не путать с арифметическим сложением */+ " is bigger then " + second);
                    /*Console.WriteLine(first + second) выведет их сумму*/
                }
                else if (first < second) //Иначе Если
                {
                    Console.WriteLine(first + " is smaller then " + second);
                }
                else                     //Иначе
                {
                    Console.WriteLine(first + "=" + second);
                }
            //Выведет 3 is smaller then 5
            #endregion
            #region switch-case
                string select = Console.ReadLine();
                switch (select)
                {
                    case "q":
                        Console.WriteLine("You pressed q button");
                        break;
                    case "w":
                        Console.WriteLine("You pressed w button");
                        break;
                    default:
                        Console.WriteLine("I dont know wich button you had pressed");
                        break;
                }
            #endregion
            #region ToDo 2
                //1)Построить блок схему для решения квадратных уравнений и реализовать ее
                //Пользователь вводит 3 числа(a,b,c),программа решает
                //2)Построить свою блок схему и реализовать ее при помощи конструкций if-else И switch-case
                //3)Доработать калькулятор (певрое число,действие,второе число)
                //залить на репозиторий дать мне ссылку на него(подписывайте проекты понятно типа "ToDo1")
            #endregion
        }
    }
}
