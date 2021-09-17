using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BruteForceLab
{
    public partial class BruteForceAnswer : Form
    {
        string Year, Semester, Brigade, labNumber;
        public BruteForceAnswer()
        {
            InitializeComponent();
        }
        public BruteForceAnswer(string Year, string Semester, string Brigade, string labNumber)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = labNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
     //       string labNumber = "4"; //Номер лабораторной работы
            string LabSeed = this.Year + this.Semester + this.Brigade + this.labNumber; //Данные от студента для генерации
            int excerptQuantity = 1500;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            Vigenere vigen = new Vigenere();
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, labNumber);
            string excerpt = gener.mainCutter(TextFile, number.Next(), excerptQuantity);
            string answer = Regex.Replace(AnswerBox.Text, "[^А-Я ]", "").Trim(new Char[] { ' ', '\r', '\n' }); //убираем лишние символы из ответа
            if (excerpt == answer)
            {
                MessageBox.Show("Верно");
            }
            else MessageBox.Show("Неверно");
        }

    }
}
