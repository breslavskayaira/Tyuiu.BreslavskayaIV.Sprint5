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
            double res = Math.Round(3 * Convert.ToDouble(strx) * Convert.ToDouble(strx) * Convert.ToDouble(strx) / (Math.Sin(Convert.ToDouble(strx))));
            return res;

        }
    }
}