using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendreLab
{
    public partial class LegendreMain : Form
    {
        string Year, Semester, Brigade;
        public LegendreMain()
        {
            InitializeComponent();
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_theory;
        }

        public LegendreMain(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_theory;
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            Form Task = new LegendreTask(this.Year, this.Semester, this.Brigade);
            Task.ShowDialog();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Form Answer = new LegendreAnswer(this.Year, this.Semester, this.Brigade);
            Answer.ShowDialog();
        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_theory;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_task;
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_example;
        }
    }
}
