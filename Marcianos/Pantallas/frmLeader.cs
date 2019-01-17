﻿using System;
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
        string rutaSkin = Environment.CurrentDirectory + "/data/score.txt";      //Ruta del XML

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

            //Tabla de dataset
            dsPuntuaciones.Tables.Add(crearTablaPuntuaciones());
            configurarDGV();

            //Lables
            confiLab();

            //Estrellas
            estrellasInicio();
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
                    dsPuntuaciones.WriteXml(rutaSkin);

                    //Menu
                    frmMenu menu = new frmMenu();
                    menu.Show();

                    this.Close();
                }
                else if (btnClicado == btnDelete)
                {

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

        //Creamos la tabla de puntuaciones
        private DataTable crearTablaPuntuaciones()
        {
            DataTable table = new DataTable("Leaderboard");

            //Columnas
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre_jugador", typeof(string));
            table.Columns.Add("fecha", typeof(DateTime));

            //Incremento
            table.Columns["id"].AutoIncrement = true;
            table.Columns["id"].AutoIncrementSeed = 1;
            table.Columns["id"].AutoIncrementStep = 1;

            //No nulos
            foreach (DataColumn column in table.Columns)
            {
                column.AllowDBNull = false;
            }

            //Clave primario
            table.Constraints.Add("pk_score", table.Columns["id"], true);

            return table;
        }

        //Configurar datagridview
        private void configurarDGV()
        {
            //Columnas de la tabla
            DataColumn cId = dsPuntuaciones.Tables["Leaderboard"].Columns["id"];
            DataColumn cNombre = dsPuntuaciones.Tables["Leaderboard"].Columns["nombre_jugador"];
            DataColumn cFecha = dsPuntuaciones.Tables["Leaderboard"].Columns["fecha"];

            //Columnas del dgv
            dgvScores.Columns.Add("id", "Identifier");
            dgvScores.Columns.Add("nombre_jugador", "Player");
            dgvScores.Columns.Add("fecha", "Date");

            //Enlazamos el nombre de las columnas
            dgvScores.Columns["id"].DataPropertyName = cId.Caption;
            dgvScores.Columns["nombre_jugador"].DataPropertyName = cNombre.Caption;
            dgvScores.Columns["fecha"].DataPropertyName = cFecha.Caption;

            //Finalmente enlazamos la fuente de datos
            dgvScores.DataSource = dsPuntuaciones.Tables["Space_Invaders"];
            dgvScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Configuración
            dgvScores.Enabled = false;
            dgvScores.Font = new Font("Verdana", 11);
        }
    }
}