// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadsTask
{
    internal static class Program
    {
        public delegate void ParameterizedThreadStart(string request, string[] arguments);
        
        public static void Main(string[] args)
        {
            DummyRequestHandler handler = new DummyRequestHandler();
            
            Console.WriteLine("Приложение запущено");
            
            while (true)
            {
                Console.WriteLine("Введите текст запроса для отправки. Для выхода введите /exit");
                string? request = Console.ReadLine();
                
                if(request is "/exit") break;
                
                Console.WriteLine("Будет послано сообщение '" + request + "'");
                List<string?> collection = new();
                Console.WriteLine("Введите аргументы сообщения. " 
                                  + "Если аргументы не нужны - введите /end");
                while (true)
                {
                    string? argument = Console.ReadLine();
                    
                    if(argument is "/end") break;
                    
                    Console.WriteLine("Введите следующий аргумент сообщения. " 
                                      + "Для окончания добавления аргументов введите /end");
                    
                    collection.Add(argument);
                }

                string guid = Guid.NewGuid().ToString("D");

                ThreadPool.QueueUserWorkItem(_ =>
                {
                    try
                    {
                        string message = handler.HandleRequest(request, collection.ToArray());
                                 Console.Write("Сообщение с идентификатором " + guid + " ");
                                 Console.WriteLine("получило ответ - " + message);
                    }
                    catch (Exception e)
                    {
                        Console.Write("Сообщение с идентификатором " + guid + " ");
                        Console.WriteLine("упало с ошибкой: " + e.Message);
                    }
                });

                Console.WriteLine("Было отправлено сообщение '" 
                                  + request + "'. Присвоен идентификатор " 
                                  + guid);
            }
            
            Console.WriteLine("Приложение завершает работу");
        }
    }
}