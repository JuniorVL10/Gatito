using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gatito
{
    public partial class GameGatito : Form
    {
        int turno = 1;
        int[,] Gato;
        int PuntosPlayer1 = 0;
            int PuntosPlayer2 = 0;
        bool YaHayGanador;


        public GameGatito()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void IniciarJuego()
        {
            //iniciar valores en juego
            turno = 1;
            Gato = new int[3, 3];
            YaHayGanador = false;

            picGanador.Image = Properties.Resources.f_0;
            FichasGato.Controls.Clear();
            //Arreglos para fichsa
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.f_0;
                    FichaJuego.Name = String.Format("{0}", i + "_" + j);
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                        FichasGato.Controls.Add.(FichaJuego, j, i);
                    Gato[i, j] = 0;



                }



            }

        }


    }
}
