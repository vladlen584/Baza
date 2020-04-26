using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Tasks
    {
        private string vlad = "vlad";
        public void task_2()
        {
            // Напишите программу  в которой пользовалель вводит последовательно 2 целых числа
            // Программа определяет какое из чисел больше или они равны
            
                Console.WriteLine("Введите первое целое число");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе целое число");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number > number2)
                {
                    Console.WriteLine($"Число {number} больше");
                }
                else
                {
                    if (number < number2)
                    {
                        Console.WriteLine($"Число {number2} больше");
                    }
                    else
                    {
                        if (number == number2)
                        {
                            Console.WriteLine($"Числа {number} и {number2} равны");
                            
                        }
                    }
                   
                }
                
            
           

        }


        public void task_3()
        {
            // Напишите программу в которой пользователь вводит два целых числа.
            // а программа отображает сумму этих чисел.
            // это продолжается до тех пор пока пользователь не введет нулевое значение.

            int summa2 = 0; // холодильник

            do
            {
                Console.WriteLine("Введите число для суммы ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число для суммы");
                int number2 = Convert.ToInt32(Console.ReadLine());
                 
                summa2 = summa2 + number+number2;
               
                if (number == 0 || number2 == 0) break;
                
                
                Console.WriteLine($"Сумма чисел равна {summa2}");




            }
            while (true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели ноль программа закончилась");
            





        }

       public void TASK_1()
        {
            // Напишите программу в которой пользовтель вводит число а программа
            // проверяет делится ли это число на 3 и на 7
            
                Console.WriteLine("Введите число");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number % 3 == 0 && number % 7 == 0)
                {
                    Console.WriteLine("Число делится");
                }
                else
                {
                    Console.WriteLine("Число не делится");
                    
                }
                
           
          
            
           
           


        }

        public void task_4()
        {
            // Напишите программу в которой пользователь вводит целое число в диапозоне от 1 до 7
            // а программа определяет по этому числу день недели!

            Console.WriteLine("Введите целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                       
                        break;
                    case 2:
                        Console.WriteLine("Вторник");
                        
                        break;
                    case 3:
                        Console.WriteLine("Среда");
                       
                        break;
                    case 4:
                        Console.WriteLine("Четверг");
                       
                        break;
                    case 5:
                        Console.WriteLine("Пятница");
                       
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы вышли за допустимый диапазон");
                        Console.WriteLine("Система перезагружается....");
                        break;

                }
                if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6 || number == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Программа закончена");
                    Console.WriteLine("Система перезагружается....");
                    break;
                }
            }
            while (true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Система перезагрузилась");
            Console.WriteLine("Хотите продолжить");
            Console.WriteLine("Для продолжение нажмите Да или Нет");
            string rep = Console.ReadLine();
            if (rep == "Да")
            {
                task_4();
            }
            else
            {
                if (rep == "Нет")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Как скажите");
                    Console.WriteLine("Выход из системы");
                }
            }
           



        }

        public void task_5()
        {
            // Напишите программу в которой вычисляется сумма нечетных чисел.
            do
            {
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                int summa = 0;
                for (int i = 1; i <= number; i++)
                {
                    if ((i % 2) == 1)
                    {
                        summa = summa + i;
                    }
                }
                Console.WriteLine(summa);
                break;

            }
            while (true);

           

        }
        public void task_6()
        {
            // Напишите программу в которой выводится последовательность чисел Фибоначчи.
            Console.WriteLine("Вывод чисел Фибоначчи");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите число для продолжения...");
            Console.ForegroundColor = ConsoleColor.Green;
            int Number = Convert.ToInt32(Console.ReadLine());

            int a = 1;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);

            for (int i = 0; i <= Number; i++)
            {

                int NextNumber = a + b;
                Console.WriteLine(NextNumber);
                a = b;
                b = NextNumber;
            }
           
            
        }

        public void task_7()
        {
            //Напишите программу в которой пользователем вводится два целых числа,
            //Программа выводит все целые числа-начиная с наименьшего (из двух введеных)
            // и заканчивая наибольшим(из двух введенных)

            Console.WriteLine("Введите первое число");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            if (Number < Number2)
            {
                for (int i = Number; i <= Number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for(int a = Number2; a <= Number; a++)
                {
                    Console.WriteLine(a);
                }
            }
           
            Console.ReadLine();
        }

        public void task_8()
        {

        }































































    }
}
