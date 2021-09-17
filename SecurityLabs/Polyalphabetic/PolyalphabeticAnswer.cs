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

namespace PolyalphabeticLab
{
    public partial class PolyalphabeticAnswer : Form
    {
        string Year, Semester, Brigade, labNumber;
        public PolyalphabeticAnswer()
        {
            InitializeComponent();
        }

        private void PolyalphabeticAnswer_Load(object sender, EventArgs e)
        {

        }

        public PolyalphabeticAnswer(string Year, string Semester, string Brigade, string labNumber)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = labNumber;
            /**Проверка дешифроания**/
            /*Polyalphabetic vigen = new Polyalphabetic();
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            char[] AlphabetRus = new char[33] { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            string LabSeed = this.Year + this.Semester + this.Brigade + this.labNumber; //Данные от студента для генерации
            int excerptQuantity = 1500;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, this.labNumber);
            string excerpt = gener.mainCutter(TextFile, number.Next(), excerptQuantity);

            char[] key = vigen.GenerateKey(2, AlphabetRus, number);
            string s1 = vigen.VigenereEncrypt(excerpt, key, AlphabetRus);
            textBox1.Text = vigen.VigenereDecrypt(s1, key, AlphabetRus);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LabSeed = this.Year + this.Semester + this.Brigade + this.labNumber; //Данные от студента для генерации
            int excerptQuantity = 1500;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            Polyalphabetic vigen = new Polyalphabetic();
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, labNumber);
            string excerpt = gener.mainCutter(TextFile, number.Next(), excerptQuantity);
            string answer = Regex.Replace(textBox1.Text, "[^А-Я ]", "").Trim(new Char[] { ' ', '\r', '\n' }); //убираем лишние символы из ответа
            if (answer.Length == excerpt.Length)
            {
                if (excerpt == answer)
                {
                    MessageBox.Show("Верно");
                }
                else MessageBox.Show("Неверно");
            }
            else {
                if (answer.Length > excerpt.Length) {
                    MessageBox.Show("Количество символов больше необходимого на " + (answer.Length - excerpt.Length));
                }
                else
                {
                    MessageBox.Show("Количество символов меньше необходимого на " + (excerpt.Length - answer.Length));
                }
            }
        }
    }
}
