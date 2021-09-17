using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityLabs
{
    public partial class MainForm : Form
    {
        const int minYear = 2019;
        const int countYear = 40;
        const int countBrigades = 25;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Заполнение списков
            for (int i=0; i<countYear; i++) //Год
            {           
                cmbYear.Items.Add(minYear + i);
            }
            cmbYear.SelectedIndex = 0;
            //
            cmbSemester.Items.Add("1"); //Семестр
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;

            for (int i = 0; i < countBrigades; i++) //Бригада
            {
                cmbBrigade.Items.Add(i+1);
            }
            cmbBrigade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSAsingatureForm rsaForm = new RSAsingatureForm();
            rsaForm.Show();
        }

        private void bruteForce_Click(object sender, EventArgs e)
        {
            BruteForceLab.BruteForceMain bruteForceMain = new BruteForceLab.BruteForceMain(cmbYear.Text, cmbSemester.Text, cmbBrigade.Text);
            bruteForceMain.Show();
        }

        private void btnLegendre_Click(object sender, EventArgs e)
        {
            LegendreLab.LegendreMain legendreMain = new LegendreLab.LegendreMain(cmbYear.Text, cmbSemester.Text, cmbBrigade.Text);
            legendreMain.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PolyalphabeticLab.PolyalphabeticMain PolyalphabeticMain = new PolyalphabeticLab.PolyalphabeticMain(cmbYear.Text, cmbSemester.Text, cmbBrigade.Text);
            PolyalphabeticMain.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecurityLabs.Monoalphabetic.MonoalphabeticMain MonoalphabeticMain = new SecurityLabs.Monoalphabetic.MonoalphabeticMain(cmbYear.Text, cmbSemester.Text, cmbBrigade.Text);
            MonoalphabeticMain.Show(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RabinLab.RabinMain RabinMain = new RabinLab.RabinMain(cmbYear.Text, cmbSemester.Text, cmbBrigade.Text);
            RabinMain.Show();
        }
    }
}
