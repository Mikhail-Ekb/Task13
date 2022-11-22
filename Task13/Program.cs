using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание строковой переменной
            "path" = C:\Users\MIKHAIL\Desktop\C#\ИТМО\Task13;

            //получение файлов внутри каталога
            string[] files = Directory.GetFiles(path, "*" SearchOption.AllDirectories);

            //перборка
            foreach (string file in files)
            {
                //Вывод
                Console.WriteLine(;
            }
            Console.ReadKey();
        }
    }
}
