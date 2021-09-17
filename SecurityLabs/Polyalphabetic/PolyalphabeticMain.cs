using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyalphabeticLab
{
    public partial class PolyalphabeticMain : Form
    {
        string Year, Semester, Brigade, labNumber;
        public PolyalphabeticMain()
        {
            InitializeComponent();
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab2_theory;
        }

        public PolyalphabeticMain(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = "2";
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab2_theory;
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            Form Task = new PolyalphabeticTask(this.Year, this.Semester, this.Brigade, this.labNumber);
            Task.ShowDialog();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Form Answer = new PolyalphabeticAnswer(this.Year, this.Semester, this.Brigade,this.labNumber);
            Answer.ShowDialog();
        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
           richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab2_theory;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolyalphabeticMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab2_task;
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            //richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab2_example;
        }
    }
}
