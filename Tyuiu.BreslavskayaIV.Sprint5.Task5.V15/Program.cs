using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task5.V15.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                           *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Из набора данных в файле найти минимальное число, которое делится на 5   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V15.txt";
            Console.WriteLine("* Данные находятся в файле: " + path);
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("");
            Console.WriteLine("Результат = "+ res);
            Console.ReadKey();

        }
    }
}

