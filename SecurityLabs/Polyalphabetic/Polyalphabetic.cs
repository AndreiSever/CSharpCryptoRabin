using System;
using System.Text;
using System.IO;

namespace PolyalphabeticLab
{
    class Polyalphabetic
    {
        public string VigenereDecrypt(string Text, char[] Key, char[] Alphabet) //расшифровка, чисто для проверки, можно потом не копировать
        {
            char[] str = new char[Text.Length];
            int Code = 0;
            int N = Alphabet.Length;

            for (int i = 0; i < Text.Length; i++)
            {
                Code = Array.IndexOf(Alphabet, Text[i]);
                Code = (Code - Array.IndexOf(Alphabet, Key[i % Key.Length])) % N;

                if (Code < 0)
                    Code = N + Code;

                str[i] = Alphabet[Code];
            }

            string DecryptedText = new string(str);
            return DecryptedText;
        }

        public string VigenereEncrypt(string Text, char[] Key, char[] Alphabet) //шифрование Виженером
        {
            char[] str = new char[Text.Length];
            int Code = 0;
            int N = Alphabet.Length;

            for (int i = 0; i < Text.Length; i++)
            {
                Code = Array.IndexOf(Alphabet, Text[i]);
                Code = (Code + Array.IndexOf(Alphabet, Key[i % Key.Length])) % N;

                str[i] = Alphabet[Code];
            }

            string EncryptedText = new string(str);
            return EncryptedText;
        }

        public char[] GenerateKey(int KeyLength, char[] Alphabet, Random number) //генерация ключа
        {
            char[] Key = new char[KeyLength];
            int N = Alphabet.Length;

            for (int i = 0; i < KeyLength; i++)
            {
                Key[i] = Alphabet[number.Next() % N];
            }

            return Key;
        }

    }
}
