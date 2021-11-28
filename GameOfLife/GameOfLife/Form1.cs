using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeudelaVie
{
    public partial class Form1 : Form
    {
        const int NombrePicH = 25;
        const int NombrePicV = 25;
        static int PositionIniPicX = 50;
        static int PositionIniPicY = 50;      

        PictureBox[,] picCases = new PictureBox[NombrePicH, NombrePicV];
        static bool[,] TabCasesEtatVie = new bool[NombrePicH, NombrePicV];
        static bool[,] TabCasesEtatFutur = new bool[NombrePicH, NombrePicV];
        static int TaillePic = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picInitial.Visible = false;
            picVivant.Visible = false;

            tmrAvanceTemps.Enabled = false;
            tmrAvanceTemps.Interval = 550;

            arretToolStripMenuItem.Checked = true;
            moyenToolStripMenuItem.Checked = true;

            this.Size = new Size(PositionIniPicX + NombrePicH * (TaillePic + TaillePic/4) + PositionIniPicX, PositionIniPicY + NombrePicV * (TaillePic + TaillePic / 4) + PositionIniPicY);

            for (int i = 0; i < NombrePicH; i++)
            {
                for (int j = 0; j < NombrePicV; j++)
                {
                    picCases[i, j] = new PictureBox();                  
                    picCases[i, j].Width = TaillePic;
                    picCases[i, j].Height = TaillePic;
                    picCases[i, j].Location = new Point(PositionIniPicX + i* (TaillePic + TaillePic / 4) , PositionIniPicY + j * (TaillePic + TaillePic / 4));

                    picCases[i, j].BackColor = picInitial.BackColor;
                    picCases[i, j].Click += new EventHandler(Commun_Click);
                    Controls.Add(this.picCases[i, j]);
                }
            }
        }

        void Commun_Click(object sender, EventArgs e)
        {
            bool trouvee = false;
            int i;
            int j = 0;

            for (i = 0; i < NombrePicH; i++)
            {
                for (j = 0; j < NombrePicV; j++)
                {
                    if (sender == picCases[i, j])
                    {
                        trouvee = true;
                        break;
                    }
                }
                if (trouvee == true) break;
            }

            TabCasesEtatVie[i, j] = !TabCasesEtatVie[i, j];

            if (TabCasesEtatVie[i, j]==true)
                picCases[i, j].BackColor = picVivant.BackColor;
            else
                picCases[i, j].BackColor = picInitial.BackColor;
        }

        private void tmrAvanceTemps_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < NombrePicH; i++)
            {
                for (int j = 0; j < NombrePicV; j++)
                {
                    int NbVoisin = CalculVoisin(i, j, TabCasesEtatVie);

                    if (NbVoisin <=1)
                    {
                        TabCasesEtatFutur[i, j] = false;
                    }
                    else if (NbVoisin == 2)
                    {
                        TabCasesEtatFutur[i, j] = TabCasesEtatVie[i, j];
                    }
                    else if(NbVoisin ==3)
                    {
                        TabCasesEtatFutur[i, j] = true;
                    }
                    else
                    {
                        TabCasesEtatFutur[i, j] = false;
                    }
                }
            }

            TransfertTableaubool(TabCasesEtatVie, TabCasesEtatFutur);

            for (int i = 0; i < NombrePicH; i++)
            {
                for (int j = 0; j < NombrePicV; j++)
                {
                    if (TabCasesEtatVie[i, j] == true)
                        picCases[i, j].BackColor = picVivant.BackColor;
                    else
                        picCases[i, j].BackColor = picInitial.BackColor;
                }
            }
        }

        void TransfertTableaubool(bool [,]TableauRecepteur, bool [,] TableauATransferer)
        {
            for (int i = 0; i < NombrePicH; i++)
            {
                for (int j = 0; j < NombrePicV; j++)
                {
                    TableauRecepteur[i, j] = TableauATransferer[i, j];
                }
            }
        }

        static int CalculVoisin(int x, int y, bool [,] Tableau)
        {
            int NbVoisins = 0;
            int PositionVoisinX;
            int PositionVoisinY;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    PositionVoisinX = x + i;

                    if (PositionVoisinX>= NombrePicH)
                    {
                        PositionVoisinX = 0;
                    }

                    if(PositionVoisinX<0)
                    {
                        PositionVoisinX = NombrePicH - 1;
                    }


                    PositionVoisinY = y + j;

                    if (PositionVoisinY >= NombrePicV)
                    {
                        PositionVoisinY = 0;
                    }

                    if (PositionVoisinY < 0)
                    {
                        PositionVoisinY = NombrePicV - 1;
                    }


                    if (Tableau[PositionVoisinX, PositionVoisinY] == true)
                        NbVoisins = NbVoisins + 1;
                }
            }

            if (Tableau[x, y] == true)
                NbVoisins = NbVoisins - 1;

            return NbVoisins;
        }

        private void lentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAvanceTemps.Interval = 1000;
            lentToolStripMenuItem.Checked = true;
            moyenToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = false;
        }

        private void moyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAvanceTemps.Interval = 550;
            lentToolStripMenuItem.Checked = false;
            moyenToolStripMenuItem.Checked = true;
            rapideToolStripMenuItem.Checked = false;
        }

        private void rapideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAvanceTemps.Interval = 100;
            lentToolStripMenuItem.Checked = false;
            moyenToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = true;
        }
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NombrePicH; i++)
            {
                for (int j = 0; j < NombrePicV; j++)
                {
                    picCases[i, j].BackColor = picInitial.BackColor;
                    TabCasesEtatVie[i, j] = false;
                }
            }
        }

        private void marcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAvanceTemps.Enabled = true;
            nouveauToolStripMenuItem.Enabled = false;
            marcheToolStripMenuItem.Checked = true;
            arretToolStripMenuItem.Checked = false;
        }

        private void arretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrAvanceTemps.Enabled = false;
            nouveauToolStripMenuItem.Enabled = true;
            marcheToolStripMenuItem.Checked = false;
            arretToolStripMenuItem.Checked = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
