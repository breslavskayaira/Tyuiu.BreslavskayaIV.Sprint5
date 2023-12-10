using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double a = Convert.ToDouble(strx);
            double res = Math.Round(3*a*a*a/Math.Sin(a), 3);
            return res;

        }
    }
}