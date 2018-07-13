using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcianos
{
    //-----------------------
    //Menu del juego
    //Autor: Sergio Acebal
    //Fecha: 10/07/2018
    //-----------------------
    public partial class frmMenu : Form
    {
        Random rnd = new Random();                      //Objeto para el random
        bool controls = false;                          //Mostrar controles
        int naveI;                                      //Indica la nave

        public frmMenu() => InitializeComponent();

        public frmMenu(int NaveI)
        {
            InitializeComponent();
            this.naveI = NaveI;
        }

        //Cargamos el formulario
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //Confi del formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "Menu";

            //Configuración
            this.confiLab();
            this.muestraControles();
            this.estrellasInicio();
        }

        //Configuración de los labels del formulario
        private void confiLab()
        {
            foreach (Control cn in this.Controls)
                if (cn is Label)
                {
                    ((Label)cn).ForeColor = System.Drawing.Color.Yellow;
                    ((Label)cn).BackColor = System.Drawing.Color.Transparent;
                }
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

        //Creamos estrellas de fondo
        private void timerEstrellas_Tick(object sender, EventArgs e)
        {
            if (this.rnd.Next(0, 51) == 25)
                this.creaEstrella();
            this.mueveEstrella();
        }

        //Seleccionamos una opción
        private void btn_Seleccion_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            switch (btnClicado.Text)
            {
                case "Play":
                    {
                        frmMarcianos juego = new frmMarcianos(this.naveI);
                        juego.Show();
                        this.Close();
                    }
                    break;
                case "Controls":
                    {
                        this.controls = !this.controls;
                        muestraControles();
                    }
                    break;
                case "Shop":
                    {
                        frmShop tienda = new frmShop();
                        tienda.Show();
                        this.Close();
                    }
                    break;
            }
        }

        //Mostramos los controles
        private void muestraControles()
        {
            labInfoMove.Visible = this.controls;
            labInfoShoot.Visible = this.controls;
            labMove.Visible = this.controls;
            labSpace.Visible = this.controls;
        }

        //Creamos estrellas al principio
        private void estrellasInicio()
        {
            int stars = this.rnd.Next(10, 21);

            for (int i = 0; i < stars; i++)
                this.creaEstrella(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
        }

        //Cerramos la aplicacion cuando no haya mas ventanas abiertas
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= frmMenu_FormClosed;

            if (Application.OpenForms.Count == 0)
                Application.ExitThread();
            else
                Application.OpenForms[0].FormClosed += frmMenu_FormClosed;
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

        //Cerramos
        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}
