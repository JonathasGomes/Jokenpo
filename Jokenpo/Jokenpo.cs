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

        private Image[] ImagesScore = new Image[6];
        int countPlayer, countCPU = 0;


        int PlayerScore, CPUScore;
        enum Choices { Rock, Paper, Scissor }
        Choices[] choices = { Choices.Rock, Choices.Paper, Choices.Scissor };
        Choices PlayerChoice, CPUChoice;
        bool CanPlay = true;

        private void Choices_Click(object sender, EventArgs e)
        {
            //Este método está usando o evento click em 3 PictureBox
            //Que no caso são as opções que o usuário pode escolher para jogar
            PictureBox pic = (PictureBox)sender;
            if (CanPlay)
            {
                switch (pic.Tag.ToString())
                {
                    case "Rock":
                        PlayerChoice = Choices.Rock;
                        pBJogador.Image = Properties.Resources.p_rock;
                        break;
                    case "Paper":
                        PlayerChoice = Choices.Paper;
                        pBJogador.Image = Properties.Resources.p_paper;
                        break;
                    case "Scissor":
                        PlayerChoice = Choices.Scissor;
                        pBJogador.Image = Properties.Resources.p_scissors;
                        break;
                }
                CanPlay = false;
                ChoiceIA();
            }

        }
        private void ChoiceIA()
        {
            //Essas são as opções de escolha aleatória da IA
            Random rdm = new Random();
            CPUChoice = choices[rdm.Next(0, choices.Length)];

            switch (CPUChoice.ToString())
            {
                case "Rock":
                    pBIA.Image = Properties.Resources.cpu_rock;
                    break;
                case "Paper":
                    pBIA.Image = Properties.Resources.cpu_paper;
                    break;
                case "Scissor":
                    pBIA.Image = Properties.Resources.cpu_scissors;
                    break;
            }
            // O switch separa 1 das 3 opções feita pelo jogador e chama o método
            // Mostrando qual foi o resultado da partida
            switch (PlayerChoice.ToString())
            {
                case "Rock":
                    CheckRock();
                    break;
                case "Paper":
                    CheckPaper();
                    break;
                case "Scissor":
                    CheckScissor();
                    break;
            }
        }

        //Métodos CheckRock, CheckPaper e CheckScissor
        //Servem para dar o resultado do jogo + aumentar os pontos na pontuação
        private void CheckRock()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    MessageBox.Show("Empate!");
                    break;
                case "Paper":
                    MessageBox.Show("Você perdeu!");
                    cpuCount();
                    break;
                case "Scissor":
                    MessageBox.Show("Você ganhou!");
                    playerCount();
                    break;
            }
            CanPlay = true;
            pBIA.Image = null;
            pBJogador.Image = null;
        }
        private void CheckPaper()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    MessageBox.Show("Você ganhou!");
                    playerCount();
                    break;
                case "Paper":
                    MessageBox.Show("Empate!");
                    break;
                case "Scissor":
                    MessageBox.Show("Você perdeu!");
                    cpuCount();
                    break;
            }
            CanPlay = true;
            pBIA.Image = null;
            pBJogador.Image = null;
        }

        private void CheckScissor()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    MessageBox.Show("Você perdeu!");
                    cpuCount();
                    break;
                case "Paper":
                    MessageBox.Show("Você ganhou!");
                    playerCount();
                    break;
                case "Scissor":
                    MessageBox.Show("Empate!");
                    break;
            }
            CanPlay = true;
            pBIA.Image = null;
            pBJogador.Image = null;
        }

        private void playerCount()
        {
            if (countPlayer < 6)
            {
                countPlayer++;
            }
            if(countPlayer == 6)
            {
                countPlayer = 0;
                countCPU = 0;

                pBCPUScore.Image = imageListScore.Images[countCPU];
            }
            pBplayerScore.Image = imageListScore.Images[countPlayer];
        }

        private void cpuCount()
        {
            if (countCPU < 6)
            {
                countCPU++;
            }
            if (countCPU == 6)
            {
                countCPU = 0;
                countPlayer = 0;

                pBplayerScore.Image = imageListScore.Images[countPlayer];
            }
            pBCPUScore.Image = imageListScore.Images[countCPU];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
