using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLabs.Main
{
    public class GeneralFunctions
    {
        public Random SeedRandomer(string Year, string Semester, string Brigade, string labNumber) //Генерация случайного числа на основе данных от студента
        {
            string LabSeed = Year + Semester + Brigade + labNumber; //Данные от студента для генерации
            int Seed = Convert.ToInt32(LabSeed); //Данные от студента для генерации случайного числа
            Random number1 = new Random(Seed);
            return number1;
        }
        public string mainCutter(string Text, int number, int excerptQuantity) //Аргументы - используемый текст, случайное число, лимит количества символов
        {
            int spaceQuantity = 0; //Общее количество пробелов в тексте
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == ' ') spaceQuantity++;
            }
            int numberCut;
            if (number < excerptQuantity)
            {
                numberCut = number % spaceQuantity + excerptQuantity;
            }
            else {
                numberCut = number % spaceQuantity - excerptQuantity; //сокращение числа в соответствии с пробелами (и отсечение концовки текста)
            }
            int sp_count = 0;    //счетчик пробелов    
            int count_end = 0;       //Конечный символ отрывка
            int j;          //фиксатор - нулевой символ-пробел отрывка (а первый - j+1)
            for (j = 0; j < Text.Length; j++) //Здесь и далее - определение начального символа отрывка
            {
                if (Text[j] == ' ') sp_count++;
                if (sp_count == numberCut) { break; }
            }
            for (int z = j + excerptQuantity; z < Text.Length; z++) //Здесь и далее - определение точной длины отрывка
            {
                if (Text[z] != ' ') { count_end++; }
                else { break; }
            }
            Text = Text.Substring(j + 1, excerptQuantity + count_end - 1); //отсекание отрывка из текста
            return Text;
        }
    }
}
