using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int theNumber;
        int guess;
        Random point = new Random();

        private void BtnPick_Click(object sender, EventArgs e)
        {
            //theNumber = point.Next(100) + 1;
            NudGuess.Enabled = true;
            NudGuess.Focus();

            BtnCheck.Enabled = true;
            BtnCheck.Focus();

           // TxtMessage.Text = "";

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt32(NudGuess.Value);

            if (guess == theNumber)
            {
                TxtMessage.Text = "You won Baby!!";
                BtnCheck.Enabled = false;
                NudGuess.Enabled = false;
                BtnRepeat.Focus();
            }

            else if (guess < theNumber)

            {
                TxtMessage.Text = "Try again, but go higher.";
            }

            else if (guess > theNumber)

            {
                TxtMessage.Text = "Try again, but go lower.";
            }

            
                
                
            
        }

        private void NudGuess_ValueChanged(object sender, EventArgs e)
        {
            //BtnCheck.Enabled = true;
            //BtnCheck.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCheat_Click(object sender, EventArgs e)
        {
            TxtMessage.Text=($"The number is { theNumber} ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            theNumber = point.Next(100) + 1;
            BtnPick.Focus();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Random point = new Random();
            theNumber = point.Next(100) + 1;
            BtnPick.Focus();
        }
    }
}