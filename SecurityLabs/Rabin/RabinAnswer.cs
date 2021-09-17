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
namespace SecurityLabs.Rabin
{
    public partial class RabinAnswer : Form
    {
        string Year, Semester, Brigade, labNumber;
        public RabinAnswer(string Year, string Semester, string Brigade, string labNumber)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = labNumber;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int excerptLength = 75;       //длина отрывка в символах
            string TextFile = SecurityLabs.Properties.Resources.Sholohov; //Файл с текстом
            SecurityLabs.Main.GeneralFunctions gener = new SecurityLabs.Main.GeneralFunctions();
            Random number = gener.SeedRandomer(this.Year, this.Semester, this.Brigade, this.labNumber); //генерация этого числа
            RabinClass rabclass = new RabinClass();
            string PartOfText = rabclass.GetTextModule3(TextFile, number.Next(), excerptLength, gener);
            string answer = rabclass.Replace(txbAnswer.Text); //убираем лишние символы из ответа
            if (answer == PartOfText) MessageBox.Show("Верно");
            else MessageBox.Show("Неверно");
        }
    }
}
