
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
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.pBIA = new System.Windows.Forms.PictureBox();
            this.pBJogador = new System.Windows.Forms.PictureBox();
            this.imageListScore = new System.Windows.Forms.ImageList(this.components);
            this.pBplayerScore = new System.Windows.Forms.PictureBox();
            this.pBCPUScore = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.PictureBox();
            this.lblCPU = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.imageListResult = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCPUScore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.Transparent;
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.Image = global::Jokenpo.Properties.Resources.button_scissors;
            this.Scissors.Location = new System.Drawing.Point(264, 20);
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
            this.Paper.Location = new System.Drawing.Point(154, 20);
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
            this.Rock.Location = new System.Drawing.Point(44, 20);
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
            this.pBIA.Location = new System.Drawing.Point(183, 88);
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
            this.pBJogador.Location = new System.Drawing.Point(183, 246);
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
            this.pBplayerScore.Location = new System.Drawing.Point(170, 356);
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
            this.pBCPUScore.Location = new System.Drawing.Point(380, 57);
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
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Rock);
            this.panel1.Controls.Add(this.Scissors);
            this.panel1.Controls.Add(this.Paper);
            this.panel1.Location = new System.Drawing.Point(29, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 103);
            this.panel1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(400, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(372, 13);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayer.Image")));
            this.lblPlayer.Location = new System.Drawing.Point(29, 352);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(130, 29);
            this.lblPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblPlayer.TabIndex = 15;
            this.lblPlayer.TabStop = false;
            // 
            // lblCPU
            // 
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Image = ((System.Drawing.Image)(resources.GetObject("lblCPU.Image")));
            this.lblCPU.Location = new System.Drawing.Point(293, 54);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(76, 29);
            this.lblCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblCPU.TabIndex = 16;
            this.lblCPU.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Transparent;
            this.pbResult.Location = new System.Drawing.Point(183, 199);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(100, 50);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResult.TabIndex = 17;
            this.pbResult.TabStop = false;
            // 
            // imageListResult
            // 
            this.imageListResult.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListResult.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListResult.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.pBCPUScore);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBplayerScore);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox pBJogador;
        private System.Windows.Forms.PictureBox pBIA;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.ImageList imageListScore;
        private System.Windows.Forms.PictureBox pBplayerScore;
        private System.Windows.Forms.PictureBox pBCPUScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox lblPlayer;
        private System.Windows.Forms.PictureBox lblCPU;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.ImageList imageListResult;
    }
}

