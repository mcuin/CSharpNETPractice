using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        List<string> icons = new List<string>(){
            "!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z"
        };

        Label firstLabel = null;
        Label secondLabel = null;

        private void assignSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNum = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNum];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNum);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            assignSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label labelClicked = sender as Label;

            if (timer1.Enabled == true)
            {
                return;
            }

            if (labelClicked != null)
            {
                if (labelClicked.ForeColor == Color.Black)
                {
                    return;
                }

                if (firstLabel == null)
                {
                    firstLabel = labelClicked;
                    labelClicked.ForeColor = Color.Black;
                    return;
                }

                secondLabel = labelClicked;
                secondLabel.ForeColor = Color.Black;

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstLabel.ForeColor = firstLabel.BackColor;
            secondLabel.ForeColor = secondLabel.BackColor;
        }
    }
}
