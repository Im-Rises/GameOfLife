using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP14_JeudelaVie
{
    public partial class Form1 : Form
    {
        const int squarePerLine = 25;
        const int squarePerColumn = 25;
        static int positionOffsetX = 50;
        static int positionOffsetY = 50;      

        PictureBox[,] squares = new PictureBox[squarePerLine, squarePerColumn];
        static bool[,] squaresState = new bool[squarePerLine, squarePerColumn];
        static bool[,] squaresFutureState = new bool[squarePerLine, squarePerColumn];
        static int squareSize = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            squareModel.Visible = false;
            squareModelAlive.Visible = false;

            myTimer.Enabled = false;
            myTimer.Interval = 550;

            stopToolStripMenuItem.Checked = true;
            middleSpeedToolStripMenuItem.Checked = true;

            this.Size = new Size(positionOffsetX + squarePerLine * (squareSize + squareSize/4) + positionOffsetX, positionOffsetY + squarePerColumn * (squareSize + squareSize / 4) + positionOffsetY);

            for (int i = 0; i < squarePerLine; i++)
            {
                for (int j = 0; j < squarePerColumn; j++)
                {
                    squares[i, j] = new PictureBox();                  
                    squares[i, j].Width = squareSize;
                    squares[i, j].Height = squareSize;
                    squares[i, j].Location = new Point(positionOffsetX + i* (squareSize + squareSize / 4) , positionOffsetY + j * (squareSize + squareSize / 4));

                    squares[i, j].BackColor = squareModel.BackColor;
                    squares[i, j].Click += new EventHandler(Commun_Click);
                    Controls.Add(this.squares[i, j]);
                }
            }
        }

        void Commun_Click(object sender, EventArgs e)
        {
            bool trouvee = false;
            int i;
            int j = 0;

            for (i = 0; i < squarePerLine; i++)
            {
                for (j = 0; j < squarePerColumn; j++)
                {
                    if (sender == squares[i, j])
                    {
                        trouvee = true;
                        break;
                    }
                }
                if (trouvee == true) break;
            }

            squaresState[i, j] = !squaresState[i, j];

            if (squaresState[i, j]==true)
                squares[i, j].BackColor = squareModelAlive.BackColor;
            else
                squares[i, j].BackColor = squareModel.BackColor;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < squarePerLine; i++)
            {
                for (int j = 0; j < squarePerColumn; j++)
                {
                    int NbVoisin = calculateNeighbors(i, j, squaresState);

                    if (NbVoisin <=1)
                    {
                        squaresFutureState[i, j] = false;
                    }
                    else if (NbVoisin == 2)
                    {
                        squaresFutureState[i, j] = squaresState[i, j];
                    }
                    else if(NbVoisin ==3)
                    {
                        squaresFutureState[i, j] = true;
                    }
                    else
                    {
                        squaresFutureState[i, j] = false;
                    }
                }
            }

            transferBoolArray(squaresState, squaresFutureState);

            for (int i = 0; i < squarePerLine; i++)
            {
                for (int j = 0; j < squarePerColumn; j++)
                {
                    if (squaresState[i, j] == true)
                        squares[i, j].BackColor = squareModelAlive.BackColor;
                    else
                        squares[i, j].BackColor = squareModel.BackColor;
                }
            }
        }

        void transferBoolArray(bool [,]TableauRecepteur, bool [,] TableauATransferer)
        {
            for (int i = 0; i < squarePerLine; i++)
            {
                for (int j = 0; j < squarePerColumn; j++)
                {
                    TableauRecepteur[i, j] = TableauATransferer[i, j];
                }
            }
        }

        static int calculateNeighbors(int x, int y, bool [,] Tableau)
        {
            int NeighborsCount = 0;
            int neighborPosX;
            int neighborPosY;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    neighborPosX = x + i;

                    if (neighborPosX>= squarePerLine)
                    {
                        neighborPosX = 0;
                    }

                    if(neighborPosX<0)
                    {
                        neighborPosX = squarePerLine - 1;
                    }


                    neighborPosY = y + j;

                    if (neighborPosY >= squarePerColumn)
                    {
                        neighborPosY = 0;
                    }

                    if (neighborPosY < 0)
                    {
                        neighborPosY = squarePerColumn - 1;
                    }


                    if (Tableau[neighborPosX, neighborPosY] == true)
                        NeighborsCount = NeighborsCount + 1;
                }
            }

            if (Tableau[x, y] == true)
                NeighborsCount = NeighborsCount - 1;

            return NeighborsCount;
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 1000;
            lentToolStripMenuItem.Checked = true;
            middleSpeedToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = false;
        }

        private void normalSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 550;
            lentToolStripMenuItem.Checked = false;
            middleSpeedToolStripMenuItem.Checked = true;
            rapideToolStripMenuItem.Checked = false;
        }

        private void quickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 100;
            lentToolStripMenuItem.Checked = false;
            middleSpeedToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = true;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < squarePerLine; i++)
            {
                for (int j = 0; j < squarePerColumn; j++)
                {
                    squares[i, j].BackColor = squareModel.BackColor;
                    squaresState[i, j] = false;
                }
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = true;
            newToolStripMenuItem.Enabled = false;
            runToolStripMenuItem.Checked = true;
            stopToolStripMenuItem.Checked = false;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = false;
            newToolStripMenuItem.Enabled = true;
            runToolStripMenuItem.Checked = false;
            stopToolStripMenuItem.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
