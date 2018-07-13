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

namespace Marcianos
{
    //-----------------------
    //Tienda
    //Autor: Sergio Acebal
    //Fecha: 11/07/2018
    //-----------------------
    public partial class frmShop : Form
    {
        Random rnd = new Random();                                                      //Objeto numeros aleatorios
        int highScore;                                                                  //Puntuación máxima
        int naveI;                                                                      //Nave seleccionada
        string ruta = @"C:\Users\" + Environment.UserName + @"\Desktop\scores.txt";     //Ruta de la maxima puntuacion

        public frmShop() => InitializeComponent();

        //Cargamos el formulario
        private void frmShop_Load(object sender, EventArgs e)
        {
            //Confi del formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Shop";
            this.BackColor = System.Drawing.Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.estrellasInicio();

            //Puntuacion maxima
            this.highScore = this.leeMaxima();
            labHighScore.Text = "High-score: " + this.highScore;

            //Naves
            this.cargaNaves();

            //Labels
            this.confiLabs();
        }

        //Confi de los labels
        private void confiLabs()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is Label)
                {
                    ((Label)cn).ForeColor = System.Drawing.Color.Yellow;
                    ((Label)cn).BackColor = System.Drawing.Color.Transparent;
                }
            }
        }

        //Leemos la puntuacio maxima y la retornamos
        private int leeMaxima()
        {
            FileStream fs = null;
            StreamReader sr = null;
            string lectura;
            int retorno = 0;

            try
            {
                fs = new FileStream(this.ruta, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                if ((lectura = sr.ReadLine()) != null)
                    retorno = Convert.ToInt32(lectura);
                else
                    retorno = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            return retorno;
        }

        //Cargamos las fotos de las naves
        private void cargaNaves()
        {
            //Fotos
            pbN1.Image = iLNaves.Images[0];
            pbN2.Image = iLNaves.Images[1];
            pbN3.Image = iLNaves.Images[2];
            pbN4.Image = iLNaves.Images[3];

            //Confi de las pictureboxes
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && cn.Tag != "star" && Convert.ToInt32(cn.Tag) >= 0)
                {
                    ((PictureBox)cn).SizeMode = PictureBoxSizeMode.StretchImage;
                    cn.BackColor = System.Drawing.Color.Transparent;
                }
            }
        }

        //Seleccionamos una nave
        private void pbNave_Seleccion(object sender, EventArgs e)
        {
            PictureBox pbNave = (PictureBox)sender;

            if (this.highScore >= Convert.ToInt32(pbNave.Tag))
            {
                pbNave.BackColor = System.Drawing.Color.Yellow;
                this.naveID(pbNave);
                this.desNaves(pbNave);
            }
            else
                MessageBox.Show("You don't have enought high-score!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //ID de la nave seleccionada
        private void naveID(PictureBox pbNave)
        {
            switch (pbNave.Name)
            {
                case "pbN1": this.naveI = 0;
                    break;
                case "pbN2": this.naveI = 1;
                    break;
                case "pbN3": this.naveI = 2;
                    break;
                case "pbN4": this.naveI = 3;
                    break;
            }
        }

        //Deseleccion de las naves
        private void desNaves(PictureBox pbNave)
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && cn.Tag != "star" && Convert.ToInt32(cn.Tag) >= 0)
                    if (cn.Tag != pbNave.Tag)
                        cn.BackColor = System.Drawing.Color.Transparent;
            }
        }

        //Cerramos
        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (this.confirmaPls())
            {
                frmMenu menu = new frmMenu(this.naveI);
                menu.Show();
                this.Close();
            }
            else MessageBox.Show("Please choose a skin", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Miramos si podemos cerrar la tienda
        private bool confirmaPls()
        {
            bool confirma = false;

            foreach (Control cn in this.Controls)
                if (cn is PictureBox && cn.Tag != "star" && cn.Name.Substring(0, 2) == "pb")
                    if (cn.BackColor == System.Drawing.Color.Yellow)
                    {
                        confirma = true;
                        break;
                    }

            return confirma;
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

        //Creamos estrellas al principio
        private void estrellasInicio()
        {
            int stars = this.rnd.Next(10, 21);

            for (int i = 0; i < stars; i++)
                this.creaEstrella(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
        }

        //Movimiento de las estrellas
        private void timerEstrellas_Tick_1(object sender, EventArgs e)
        {
            if (this.rnd.Next(0, 51) == 25)
                this.creaEstrella();
            this.mueveEstrella();
        }
    }
}