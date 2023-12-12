using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSave);
            }
            
            
            string result = "";
            string pathIn = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V8.txt";
            string line = File.ReadAllText(pathIn);
            foreach (char item in line)
            {
                if (item >= 'А' && item <= 'Я')
                {
                    result += char.ToLower(item);
                }
                else
                {
                    result += item;
                }
            }

            File.AppendAllText(pathSave, result);
            return pathSave;

        }
    }
}
