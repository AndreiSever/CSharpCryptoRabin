using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace SecurityLabs
{
    public class RabinClass
    {
        public string H_Year { set; get; }
        public string H_Semester { set; get; }
        public string H_Brigade { set; get; }
        public void Init(string Year, string Semester, string Brigade)
        {
            H_Year = Year; 
            H_Semester = Semester; 
            H_Brigade = Brigade; 
        }
        public ulong GetPrime(Random number, string Primes)
        {
            string[] allprimes = Primes.Split(' ');
            int pInd = number.Next() % allprimes.Length; //Случайно выбираемый номер простого числа из списка
            ulong prime = Convert.ToUInt64(allprimes[pInd]);
            return prime;
        }
        public List<ulong> GetEncrypedArray(byte[] arr, ulong n)
        {
            List<ulong> result = new List<ulong>();
            ulong Mi = 0;
            ulong C1, C2, C3;
            int indexArr = 1;
            int steps = 0;
            while (steps != (arr.Length / 3))
            {
                C1 = Convert.ToUInt64(arr[indexArr - 1]);
                C2 = Convert.ToUInt64(arr[indexArr]);
                C3 = Convert.ToUInt64(arr[indexArr + 1]);
                Mi = C1 * 65536 + C2 * 256 + C3;
                result.Add((Mi * Mi) % n);
                Mi = 0;
                steps++;
                indexArr = indexArr + 3;
            }
            return result;
        }
        public string GetWriteInFile(List<ulong> listarr, ulong n)
        {
            string stroka1 = "Открытый ключ:" + n + "\r\n";
            stroka1 += "Зашифрованное сообщение:\r\n";
            for (int i = 0; i <= listarr.Count - 1; i++)
            {
                stroka1 += listarr[i] + "\r\n";
            }
            return stroka1;
        }
        public string WriteInFile(string stroka1, string path)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "Lab8_case" + H_Brigade + ".txt")))
                {
                    outputFile.WriteLine(stroka1);
                }
                return "done";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
        public string Replace(string text)
        {
            return Regex.Replace(text, "[^А-Я ]", "").Trim(new Char[] { ' ', '\r', '\n' }); //убираем лишние символы из ответа
        }
        public string GetTextModule3(string TextFile, int number, int cryptLength, SecurityLabs.Main.GeneralFunctions gener)
        {            
            if (TextFile.Length>= cryptLength) 
            {
                string PartOfText = gener.mainCutter(TextFile, number, cryptLength);
                if (PartOfText.Length % 3 != 0)
                {
                    while (PartOfText.Length % 3 != 0)
                    {
                        int temp = PartOfText.Length % 3;

                        if ((temp == 1) && (PartOfText.Length > cryptLength)) cryptLength = PartOfText.Length + 2;
                        else if ((temp == 1) && (PartOfText.Length < cryptLength)) cryptLength = cryptLength + 3;

                        if ((temp == 2) && (PartOfText.Length > cryptLength)) cryptLength = PartOfText.Length + 1;
                        else if ((temp == 2) && (PartOfText.Length < cryptLength)) cryptLength = cryptLength + 3;

                        PartOfText = gener.mainCutter(TextFile, number, cryptLength);
                    }
                }
                return PartOfText;
            }
            return "false";
        }
    }
}