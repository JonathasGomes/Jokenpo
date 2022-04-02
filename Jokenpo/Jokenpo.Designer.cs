
namespace Jokenpo
{
    partial class Jokenpo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jokenpo));
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.pBIA = new System.Windows.Forms.PictureBox();
            this.pBJogador = new System.Windows.Forms.PictureBox();
            this.imageListScore = new System.Windows.Forms.ImageList(this.components);
            this.pBplayerScore = new System.Windows.Forms.PictureBox();
            this.pBCPUScore = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCPUScore)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(303, 37);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(59, 25);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(12, 303);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(97, 31);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "Player";
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.Transparent;
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.Image = global::Jokenpo.Properties.Resources.button_scissors;
            this.Scissors.Location = new System.Drawing.Point(236, 27);
            this.Scissors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(64, 64);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scissors.TabIndex = 5;
            this.Scissors.TabStop = false;
            this.Scissors.Tag = "Scissor";
            this.Scissors.Click += new System.EventHandler(this.Choices_Click);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.Transparent;
            this.Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paper.Image = global::Jokenpo.Properties.Resources.button_paper;
            this.Paper.Location = new System.Drawing.Point(136, 27);
            this.Paper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(64, 64);
            this.Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = false;
            this.Paper.Tag = "Paper";
            this.Paper.Click += new System.EventHandler(this.Choices_Click);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.Transparent;
            this.Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rock.Image = global::Jokenpo.Properties.Resources.button_rock;
            this.Rock.Location = new System.Drawing.Point(33, 27);
            this.Rock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(64, 64);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rock.TabIndex = 4;
            this.Rock.TabStop = false;
            this.Rock.Tag = "Rock";
            this.Rock.Click += new System.EventHandler(this.Choices_Click);
            // 
            // pBIA
            // 
            this.pBIA.BackColor = System.Drawing.Color.Transparent;
            this.pBIA.Location = new System.Drawing.Point(168, 85);
            this.pBIA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBIA.Name = "pBIA";
            this.pBIA.Size = new System.Drawing.Size(90, 90);
            this.pBIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBIA.TabIndex = 3;
            this.pBIA.TabStop = false;
            // 
            // pBJogador
            // 
            this.pBJogador.BackColor = System.Drawing.Color.Transparent;
            this.pBJogador.Location = new System.Drawing.Point(168, 185);
            this.pBJogador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBJogador.Name = "pBJogador";
            this.pBJogador.Size = new System.Drawing.Size(90, 90);
            this.pBJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBJogador.TabIndex = 2;
            this.pBJogador.TabStop = false;
            // 
            // imageListScore
            // 
            this.imageListScore.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListScore.ImageStream")));
            this.imageListScore.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListScore.Images.SetKeyName(0, "0.png");
            this.imageListScore.Images.SetKeyName(1, "1.png");
            this.imageListScore.Images.SetKeyName(2, "2.png");
            this.imageListScore.Images.SetKeyName(3, "3.png");
            this.imageListScore.Images.SetKeyName(4, "4.png");
            this.imageListScore.Images.SetKeyName(5, "5.png");
            this.imageListScore.Images.SetKeyName(6, "6.png");
            // 
            // pBplayerScore
            // 
            this.pBplayerScore.BackColor = System.Drawing.Color.Transparent;
            this.pBplayerScore.Image = global::Jokenpo.Properties.Resources._0;
            this.pBplayerScore.Location = new System.Drawing.Point(115, 308);
            this.pBplayerScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBplayerScore.Name = "pBplayerScore";
            this.pBplayerScore.Size = new System.Drawing.Size(26, 26);
            this.pBplayerScore.TabIndex = 9;
            this.pBplayerScore.TabStop = false;
            // 
            // pBCPUScore
            // 
            this.pBCPUScore.BackColor = System.Drawing.Color.Transparent;
            this.pBCPUScore.Image = global::Jokenpo.Properties.Resources._0;
            this.pBCPUScore.Location = new System.Drawing.Point(368, 36);
            this.pBCPUScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBCPUScore.Name = "pBCPUScore";
            this.pBCPUScore.Size = new System.Drawing.Size(22, 26);
            this.pBCPUScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBCPUScore.TabIndex = 10;
            this.pBCPUScore.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.Rock);
            this.panel1.Controls.Add(this.Scissors);
            this.panel1.Controls.Add(this.Paper);
            this.panel1.Location = new System.Drawing.Point(43, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 120);
            this.panel1.TabIndex = 11;
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBCPUScore);
            this.Controls.Add(this.pBplayerScore);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.pBIA);
            this.Controls.Add(this.pBJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Jokenpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCPUScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox pBJogador;
        private System.Windows.Forms.PictureBox pBIA;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.ImageList imageListScore;
        private System.Windows.Forms.PictureBox pBplayerScore;
        private System.Windows.Forms.PictureBox pBCPUScore;
        private System.Windows.Forms.Panel panel1;
    }
}

