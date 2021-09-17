using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForceLab
{
    public partial class BruteForceMain : Form
    {
        string Year, Semester, Brigade, labNumber;
        public BruteForceMain()
        {
            InitializeComponent();
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab4_theory;
        }

        public BruteForceMain(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            this.labNumber = "4";
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab4_theory;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Task = new BruteForceTask(this.Year, this.Semester, this.Brigade, this.labNumber);
            Task.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Answer = new BruteForceAnswer(this.Year, this.Semester, this.Brigade, this.labNumber);
            Answer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab4_theory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab4_task;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab4_example;
        }
    }
}
