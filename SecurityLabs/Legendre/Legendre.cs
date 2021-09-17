using System;
using System.Text;
using System.IO;

namespace LegendreLab
{
    class Legendre
    {
        public string GetBinary(byte[] excerpt)
        {
            string binary = "";  //массив-строка для бинарного кодирования текста
            for (int i = 0; i < excerpt.Length; i++) //бинарное кодирование текста
            {
                binary = binary + Convert.ToString(excerpt[i], 2).PadLeft(8,'0');
            }

            return binary;
        }

        public int GetPrime(Random number, string Primes)
        {
            string[] allprimes = Primes.Split(' ');

            int pInd = number.Next() % allprimes.Length - 1; //Случайно выбираемый номер простого числа из списка
            int prime = Convert.ToInt32(allprimes[pInd]);
            return prime;
        }

        public int[] GetLegendreNumerators(int P, Random number, string binary)
        {
            int[] FinalA = new int[binary.Length];  //Массив А для символов Лежандра
            for (int i = 0; i < binary.Length; i++) //генерация символов Лежандра
            {
                int A = number.Next();
                if (binary[i] == '0') //"уточнение" А в зависимости от нужды закодировать нулевой или единичный бит
                {
                    while (LegendreSymbol(Convert.ToInt64(A), Convert.ToInt64(P)) != -1)
                    {
                        A++;
                    }
                }
                else
                {
                    while (LegendreSymbol(Convert.ToInt64(A), Convert.ToInt64(P)) != 1)
                    {
                        A++;
                    }
                }
                FinalA[i] = A; //заполнение массива "уточненным" А
            }
            return FinalA;
        }

        public int LegendreSymbol(long a, long p) //Вычисление символа Лежандра
        {
            int result;

            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }

            if (a % 2 == 0)
            {
                result = LegendreSymbol(a / 2, p);
                if (((p * p - 1) & 8) != 0)
                {
                    result = -result;
                }
            }
            else
            {
                result = LegendreSymbol(p % a, a);
                if (((a - 1) * (p - 1) & 4) != 0)
                {
                    result = -result;
                }
            }
            return result;
        }

        public string DeLegendring(int[] Numerators, int P) //де-Лежандрирование для самопроверки
        {
            string text = ""; 
            byte[] chars = new byte[Numerators.Length / 8];
            int L = 0;
            int c = 0;
             
            for (int i = 0; i < Numerators.Length; i=i+8) 
            {
                for (int j = 0; j < 8; j++)
                {
                    L = LegendreSymbol(Convert.ToInt64(Numerators[i + j]), Convert.ToInt64(P));

                    if (L == -1)
                        L = 0;

                    c = c + L * Convert.ToInt32(Math.Pow(2, 7 - j));
                }

                chars[i / 8] = (byte)c;
                c = 0;
            }

            Encoding utf8 = Encoding.UTF8;
            Encoding cp866 = Encoding.GetEncoding(866);

            text = Encoding.UTF8.GetString(Encoding.Convert(cp866, utf8, chars));

            return text;
        }
    }
}
