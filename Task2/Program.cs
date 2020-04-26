using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                try
                {
                   
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите пароль для входа в систему");
                    string password = Console.ReadLine();
                    if (password != "007700")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Пароль не верный вам отказано в доступе!");
                        break;
                    }
                    Command();
                   
                    



                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nВведите номер программы которую хотите продолжить или начать");
                        uint Value = Convert.ToUInt32(Console.ReadLine());

                        if (Value >= 1 && Value <= 8)// 1<=Value<7
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            SelectTask(Value);
                            
                        }
                        if (Value == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы вышли из программы");
                            Console.WriteLine("Система перезапускается....");
                            break;
                        }
                        
                    }
                    
                    
                   

                   







                }




                

                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Вы болван вы ввели не число");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Хотите продолжить?");

                    Console.WriteLine("Для повтора наберите Да, для выхода Нет");
                    string rep = Console.ReadLine();
                    if (rep == "Да")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Система перезагружается....");
                        Main(args);
                    }
                    else
                    {
                        if (rep == "Нет")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ну как хотите!");
                        }
                    }


                }

               

            }
            while (true);




            }
        static void SelectTask(uint Value)
        {
            Tasks tasks = new Tasks();

           
            switch (Value)
            {
                case 1:
                    tasks.TASK_1();
                    break;
                case 2:
                    tasks.task_2();
                    break;
                case 3:
                    tasks.task_3();
                    break;
                case 4:
                    tasks.task_4();
                    break;
                case 5:
                    tasks.task_5();
                    break;
                case 6:
                    tasks.task_6();
                    break;
                case 7:
                    tasks.task_7();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Программа находится на стадии разработки...");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Программа не обработала введеное значение");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    break;


            }
        }

        static void Command()
        {
            Exit();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Наберите 1 если хотите выполнить задачу TASK_1() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 1 программа проверяет делится ли введенное" +
                              "пользователем число на 3 и на 7");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНаберите 2 если хотите выполнить задачу task_2() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 2 программа определяет какое " +
                              "из чисел больше или они равны!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНаберите 3 если хотите выполнить задачу task_3() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 3. Программа отображает" +
                              "сумму введенных пользователем чисел");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНаберите 4 если хотите выполнить задачу task_4() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 4. Программа определяет " +
                              "по введенному пользователем числу день недели. ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНаберите 5 если хотите выполнить задачу task_5() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 5. Программа вычисляет сумму" +
                              " нечетных чисел");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНабирите 6 если хотите выполнить задачу task_6() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 6. Программа определяет числа " +
                              "Фибоначчи");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНабирите 7 если хотите выполнить задачу task_7() ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Описание программы номер 7.Программа выводит все целые числа от наименьшего" +
                " к наибольшему (из двух введенных)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nНабирите 8 если хотите выполнить задачу task_8() ");


        }

        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Для выхода из программы введите ноль");
        }




















    }
    }





















