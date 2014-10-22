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

        int addEnd1, addEnd2, timeLeft, sub1, sub2, mult1, mult2, div1, div2;

        public void startQuiz()
        {
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);

            plusLabelLeft.Text = addEnd1.ToString();
            plusLabelRight.Text = addEnd2.ToString();

            sum.Value = 0;

            sub1 = randomizer.Next(1, 101);
            sub2 = randomizer.Next(1, sub1);

            minusLabelLeft.Text = sub1.ToString();
            minusLabelRight.Text = sub2.ToString();

            subtract.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congratulations, you got all of the answers right!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Times up!";
                MessageBox.Show("You didn't finish in time, sorry!");
                sum.Value = addEnd1 + addEnd2;
                subtract.Value = sub1 - sub2;
                startButton.Enabled = true;
            }
        }

        private bool CheckAnswer()
        {
            if ((addEnd1 + addEnd2 == sum.Value) && (sub1 - sub2 == sum.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int answerLength = answerBox.Value.ToString().Length;
                answerBox.Select(0, answerLength);
            }
        }
    }
}
