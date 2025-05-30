using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class todo
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в ToDo List!\n");

            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("Какое имя вы выберете для ToDo List?\n");

                Console.WriteLine("Введите 1 чтобы добавить задачу в ToDo List.");
                Console.WriteLine("Введите 2 чтобы удалить задачу из ToDo List.");
                Console.WriteLine("Введите 3 чтобы посмотреть задачу в ToDo List");
                Console.WriteLine("Введите e чтобы выйти из програмы.\n");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Введите имя задачи:");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Задача добавленна в ToDo List.\n");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Введите номер задачи который вы хотите удалить.\n");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Перечень задач в листе: ");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Выход из программы\n");
                }
                else 
                {
                    Console.WriteLine("Инвалид оптионс плис трай эгейн.\n");
                }
            }

            // Другая строка

        }

    }
}
