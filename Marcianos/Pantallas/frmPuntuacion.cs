using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Marcianos
{
    //------------------------------------------------------
    //Pantalla en la cual se muestra la puntuación total
    //Autor: Sergio Acebal
    //Fecha: 09/07/2018
    //------------------------------------------------------
    public partial class frmPuntuacion : Form
    {
        Random rnd = new Random();                                                      //Objeto para numeros aleatorios
        bool jefeMuerto = false;                                                        //Jefe muerto
        int enemigos = 0;                                                               //Enemigos asesinados
        int meteoros = 0;                                                               //Meteoros destruidos
        int tiempo = 0;                                                                 //Tiempo sobrevivido
        int i = 0;                                                                      //Indica que score vamos a mostrar
        int naveID;                                                                     //ID de la nave
        string ruta = Environment.CurrentDirectory + "/data/score.txt";                 //Ruta de la maxima puntuacion
        string rutaSkin = Environment.CurrentDirectory + "/data/skin.txt";              //Ruta de la skin
        int score = 0;                                                                  //Puntuación

        //Constructor con cada uno de los valores
        public frmPuntuacion(int Enemigos, int Meteoros, int Tiempo, bool JefeMuerto)
        {
            InitializeComponent();
            this.enemigos = Enemigos;
            this.meteoros = Meteoros;
            this.tiempo = Tiempo;
            this.jefeMuerto = JefeMuerto;
        }

        //Cargamos el formulario
        private void frmPuntuacion_Load(object sender, EventArgs e)
        {
            //Configuracion del formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Final Score";
            this.FormBorderStyle = FormBorderStyle.None;

            //Fondo y color de los labels
            confiLab();
            this.BackColor = System.Drawing.Color.Black;
            this.estrellasInicio();

            //Titulo
            labBossKilled.Visible = this.jefeMuerto;
            if (this.jefeMuerto)
                labGameOver.Text = "You won!";
            else
                labGameOver.Text = "Game over!";

            //Botones no visibles
            btnBack.Visible = false;
            btnBack.Enabled = false;
            btnSave.Visible = false;
            btnSave.Enabled = false;

            //Skin
            bool exito = true;
            naveID = new DAODatos().ObtenerSkin(rutaSkin, ref exito);
            if (exito == true)
            {
                //Nueva puntuacion
                labNew.Visible = false;
                timerPuntuacion.Start();

                //Skin de la nave
                this.skin();

                //Sonido
                if (this.jefeMuerto)
                {
                    SoundPlayer victoria = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\you-win.wav");
                    victoria.Play();
                }
                else
                {
                    SoundPlayer gameOver = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\game-over.wav");
                    gameOver.Play();
                }
            }
            else
            {
                MessageBox.Show("There has been a problem loading the skin", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Configuramos el color de los labels
        private void confiLab()
        {
            foreach (Control cn in this.Controls)
                if (cn is Label)
                {
                    cn.ForeColor = System.Drawing.Color.Yellow;
                    cn.BackColor = System.Drawing.Color.Transparent;
                    cn.Font = new Font("Bernard MT Condensed", cn.Font.Size);
                }
        }

        //Skin de la nave
        private void skin() => pbNave.Image = iLNaves.Images[this.naveID];

        //Evento tick del crono
        private void timerPuntuacion_Tick(object sender, EventArgs e)
        {
            switch (this.i)
            {
                case 0: labEnemigos.Text += this.enemigos.ToString();
                    break;
                case 1: labMeteors.Text += this.meteoros.ToString();
                    break;
                case 2: labTiempo.Text += this.tiempo.ToString() + " second(s)";
                    break;
                case 3:
                    {
                        //Calculamos la puntuación
                        score = (this.enemigos * 2) + this.tiempo + this.meteoros;
                        if (this.jefeMuerto)
                            score += 200;
                        labScoreFinal.Text += (score).ToString();

                        //Mostramos ambos botones
                        btnBack.Visible = true;
                        btnBack.Enabled = true;
                        btnSave.Visible = true;
                        btnSave.Enabled = true;

                        //Obtenemos la puntuación máxima
                        bool exito = true;
                        int maxima = new DAODatos().ObtenerPuntuacion(this.ruta, ref exito);
                        if (exito == true)
                        {
                            if (score > maxima)
                            {
                                labNew.Visible = true;

                                //Guardamos la score
                                bool guardado = new DAODatos().GuardarPuntuacion(score, this.ruta);
                                if (guardado == false)
                                {
                                    timerPuntuacion.Stop();
                                    MessageBox.Show("There has been an error saving the data", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            timerPuntuacion.Stop();
                            MessageBox.Show("Save file modified", "Error", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                            this.Close();
                        }

                        //Paramos el timer
                        timerPuntuacion.Stop();
                    }
                    break;
            }
            this.i++;
        }

        //Creamos una estrella
        private void creaEstrella()
        {
            Random rnd = new Random();
            int pox = rnd.Next(0, this.Width);

            PictureBox pbEstrella = new PictureBox();
            pbEstrella.Image = Properties.Resources.estrella;
            pbEstrella.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstrella.Size = new Size(10, 10);
            pbEstrella.BackColor = System.Drawing.Color.Transparent;
            pbEstrella.Tag = "star";
            pbEstrella.Location = new Point(pox, 0 - pbEstrella.Height);
            this.Controls.Add(pbEstrella);
            pbEstrella.SendToBack();
        }

        //Creamos una estrella en unas determinadas coordenadas
        private void creaEstrella(int x, int y)
        {
            Bitmap trans = new Bitmap(Properties.Resources.estrella);
            trans.MakeTransparent();
            PictureBox pbEstrella = new PictureBox();
            pbEstrella.Image = trans;

            pbEstrella.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstrella.Size = new Size(10, 10);
            pbEstrella.Tag = "star";
            pbEstrella.Location = new Point(x, y);
            this.Controls.Add(pbEstrella);
            pbEstrella.SendToBack();
        }

        //Movimiento de las estrellas
        private void mueveEstrella()
        {
            foreach (Control star in this.Controls)
            {
                if (star is PictureBox && star.Tag == "star")
                    star.Top += 1;
            }
        }

        //Movimiento de las estrellas
        private void timerEstrellas_Tick(object sender, EventArgs e)
        {
            if (this.rnd.Next(0, 51) == 25)
                this.creaEstrella();
            this.mueveEstrella();
        }

        //Creamos estrellas al principio
        private void estrellasInicio()
        {
            int stars = this.rnd.Next(10, 21);

            for (int i = 0; i < stars; i++)
                this.creaEstrella(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
        }

        //Quitamos el raton de encima
        private void btn_Leave(object sender, EventArgs e)
        {
            Button btnHover = new Button();
            btnHover = (Button)sender;
            btnHover.ForeColor = System.Drawing.Color.Black;
        }

        //Pasamos el raton por encima
        private void btn_Enter(object sender, EventArgs e)
        {
            Button btnHover = new Button();
            btnHover = (Button)sender;
            btnHover.ForeColor = System.Drawing.Color.Yellow;
        }

        //Seleccionamos uno de los 2 botones
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            if (btnClicado == btnSave)
            {
                frmIntroScore introScore = new frmIntroScore(score);
                introScore.ShowDialog();
            }

            //Abrimos el menu principal
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}