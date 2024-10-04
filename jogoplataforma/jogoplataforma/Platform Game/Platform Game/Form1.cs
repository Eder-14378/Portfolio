using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {
        // Variáveis de controle do jogador
        bool goLeft, goRight, jumping, IsGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        // Velocidades para as plataformas, inimigos e objetos no jogo
        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent();
        }

        // Evento principal do timer do jogo
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            // Atualiza o texto do score
            txtScore.Text = "Pontos: " + score;

            // Lógica de pulo do jogador
            if (jumping && force < 0)
            {
                jumping = false;
            }

            // Movimento do jogador para a esquerda
            if (goLeft)
            {
                player.Left -= playerSpeed;
            }

            // Movimento do jogador para a direita
            if (goRight)
            {
                player.Left += playerSpeed;
            }

            // Lógica de pulo
            if (jumping)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            player.Top += jumpSpeed;

            // Verifica interseções com plataformas, moedas e inimigos
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    // Lógica para interação com plataformas
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }
                    }

                    // Lógica para interação com moedas
                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    // Lógica para interação com inimigos
                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            IsGameOver = true;
                            txtScore.Text = "Pontos: " + score + Environment.NewLine + "Morreste na tua jornada!!";
                        }
                    }
                }
            }

            // Movimento horizontal da plataforma horizontal
            horizontalPlatform.Left -= horizontalSpeed;

            // Inverte a direção da plataforma horizontal quando atinge os limites
            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            // Movimento vertical da plataforma vertical
            verticalPlatform.Top += verticalSpeed;

            // Inverte a direção da plataforma vertical quando atinge os limites
            if (verticalPlatform.Top < 235 || verticalPlatform.Top > 600)
            {
                verticalSpeed = -verticalSpeed;
            }

            // Movimento do inimigo 1
            enemyOne.Left -= enemyOneSpeed;

            // Inverte a direção do inimigo 1 quando atinge os limites
            if (enemyOne.Left < pictureBox5.Left || enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            // Movimento do inimigo 2
            enemyTwo.Left += enemyTwoSpeed;

            // Inverte a direção do inimigo 2 quando atinge os limites
            if (enemyTwo.Left < pictureBox2.Left || enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            // Verifica se o jogador caiu para fora da tela
            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                IsGameOver = true;
                txtScore.Text = "Pontos" + score + Environment.NewLine + "Caiste para a tua morte";
            }

            // Verifica se o jogador alcançou a porta com todas as moedas
            if (player.Bounds.IntersectsWith(door.Bounds) && score == 26)
            {
                gameTimer.Stop();
                IsGameOver = true;
                txtScore.Text = "Pontos" + score + Environment.NewLine + "A tua missao tua esta completa";
            }
            else
            {
                txtScore.Text = "Score:" + score + Environment.NewLine + "Coletou todas as moedas";
            }
        }

        // Evento de tecla pressionada
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Lógica para tecla esquerda
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            // Lógica para tecla direita
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            // Lógica para tecla espaço (pulo)
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        // Evento de tecla liberada
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Lógica para tecla esquerda
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            // Lógica para tecla direita
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            // Lógica para término do pulo
            if (jumping)
            {
                jumping = false;
            }

            // Lógica para reiniciar o jogo ao pressionar Enter após o fim do jogo
            if (e.KeyCode == Keys.Enter && IsGameOver)
            {
                RestartGame();
            }
        }

        // Método para reiniciar o jogo
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            IsGameOver = false;
            score = 0;

            txtScore.Text = "Pontos: " + score;

            // Torna visíveis todos os PictureBox do jogo
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && !x.Visible)
                {
                    x.Visible = true;
                }
            }

            // Reposiciona o jogador, inimigos e plataformas no início do jogo
            player.Left = 88;
            player.Top = 678;

            enemyOne.Left = 417;
            enemyTwo.Left =360;

            horizontalPlatform.Left = 222;
            verticalPlatform.Top = 598;

            // Inicia o timer do jogo
            gameTimer.Start();
        }
    }
}
