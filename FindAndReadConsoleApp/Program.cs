using System;
using System.IO;

namespace FindAndReadConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя файла");
            var fileName = Console.ReadLine();
            Console.WriteLine(@"Введите корневую (пример ввода: C:\Program Files\Microsoft Visual Studio 10.0 )");
            var rootFolder = Console.ReadLine();
            var filePath = rootFolder + fileName;
            if (Directory.Exists(rootFolder))
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader streamReader = new StreamReader(filePath, System.Text.Encoding.Default) )
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                { Console.WriteLine("Файл не найден"); }
            }
            else
            {
                Console.WriteLine("Заданной папки не существует");
            }
        }
    }
}
