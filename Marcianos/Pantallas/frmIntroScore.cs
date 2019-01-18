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
    public partial class frmIntroScore : Form
    {
        DataSet dsLeaderboard = new DataSet("Space_Invaders");
        string rutaLeader = Environment.CurrentDirectory + "\\data\\leaderboard.txt";
        int score;

        public frmIntroScore(int Score)
        {
            InitializeComponent();
            score = Score;
        }

        //Cargamos el formulario
        private void frmIntroScore_Load(object sender, EventArgs e)
        {
            try
            {
                //Confi del formulario
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.BackColor = System.Drawing.Color.Black;
                this.FormBorderStyle = FormBorderStyle.None;

                //Cargamos el leaderboard
                labScore.Text += score.ToString();

                //Cargamos la tabla o la creamos               
                dsLeaderboard.Tables.Add(crearTablaPuntuaciones());
                if (File.Exists(rutaLeader) == true)
                {
                    dsLeaderboard.ReadXml(rutaLeader);
                }
                
                //Configuración
                confiLab();
            }
            catch (Exception)
            {
                MessageBox.Show("There has been a problem with the leaderboard", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

            try
            {
                if (btnClicado == btnConfirm)
                {
                    string nombre = tbNombre.Text.Trim();
                    if (nombre.Length > 0)
                    {
                        //Datos
                        DataRow row = dsLeaderboard.Tables["Leaderboard"].NewRow();
                        row["nombre_jugador"] = tbNombre.Text.Trim();
                        row["score"] = score;
                        row["fecha"] = DateTime.Now;
                        dsLeaderboard.Tables["Leaderboard"].Rows.Add(row);

                        //Guardamos
                        dsLeaderboard.WriteXml(rutaLeader);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You must enter a name", "Important", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (btnClicado == btnCancel)
                {
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been a problem with the leaderboard", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Creamos la tabla de puntuaciones
        private DataTable crearTablaPuntuaciones()
        {
            DataTable table = new DataTable("Leaderboard");

            //Columnas
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre_jugador", typeof(string));
            table.Columns.Add("score", typeof(int));
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
    }
}