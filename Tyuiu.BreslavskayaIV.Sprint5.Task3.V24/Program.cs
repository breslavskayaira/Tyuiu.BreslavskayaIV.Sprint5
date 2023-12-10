using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayaIV.Sprint5.Task3.V24.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                      *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Записать значение формулы в файл                                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* y = 6.1 * x * x * x + 0.23 * x * x + 1.04 * x                            *");
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            double y = 6.1 * x * x * x + 0.23 * x * x + 1.04 * x;

            y = Math.Round(y, 3);
            Console.WriteLine("Результат: " + y);
            Console.ReadKey();

        }
    }
}
