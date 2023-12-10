using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayaIV.Sprint5.Task7.V8.Lib;
using System.IO;
namespace Tyuiu.BreslavskayaIV.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string pathSave = @"A:\Tyuiu.BreslavskayaIV.Sprint5\Tyuiu.BreslavskayaIV.Sprint5.Task7.V8\bin\Debug\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}
