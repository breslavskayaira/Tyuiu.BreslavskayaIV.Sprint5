using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task6.V14.Lib;
namespace Tyuiu.BreslavskayaIV.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"A:\Tyuiu.BreslavskayaIV.Sprint5\Tyuiu.BreslavskayaIV.Sprint5.Task6.V14\bin\Debug\InPutDataFileTask6V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            string path = @"A:\Tyuiu.BreslavskayaIV.Sprint5\Tyuiu.BreslavskayaIV.Sprint5.Task6.V14\bin\Debug\InPutDataFileTask6V14.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}