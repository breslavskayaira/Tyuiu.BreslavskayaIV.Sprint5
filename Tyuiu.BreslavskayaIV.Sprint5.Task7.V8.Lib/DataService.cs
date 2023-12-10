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
            
            
            string a = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string b = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string pathIn = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V8.txt";
            string line = File.ReadAllText(pathIn);
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (line[i] == a[j])
                    {
                        line = line.Replace(line[i], b[j]);
                    }
                }
                        
            }
                   
            File.AppendAllText(pathSave, line);
            return pathSave;

        }
    }
}