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
        DataSet dsPuntuaciones = new DataSet("Space_Invaders");
        string rutaLeader = Environment.CurrentDirectory + "/data/leaderboard.txt";      //Ruta del XML

        public frmLeader()
        {
            InitializeComponent();
        }

        //Cargamos el componente
        private void frmLeader_Load(object sender, EventArgs e)
        {
            try
            {
                //Confi del formulario
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Text = "Leaderboard";

                //Tabla de dataset
                dsPuntuaciones.ReadXml(rutaLeader);
                dsPuntuaciones.Tables["Leaderboard"].Constraints.Add("pk_score", 
                    dsPuntuaciones.Tables["Leaderboard"].Columns["id"], true);
                configurarDGV();

                //Lables
                confiLab();

                //Estrellas
                estrellasInicio();
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been a problem with the leaderboard", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Seleccionamos uno de los botones
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            try
            {
                if (btnClicado == btnBack)
                {
                    //Guardamos los datos
                    dsPuntuaciones.WriteXml(rutaLeader);

                    //Menu
                    frmMenu menu = new frmMenu();
                    menu.Show();

                    this.Close();
                }
                else if (btnClicado == btnDelete)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you really wanna delete the data?", "Question", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        dsPuntuaciones.Tables["Leaderboard"].Clear();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been an error saving the data", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Quitamos el raton de encima
        private void btn_Leave(object sender, EventArgs e)
        {
            Button btnHover = new Button();
            btnHover = (Button)sender;

            //Uno tiene el color de fondo rojo
            if (btnHover == btnBack)
            {
                btnHover.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnHover.ForeColor = System.Drawing.Color.Red;
            }
        }

        //Pasamos el raton por encima
        private void btn_Enter(object sender, EventArgs e)
        {
            Button btnHover = new Button();
            btnHover = (Button)sender;
            btnHover.ForeColor = System.Drawing.Color.Yellow;
        }

        //Creamos estrellas al principio
        private void estrellasInicio()
        {
            int stars = new Random().Next(10, 21);

            for (int i = 0; i < stars; i++)
                this.creaEstrella(new Random().Next(0, this.Width), new Random().Next(0, this.Height));
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

        //Timer estrellas
        private void timerEstrellas_Tick(object sender, EventArgs e)
        {
            if (new Random().Next(0, 51) == 25)
            {
                creaEstrella();
            }
            this.mueveEstrella();
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

        //Configurar datagridview
        private void configurarDGV()
        {
            //Columnas de la tabla
            DataColumn cId = dsPuntuaciones.Tables["Leaderboard"].Columns["id"];
            DataColumn cNombre = dsPuntuaciones.Tables["Leaderboard"].Columns["nombre_jugador"];
            DataColumn cScore = dsPuntuaciones.Tables["Leaderboard"].Columns["score"];
            DataColumn cFecha = dsPuntuaciones.Tables["Leaderboard"].Columns["fecha"];
            
            //Columnas del dgv
            dgvScores.Columns.Add("id", "Identifier");
            dgvScores.Columns.Add("nombre_jugador", "Player");
            dgvScores.Columns.Add("score", "Score");
            dgvScores.Columns.Add("fecha", "Date");

            //Enlazamos el nombre de las columnas
            dgvScores.Columns["id"].DataPropertyName = cId.Caption;
            dgvScores.Columns["nombre_jugador"].DataPropertyName = cNombre.Caption;
            dgvScores.Columns["score"].DataPropertyName = cScore.Caption;
            dgvScores.Columns["fecha"].DataPropertyName = cFecha.Caption;

            //Finalmente enlazamos la fuente de datos
            dgvScores.DataSource = dsPuntuaciones.Tables["Leaderboard"];
            dgvScores.Columns["id"].Visible = false;
            dgvScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Configuración
            dgvScores.Enabled = false;
            dgvScores.Font = new Font("Verdana", 11);
        }
    }
}