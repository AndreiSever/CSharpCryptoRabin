using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityLabs.Monoalphabetic
{
    public partial class MonoalphabeticMain : Form
    {
        string Year, Semester, Brigade;
        public MonoalphabeticMain()
        {
            InitializeComponent();
        }

        public MonoalphabeticMain(string Year, string Semester, string Brigade)
        {
            InitializeComponent();
            this.Year = Year;
            this.Semester = Semester;
            this.Brigade = Brigade;
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_theory;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = SecurityLabs.Properties.Resources.lab5_theory;
        }
    }
}
