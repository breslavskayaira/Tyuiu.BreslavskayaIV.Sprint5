using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task6.V14.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                         *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Найти количество знаков препинания в строке в файле                      *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V14.txt";
            string strx = File.ReadAllText(path);
            Console.WriteLine("  "+strx);
            Console.WriteLine("****************************************************************************");
            
            Console.WriteLine("* Данные находятся в файле: " + path);
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("");
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }
}
