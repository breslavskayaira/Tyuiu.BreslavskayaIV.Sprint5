﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task0.V11.Lib
{
    public class DataService: ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = (4 - x*x*x) / (x * x);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;

        }
    }
}
