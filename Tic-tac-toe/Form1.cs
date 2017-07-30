using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        PictureBox[] pic = new PictureBox[9];

        Game game=new Game();

        public Form1()
        {
            InitializeComponent();

            pic[0] = p0;
            pic[1] = p1;
            pic[2] = p2;
            pic[3] = p3;
            pic[4] = p4;
            pic[5] = p5;
            pic[6] = p6;
            pic[7] = p7;
            pic[8] = p8;
        }

        private void playerVsPlayerButton_Click(object sender, EventArgs e)
        {
            groupBoxMenu.Visible = false;
            groupBoxGame.Visible = true;
            game.PlayBot = false;
            Restart();
        }

        private void playerVsCpuButton_Click(object sender, EventArgs e)
        {
            game.PlayBotHard = false;
            game.PlayBot = true;
            game.MovePlayer = true;
            groupBoxMenu.Visible = false;
            groupBoxGame.Visible = true;
            Restart();
        }

        private void playerVsCpuHard_Click(object sender, EventArgs e)
        {
            game.PlayBot = false;
            game.PlayBotHard = true;
            game.MovePlayer = false;
            groupBoxMenu.Visible = false;
            groupBoxGame.Visible = true;
            Restart();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            groupBoxMenu.Visible = true;
            groupBoxGame.Visible = false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        public void Restart()
        {
            for (int i = 0; i <= 8; i++)
            {
                pic[i].Image = Properties.Resources.nic;
            }

            game.Restart();

            if (game.PlayBot)
            {
                game.MovePlayer = true;
            }

            if (game.PlayBotHard)
            {
                game.PlayBot = false;
                game.PlayBotHard = true;
                game.MovePlayer = false;
                groupBoxMenu.Visible = false;
                groupBoxGame.Visible = true;
                int d = game.BotMoveHard();
                pic[d].Image = Properties.Resources.o;
            }
        }

        #region Boards buttons

        private void p0_Click(object sender, EventArgs e)
        {
            if(game.sign[0]=='e' && game.PlayBot==false && game.PlayBotHard==false)
            {
                if (game.NowX)
                {
                    p0.Image = Properties.Resources.x;
                    game.sign[0] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!","Wygrana!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Restart();
                    }
                    if(game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p0.Image = Properties.Resources.o;
                    game.sign[0] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!","Wygrana!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[0] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p0.Image = Properties.Resources.x;
                game.sign[0] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if(game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if(game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {
            if (game.sign[1] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p1.Image = Properties.Resources.x;
                    game.sign[1] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p1.Image = Properties.Resources.o;
                    game.sign[1] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[1] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p1.Image = Properties.Resources.x;
                game.sign[1] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }


                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (game.sign[2] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p2.Image = Properties.Resources.x;
                    game.sign[2] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p2.Image = Properties.Resources.o;
                    game.sign[2] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[2] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p2.Image = Properties.Resources.x;
                game.sign[2] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }


                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (game.sign[3] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p3.Image = Properties.Resources.x;
                    game.sign[3] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p3.Image = Properties.Resources.o;
                    game.sign[3] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[3] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p3.Image = Properties.Resources.x;
                game.sign[3] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }


                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (game.sign[4] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p4.Image = Properties.Resources.x;
                    game.sign[4] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p4.Image = Properties.Resources.o;
                    game.sign[4] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[4] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p4.Image = Properties.Resources.x;
                game.sign[4] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }


                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p5_Click(object sender, EventArgs e)
        {
            if (game.sign[5] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p5.Image = Properties.Resources.x;
                    game.sign[5] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p5.Image = Properties.Resources.o;
                    game.sign[5] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[5] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p5.Image = Properties.Resources.x;
                game.sign[5] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }


                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p6_Click(object sender, EventArgs e)
        {
            if (game.sign[6] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p6.Image = Properties.Resources.x;
                    game.sign[6] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p6.Image = Properties.Resources.o;
                    game.sign[6] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[6] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p6.Image = Properties.Resources.x;
                game.sign[6] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p7_Click(object sender, EventArgs e)
        {
            if (game.sign[7] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p7.Image = Properties.Resources.x;
                    game.sign[7] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p7.Image = Properties.Resources.o;
                    game.sign[7] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[7] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p7.Image = Properties.Resources.x;
                game.sign[7] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }

        private void p8_Click(object sender, EventArgs e)
        {
            if (game.sign[8] == 'e' && game.PlayBot == false && game.PlayBotHard == false)
            {
                if (game.NowX)
                {
                    p8.Image = Properties.Resources.x;
                    game.sign[8] = 'x';
                    game.NowX = false;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("X Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
                else
                {
                    p8.Image = Properties.Resources.o;
                    game.sign[8] = 'o';
                    game.NowX = true;
                    if (game.CheckWin())
                    {
                        MessageBox.Show("O Wygrywa!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                    if (game.CheckFull())
                    {
                        MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restart();
                    }
                }
            }
            else if ((game.sign[8] == 'e' && game.MovePlayer) && (game.PlayBot || game.PlayBotHard))
            {
                p8.Image = Properties.Resources.x;
                game.sign[8] = 'x';
                game.MovePlayer = false;
                if (game.CheckWin())
                {
                    MessageBox.Show("Wygrywasz!", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }

                if (game.PlayBot)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMove();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.PlayBotHard)
                {
                    if (!game.MovePlayer)
                    {
                        int d = game.BotMoveHard();
                        pic[d].Image = Properties.Resources.o;
                    }
                }

                if (game.CheckWin())
                {
                    MessageBox.Show("Przegrywasz!", "Przegrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
                if (game.CheckFull())
                {
                    MessageBox.Show("Remis!", "Remis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart();
                }
            }
        }
        #endregion
    }
}
