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
    //---------------------
    //Menu de pausa
    //Autor: Sergio Acebal
    //Fecha: 12/07/2018
    //---------------------
    public partial class frmPause : Form
    {
        frmMarcianos juego;         //Juego
        int opcion;                 //Opcion que se elije

        public frmPause(frmMarcianos juego)
        {
            InitializeComponent();
            this.juego = juego;
        }

        //Cargamos el formulario
        private void frmPause_Load(object sender, EventArgs e)
        {
            //Confi frm
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.Text = "Game paused";
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;

            //Labels y btns
            labPausa.BackColor = System.Drawing.Color.Yellow;
            this.confiBtn();
        }

        //Configuracion buttoms
        private void confiBtn()
        {
            foreach (Control cn in this.Controls)
                if (cn is Button)
                    ((Button)cn).BackColor = System.Drawing.Color.Yellow;
        }

        //Seleccionamos un boton
        private void btn_Seleccion(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            switch (btnClicado.Text)
            {
                case "Continue": this.juego.Opcion = 0;
                    break;
                case "Restart": this.juego.Opcion = 1;
                    break;
                case "Quit": this.juego.Opcion = 2;
                    break;
            }

            this.Close();
        }
    }
}
