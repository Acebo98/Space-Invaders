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
    //---------------------------------------
    //Pantalla de puntuaciones máximas
    //Autor: Sergio Acebal
    //Fecha: 17/01/2019
    //---------------------------------------
    public partial class frmLeader : Form
    {
        public frmLeader()
        {
            InitializeComponent();
        }

        //Cargamos el componente
        private void frmLeader_Load(object sender, EventArgs e)
        {
            //Confi del formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "Leaderboard";
        }

        //Seleccionamos uno de los botones
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            if (btnClicado == btnBack)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Close();
            }
            else if (btnClicado == btnDelete)
            {

            }
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
    }
}