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
    public partial class frmIntroScore : Form
    {
        public frmIntroScore()
        {
            InitializeComponent();
        }

        //Cargamos el formulario
        private void frmIntroScore_Load(object sender, EventArgs e)
        {
            //Confi del formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;

            //Configuración
            confiLab();
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

        //Seleccionamos el botón
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            if (btnClicado == btnConfirm)
            {
                string nombre = tbNombre.Text.Trim();
                if (nombre.Length > 0)
                {

                }
                else
                {
                    MessageBox.Show("Enter a name", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnClicado == btnCancel)
            {
                this.Close();
            }
        }
    }
}
