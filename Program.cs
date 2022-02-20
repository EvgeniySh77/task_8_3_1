using System;
using System.IO;

namespace task_8_3_1
{
    class Program
    {
        static void Main()
        {
            string filePath1 = @"E:\VS_Project\task_8_3_1\Students.txt"; // Укажем путь 
            string filePath2 = @"E:\VS_Project\task_8_3_1\Program.cs";
            if (!File.Exists(filePath1)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath1))  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                }
            }
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr1 = File.OpenText(filePath1))
            {
                string str1 = "";
                while ((str1 = sr1.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str1);
                }
            }

            Console.WriteLine(Environment.NewLine);

            using (StreamReader sr2 = File.OpenText(filePath2))
            {
                string str2 = "";
                while ((str2 = sr2.ReadLine()) != null) 
                {
                    Console.WriteLine(str2);
                }
            }
        }
    }
}
