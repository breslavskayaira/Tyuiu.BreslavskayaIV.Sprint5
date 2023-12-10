using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task4.V28.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                  *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Прочитать значение переменной из файла, подставить ее в формулу          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V28.txt";
            string strx = File.ReadAllText(path);
           

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* 3*x*x*x/Math.Sin(x)                                                      *");
            Console.WriteLine("  x = " + strx);
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
           
            Console.WriteLine("* Данные находятся в файле: "+ path);
            Console.WriteLine("");
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();

        }
    }
}
