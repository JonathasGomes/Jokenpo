using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        int countPlayer, countCPU = 0;

        SoundPlayer sound = new SoundPlayer();

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
                    Draw();
                    break;
                case "Paper":
                    cpuCount();
                    break;
                case "Scissor":
                    playerCount();
                    break;
            }
            CanPlay = true;
        }
        private void CheckPaper()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    playerCount();
                    break;
                case "Paper":
                    Draw();
                    break;
                case "Scissor":
                    cpuCount();
                    break;
            }
            CanPlay = true;;
        }

        private void CheckScissor()
        {
            switch (CPUChoice.ToString())
            {
                case "Rock":
                    cpuCount();
                    break;
                case "Paper":
                    playerCount();
                    break;
                case "Scissor":
                    Draw();
                    break;
            }
            CanPlay = true;
        }

        private void playerCount()
        {
            if (countPlayer < 6)
            {
                countPlayer++;
                pBplayerScore.Image = imageListScore.Images[countPlayer];
                sound.SoundLocation = "C:\\Users\\jonat\\Downloads\\winsound.wav";
                sound.Play();
            }
            if(countPlayer == 6)
            {
                countPlayer = 0;
                countCPU = 0;

                pBCPUScore.Image = imageListScore.Images[countCPU];
            }
            pbResult.Image = Properties.Resources.win_fonte_jokenpo_;
        }

        private void cpuCount()
        {
            if (countCPU < 6)
            {
                countCPU++;
                pbResult.Image = Properties.Resources.lose_fonte_jokenpo_2;
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

        private void Draw()
        {
            pbResult.Image = Properties.Resources.draw_fonte_jokenpo;
        }
    }
}
