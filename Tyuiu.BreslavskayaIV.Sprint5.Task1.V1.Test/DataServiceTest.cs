using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"A:\Tyuiu.BreslavskayaIV.Sprint5\Tyuiu.BreslavskayaIV.Sprint5.Task1.V1\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}