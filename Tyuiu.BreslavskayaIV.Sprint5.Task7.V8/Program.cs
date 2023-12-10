using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task7.V8.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #8                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Заменить русские заглавные буквы на прописные в строке в файле           *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V8.txt";
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Данные находятся в файле: " + path);
            DataService ds = new DataService();
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine("");
            Console.WriteLine("Результат находится в файле: " + pathSave);
            Console.ReadKey();

        }
    }
}
