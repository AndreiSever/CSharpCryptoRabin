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

namespace PolyalphabeticLab
{
    public partial class PolyalphabeticTask : Form
    {
        string Year, Semester, Brigade, labNumber;
        public PolyalphabeticTask()
        {
            InitializeComponent();
        }

        private void PolyalphabeticTask_Load(object sender, EventArgs e)
        {

        }

        public PolyalphabeticTask(string Year, string Semester, string Brigade, string labNumber)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = labNumber;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            char[] AlphabetRus = new char[33] { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            string LabSeed = this.Year + this.Semester + this.Brigade + this.labNumber; //Данные от студента для генерации
            int excerptQuantity = 1500;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            if (Directory.Exists(txtPath.Text))
            {
                Polyalphabetic vigen = new Polyalphabetic();
                SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();

                Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, this.labNumber);
                string excerpt = gener.mainCutter(TextFile, number.Next(), excerptQuantity);

                char[] key = vigen.GenerateKey(2, AlphabetRus, number);
                string s1 = vigen.VigenereEncrypt(excerpt, key, AlphabetRus);

                try
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(txtPath.Text, "Lab2_case" + this.Brigade + ".txt")))
                    {
                        outputFile.WriteLine(s1);
                    }
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
            else
            {
                MessageBox.Show("Введите существующий путь");
            }
        }
    }
}
