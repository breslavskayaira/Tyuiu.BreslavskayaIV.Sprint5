using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayaIV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            double y;
            string stry;
            Console.Title = "Спринт #5 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                         *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Записать значение формулы в файл                                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат: ");
            for (int x = startValue; x <= stopValue; x++)
            {

                y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2), 2);
                stry = Convert.ToString(y);
                Console.WriteLine(x+ " | "+ stry);

            }
            
            Console.ReadKey();
        }
    }
}
