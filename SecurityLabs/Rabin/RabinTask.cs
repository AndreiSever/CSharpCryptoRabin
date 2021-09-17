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
namespace SecurityLabs.Rabin
{
    public partial class RabinTask : Form
    {
        string Year, Semester, Brigade, labNumber;
        public RabinTask(string Year, string Semester, string Brigade, string labNumber)
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
            int excerptQuantity = 75;       //длина отрывка в символах
            ulong n, p, q;
            string stroka1;
            List<ulong> listarr = new List<ulong>();
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            string primes = SecurityLabs.Properties.Resources.primesforRabin;
            if (Directory.Exists(textBox1.Text))
            {
                SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
                Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, this.labNumber);
                RabinClass rabclass = new RabinClass();
                string excerpt = rabclass.GetTextModule3(TextFile, number.Next(), excerptQuantity, gener);
                if (excerpt != "false")
                {
                    p = rabclass.GetPrime(number, primes);
                    q = rabclass.GetPrime(number, primes);
                    n = p * q;
                    byte[] arr = Encoding.GetEncoding(1251).GetBytes(excerpt);
                    listarr = rabclass.GetEncrypedArray(arr, n);
                    stroka1 = rabclass.GetWriteInFile(listarr, n);
                    string message = rabclass.WriteInFile(stroka1, textBox1.Text);
                    if (message == "done") this.Close();
                    else MessageBox.Show(message);
                }
                else MessageBox.Show("Длина текста в книге меньше стандартно заданной!");
            }
            else
            {
                MessageBox.Show("Введите существующий путь");
            }
            
        }
    }
}
