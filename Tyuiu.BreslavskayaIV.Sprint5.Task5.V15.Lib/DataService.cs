using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100000000;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double a = Convert.ToDouble(line);
                    if ((a%5==0) && (a<res))
                    {
                        res = a;
                    }
                }
            }
            return res;

        }
    }
}