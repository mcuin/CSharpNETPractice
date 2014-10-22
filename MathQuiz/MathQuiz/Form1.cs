using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        int addEnd1, addEnd2;

        public void startQuiz()
        {
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);

            plusLabelLeft.Text = addEnd1.ToString();
            plusLabelRight.Text = addEnd2.ToString();

            sum.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }
    }
}
