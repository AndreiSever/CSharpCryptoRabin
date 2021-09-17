using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using SecurityLabs;
using System.Windows.Forms;
using System.Text;

namespace UnitTestRabinTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void cutterTestStart()//отрывок из начала текста
        {
            SecurityLabs.Main.GeneralFunctions gFunc = new SecurityLabs.Main.GeneralFunctions();

            string result = gFunc.mainCutter("ДЕЙСТВИЕ ПЕРВОЕ КОТОРОЕ РОЖДАЕТ ПРОТИВОДЕЙСТВИЕ ВТОРОЕ", 0, 9);

            Assert.AreEqual("ДЕЙСТВИЕ ПЕРВОЕ", result);
        }
        [TestMethod]
        public void cutterTestEnd()//отрывок в конце текста
        {
            SecurityLabs.Main.GeneralFunctions gFunc = new SecurityLabs.Main.GeneralFunctions();

            string result = gFunc.mainCutter("ДЕЙСТВИЕ ПЕРВОЕ КОТОРОЕ РОЖДАЕТ ПРОТИВОДЕЙСТВИЕ ВТОРОЕ", 11, 6);

            Assert.AreEqual("ВТОРОЕ", result);
        }
        [TestMethod]
        public void GetPrime()
        {
            ///<summary>
            ///Проверка выбора простого числа p
            ///</summary>
            ///
            // arrange
            int Seed = 2020298;
            Random rnd = new Random(Seed);
            ulong expected_p = 27271;
            string primes = SecurityLabs.Properties.Resources.primesforRabin;
            RabinClass rc = new RabinClass();
            ulong actual_p = rc.GetPrime(rnd, primes);

            // assert
            Assert.AreEqual(expected_p, actual_p);
        }
        [TestMethod]
        public void WriteInFile()
        {
            ///<summary>
            ///Проверка работы try catch
            ///Проверка корректной записи
            ///</summary>

            // arrange
            string directory_admin = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string directory_user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
  
            string Brigade = "9";
            string expected_except = "Отказано в доступе по пути \"C:\\Program Files\\Lab8_" + Brigade + ".txt\".";
            string expected_done = "done";

            // act
            RabinClass rc = new RabinClass();
            rc.H_Brigade = Brigade;

            string actual_except = rc.WriteInFile("", directory_admin);
            string actual_done = rc.WriteInFile("", directory_user);

            // assert
            StringAssert.Equals(expected_except, actual_except);
            StringAssert.Equals(expected_done, actual_done);

            // clean
            string cleanFile = directory_user + "\\Lab8_" + Brigade + ".txt";
            if (File.Exists(cleanFile)) File.Delete(cleanFile);
        }
        [TestMethod]
        public void GetTextModule3()
        {
            ///<summary>
            ///Проверка безошибочного выбора фрагмента текста
            ///Проверка, что длина фрагмента кратна трем
            ///</summary>

            // arrange
            int expected = 0; // проверочное значение, Text.length mod 3 = 0
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            RabinClass rc = new RabinClass();
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            Random number = gener.SeedRandomer("2020", "2", "9","8");
            string PartOfText = rc.GetTextModule3(TextFile, number.Next(), 75, gener);

            // assert
            int actual = PartOfText.Length % 3;
            Assert.AreEqual(expected, actual); // проверка равенства значений
        }
        public void LengthTextGetTextModule3()
        {
            ///<summary>
            ///Проверка условия на минимальное количество текста в файле
            ///</summary>

            // arrange
            string expected = "false";
            string TextFile = "МИХАИЛ ШОЛОХОВ ТИХИЙ ДОН"; //Строка, в реальности Файл с текстом
            RabinClass rc = new RabinClass();
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            Random number = gener.SeedRandomer("2020", "2", "9", "8");
            string PartOfText = rc.GetTextModule3(TextFile, number.Next(), 75, gener);

            // assert
            Assert.AreEqual(expected, PartOfText); // проверка равенства значений
        }
        [TestMethod]
        public void GetEncrypedArray()
        {
            ///<summary>
            ///Проверка шифрования
            ///</summary>

            // arrange
            string str = "ДОН";
            ulong n = 33, answer=4; // p= 3  , q= 11
            List<ulong> result = new List<ulong>();
            byte[] arr = Encoding.GetEncoding(1251).GetBytes(str);
            RabinClass rc = new RabinClass();
            result = rc.GetEncrypedArray(arr, n);

            // assert
            Assert.AreEqual(answer, result[0]); // проверка равенства значений
        }
        [TestMethod]
        public void GetWriteInFile()
        {
            ///<summary>
            ///Проверка шифрования
            ///</summary>

            // arrange
            ulong n = 33; // p= 3  , q= 11
            string answer = "Открытый ключ:33\r\nЗашифрованное сообщение:\r\n196\r\n206\r\n205\r\n";
            List<ulong> list = new List<ulong>() { 196, 206, 205 };
            RabinClass rc = new RabinClass();
            string result = rc.GetWriteInFile(list, n);

            // assert
            Assert.AreEqual(answer, result); // проверка равенства значений
        }
        [TestMethod]
        public void Replace()
        {
            ///<summary>
            ///Проверяем регулярное выражение
            ///</summary>

            // arrange
            ulong n = 33; // p= 3  , q= 11
            string answer = "МИХАИЛ ШОЛОХОВ ТИХИЙ ДОН";
            string text = "  qweМИХАИЛ1212 ШОЛОХОВdef'' asТИХИЙ ДОН  ";
            RabinClass rc = new RabinClass();
            string result = rc.Replace(text);

            // assert
            Assert.AreEqual(answer, result); // проверка равенства значений
        }
    }
}
