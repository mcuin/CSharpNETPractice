﻿using System;
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

        int addEnd1, addEnd2, timeLeft;

        public void startQuiz()
        {
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);

            plusLabelLeft.Text = addEnd1.ToString();
            plusLabelRight.Text = addEnd2.ToString();

            sum.Value = 0;

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
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Times up!";
                MessageBox.Show("You didn't finish in time, sorry!");
                sum.Value = addEnd1 + addEnd2;
                startButton.Enabled = true;
            }
        }
    }
}
