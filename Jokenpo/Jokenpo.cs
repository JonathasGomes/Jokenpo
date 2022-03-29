using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class Jokenpo : Form
    {
        public Jokenpo()
        {
            InitializeComponent();
        }

        int PlayerScore, CPUScore;
        enum Choices { Rock, Paper, Scissor }
        Choices[] choices = { Choices.Rock, Choices.Paper, Choices.Scissor };
        Choices PlayerChoice, CPUChoice;
        bool CanPlay = true;

        private void Choices_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (CanPlay)
            {
                switch (pic.Tag.ToString())
                {
                    case "Rock":
                        PlayerChoice = Choices.Rock;
                        pBJogador.Image = Properties.Resources.rock;
                        break;
                    case "Paper":
                        PlayerChoice = Choices.Paper;
                        pBJogador.Image = Properties.Resources.paper;
                        break;
                    case "Scissor":
                        PlayerChoice = Choices.Paper;
                        pBJogador.Image = Properties.Resources.scissors;
                        break;
                }
                CanPlay = false;
                ChoiceIA();
            }

        }
        private void ChoiceIA()
        {
            Random rdm = new Random();
            CPUChoice = choices[rdm.Next(0, choices.Length)];

            switch (CPUChoice.ToString())
            {
                case "Rock":
                    pBIA.Image = Properties.Resources.rock;
                    break;
                case "Paper":
                    pBIA.Image = Properties.Resources.paper;
                    break;
                case "Scissor":
                    pBIA.Image = Properties.Resources.scissors;
                    break;
            }

            switch (PlayerChoice.ToString())
            {
                case "Rock":
                    pBIA.Image = Properties.Resources.rock;
                    break;
                case "Paper":
                    pBIA.Image = Properties.Resources.paper;
                    break;
                case "Scissor":
                    pBIA.Image = Properties.Resources.scissors;
                    break;
            }
        }
        private void CheckRock()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    MessageBox.Show("Empate!");
                    break;
            }
        }
    }
}
