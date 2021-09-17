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

namespace LegendreLab
{
    public partial class LegendreTask : Form
    {
        string Year, Semester, Brigade;
        public LegendreTask()
        {
            InitializeComponent();
        }

        public LegendreTask(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string labNumber = "5"; //Номер лабораторной работы
            int excerptLength = 30;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            string PrimesFile = SecurityLabs.Properties.Resources.primes; //Файл с числами

            if (Directory.Exists(txtPath.Text))
            {
                Legendre leg = new Legendre();
                SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();

                Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, labNumber); //генерация этого числа

                string excerpt = gener.mainCutter(TextFile, number.Next(), excerptLength); //получение отрывка

                Encoding utf8 = Encoding.UTF8;
                Encoding cp866 = Encoding.GetEncoding(866);

                byte[] utfBytes = utf8.GetBytes(excerpt); //преобразование из utf8 в cp866 чтобы кахдый символ был 8 бит
                byte[] cpBytes = Encoding.Convert(utf8, cp866, utfBytes);

                string binary = leg.GetBinary(cpBytes); //получение двоичного кода отрывка
                int P = leg.GetPrime(number, PrimesFile); //Одинаковое P для Лежандра

                int[] Numerators = leg.GetLegendreNumerators(P, number, binary);

                try
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(txtPath.Text, "Lab5_case" + this.Brigade + ".txt")))
                    {
                        for (int i = 0; i < Numerators.Length; i++) //Пропись символов Лежандра
                        {
                            outputFile.WriteLine("L(" + Numerators[i] + ", " + P + ")=?");
                        }
                    }

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите существующий путь");
            }
        }
    }
}

