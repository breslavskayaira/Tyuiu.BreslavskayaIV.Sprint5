using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BreslavskayaIV.Sprint5.Task5.V15.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"A:\Tyuiu.BreslavskayaIV.Sprint5\Tyuiu.BreslavskayaIV.Sprint5.Task5.V15\bin\Debug\InPutDataFileTask5V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}