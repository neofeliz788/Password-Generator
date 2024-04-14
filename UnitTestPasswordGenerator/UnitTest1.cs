using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordGenerator_14._04._2024;
using System.Windows.Forms;

namespace UnitTestPasswordGenerator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassword_Length1_Russian_Lower()
        {
            string password = Form1.GeneratePassword(1, "абвгдеёжзийклмнопрстуфхцчшщьыъэюя");
            Assert.AreEqual(1, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length5_Russian_Lower()
        {
            string password = Form1.GeneratePassword(5, "абвгдеёжзийклмнопрстуфхцчшщьыъэюя");
            Assert.AreEqual(5, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length10_Russian_Lower()
        {
            string password = Form1.GeneratePassword(10, "абвгдеёжзийклмнопрстуфхцчшщьыъэюя");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length5_Russian_Upper()
        {
            string password = Form1.GeneratePassword(5, "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ");
            Assert.AreEqual(5, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length1_English_Lower()
        {
            string password = Form1.GeneratePassword(1, "abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(1, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length5_English_Lower()
        {          
            string password = Form1.GeneratePassword(5, "abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(5, password.Length);
        } 
        [TestMethod]
        public void TestPassword_Length5_English_Upper()
        {
            string password = Form1.GeneratePassword(5, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual(5, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length1_Number()
        {
            string password = Form1.GeneratePassword(1, "0123456789");
            Assert.AreEqual(1, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length5_Numbers()
        {
            string password = Form1.GeneratePassword(5, "0123456789");
            Assert.AreEqual(5, password.Length);
        }
        [TestMethod]

        public void TestPassword_Length10_Numbers()
        {
            string password = Form1.GeneratePassword(10, "0123456789");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestGeneratePassword_Lenght()
        {            
            string password = Form1.GeneratePassword(1, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Assert.AreNotEqual(100, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length10_All_Lower()
        {
            string password = Form1.GeneratePassword(10, "абвгдеёжзийклмнопрстуфхцчшщьыъэюяabcdefghijklmnopqstuvwxyz");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length10_All_Upper()
        {
            string password = Form1.GeneratePassword(10, "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length10_All_Numbers_Upper()
        {
            string password = Form1.GeneratePassword(10, "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestPassword_Length10_All_Numbers_Lower()
        {
            string password = Form1.GeneratePassword(10, "абвгдеёжзийклмнопрстуфхцчшщьыъэюяabcdefghijklmnopqstuvwxyz0123456789");
            Assert.AreEqual(10, password.Length);
        }
    }
}
