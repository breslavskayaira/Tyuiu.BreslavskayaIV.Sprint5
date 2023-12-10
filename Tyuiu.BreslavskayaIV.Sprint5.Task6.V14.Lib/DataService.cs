using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (char.IsPunctuation(c))
                        {
                            res ++;
                        }
                    }
                    
                }
            }
            return res;

        }
    }
}