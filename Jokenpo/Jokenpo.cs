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
        enum Choices { Rock, Paper, Scissor}
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

            }

        }
    }
}
