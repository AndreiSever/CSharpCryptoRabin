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

namespace BruteForceLab
{
    public partial class BruteForceTask : Form
    {
        string Year, Semester, Brigade, labNumber;
        public BruteForceTask()
        {
            InitializeComponent();
        }
        public BruteForceTask(string Year, string Semester, string Brigade, string labNumber)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = labNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            char[] AlphabetRus = new char[33] { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            string LabSeed = this.Year + this.Semester + this.Brigade + this.labNumber; //Данные от студента для генерации
            int excerptQuantity = 1500;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            if (Directory.Exists(textBox1.Text))
            {
                Vigenere vigen = new Vigenere();
                SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();

                Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, this.labNumber);
                string excerpt = gener.mainCutter(TextFile, number.Next(), excerptQuantity);

                char[] key = vigen.GenerateKey(3, AlphabetRus, number);
                string stroka1 = vigen.VigenereEncrypt(excerpt, key, AlphabetRus); 
    
                try 
                {               
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(textBox1.Text, "Lab4_case" + this.Brigade + ".txt")))
                    {
                        outputFile.WriteLine(stroka1);
                    }
                    this.Close();      
                }                    
                catch(Exception exc)
                {
                   MessageBox.Show(exc.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Введите существующий путь");
            }
        }

        private void BruteForceTask_Load(object sender, EventArgs e)
        {
            
        }

        private void BruteForceTask_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
