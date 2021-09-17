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

namespace LegendreLab
{
    public partial class LegendreAnswer : Form
    {
        string Year, Semester, Brigade;
        public LegendreAnswer()
        {
            InitializeComponent();
        }

        public LegendreAnswer(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string labNumber = "5"; //Номер лабораторной работы
            int excerptLength = 30;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом

            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();

            Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, labNumber); //генерация этого числа

            string excerpt = gener.mainCutter(TextFile, number.Next(), excerptLength); //получение отрывка

            string answer = Regex.Replace(txbAnswer.Text, "[^А-Я ]", "").Trim(new Char[] { ' ', '\r', '\n'}); //убираем лишние символы из ответа

            if (answer == excerpt)
                MessageBox.Show("Верно");
            else
                MessageBox.Show("Неверно");
        }
    }
}
