
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
            this.Paper = new System.Windows.Forms.PictureBox();
            this.pBJogador = new System.Windows.Forms.PictureBox();
            this.pBIA = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            this.SuspendLayout();
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.SystemColors.GrayText;
            this.Paper.Location = new System.Drawing.Point(167, 402);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(64, 64);
            this.Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = false;
            this.Paper.Tag = "Paper";
            this.Paper.Click += new System.EventHandler(this.Choices_Click);
            // 
            // pBJogador
            // 
            this.pBJogador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pBJogador.Location = new System.Drawing.Point(167, 255);
            this.pBJogador.Name = "pBJogador";
            this.pBJogador.Size = new System.Drawing.Size(64, 64);
            this.pBJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBJogador.TabIndex = 2;
            this.pBJogador.TabStop = false;
            // 
            // pBIA
            // 
            this.pBIA.BackColor = System.Drawing.SystemColors.Highlight;
            this.pBIA.Location = new System.Drawing.Point(167, 64);
            this.pBIA.Name = "pBIA";
            this.pBIA.Size = new System.Drawing.Size(64, 64);
            this.pBIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBIA.TabIndex = 3;
            this.pBIA.TabStop = false;
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Scissors.Location = new System.Drawing.Point(280, 402);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(64, 64);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scissors.TabIndex = 5;
            this.Scissors.TabStop = false;
            this.Scissors.Tag = "Scissor";
            this.Scissors.Click += new System.EventHandler(this.Choices_Click);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rock.Location = new System.Drawing.Point(74, 402);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(64, 64);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rock.TabIndex = 4;
            this.Rock.TabStop = false;
            this.Rock.Tag = "Rock";
            this.Rock.Click += new System.EventHandler(this.Choices_Click);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(29, 32);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(59, 25);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(26, 351);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(97, 31);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "Player";
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.pBIA);
            this.Controls.Add(this.pBJogador);
            this.Controls.Add(this.Paper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jokenpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
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
    }
}

