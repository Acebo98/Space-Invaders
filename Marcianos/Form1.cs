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
    //Objetivo: Marcianos
    //Autor: Sergio Acebal
    //Fecha: 06/07/2018
    //-----------------------
    public partial class frmMarcianos : Form
    {
        Random rnd = new Random();                  //Objeto para numeros aleatorios
        bool disparo = false;                       //Disparo infinito
        bool powers = true;                         //Aparición power-ups
        bool god = false;                           //Invencible
        bool drcha = false;                         //Ir drcha
        bool izq = false;                           //Ir izq
        bool enemigos = true;                       //Determina si aparecen enemigos / meteoros
        int naveSkin;                               //Indica la skin de la nave
        int score = 0;                              //Puntuación
        int velozBala = 15;                         //Velocidad de la bala del personaje
        int velozPersonaje = 10;                    //Velocidad del personaje
        int velozMeteoro = 5;                       //Velocidad del meteoro
        int velozTie = 7;                           //Velocidad del caza TIE
        int velozStar = 1;                          //Velocidad de la estrella
        int derrapeTie = 1;                         //Derrape caza TIE
        int velozBalaTie = 15;                      //Velocidad de la bala del TIE
        int bajasParaBoss = 0;                      //Bajas necesarias para que aparezca el boss
        int[] datos = new int[] { 0, 0, 0 };        //Guardamos los datos de la partida
        int[] tiempos = new int[] { 30, 30, 30 };   //Tiempos de los power-ups

        public frmMarcianos(int naveID)
        {
            InitializeComponent();
            this.naveSkin = naveID;
        }

        //Cargamos el formulario
        private void frmMarcianos_Load(object sender, EventArgs e)
        {
            //Formulario
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.BackColor = System.Drawing.Color.Black;
            labScore.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "Space Invaders";
            this.muestraPuntuacion(0);

            //Power-ups hud
            foreach (Control cn in this.Controls)
            {
                if (cn is Label)
                {
                    ((Label)cn).Visible = false;
                    ((Label)cn).BackColor = System.Drawing.Color.Transparent;
                    ((Label)cn).ForeColor = System.Drawing.Color.Yellow;
                }
            }

            //Boss
            this.bajasParaBoss = this.rnd.Next(50, 130);
            barVidaBoss.Visible = false;
            pbBoss.Top = 0 - pbBoss.Height;

            //Skin
            this.skin();

            //Estrellas iniciales
            this.estrellasInicio();
        }

        #region Controles
        //Presionamos las teclas para movernos
        private void frmMarcianos_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Char.ToUpper(e.KeyChar))
            {
                case (char)Keys.D:
                    this.drcha = true;
                    break;
                case (char)Keys.A:
                    this.izq = true;
                    break;
                case (char)Keys.Space:
                    {
                        if (!this.disparo && barAmmo.Value > 0)
                        {
                            this.creaBalaBuena();
                            this.disparo = true;
                            barAmmo.Increment(-1);
                        }
                        break;
                    }
                case (char)Keys.Escape: menuPausa();
                    break;
            }

            //Fixeamos que no se vaya de la pantalla
            if (pbPlayer.Left > this.Width)
                pbPlayer.Left = 0 - pbPlayer.Width;
            else
                if (pbPlayer.Left < 0 - pbPlayer.Width)
                pbPlayer.Left = this.Width;
        }

        //Quitamos una tecla (arreglar spam de disparo)
        private void frmMarcianos_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Space:
                    this.disparo = false;
                    break;
                case (char)Keys.D:
                    this.drcha = false;
                    break;
                case (char)Keys.A:
                    this.izq = false;
                    break;
            }
        }
        #endregion

        #region Menu de pausa
        int opcionP;                                //Opcion de la pausa

        //Setter para modificar la opcion del menu
        public int Opcion { set { this.opcionP = value; } }

        //Menu de pausa
        private void menuPausa()
        {
            //Menú
            this.paraCronos();
            frmPause pausa = new frmPause(this);
            pausa.ShowDialog();

            //Opción elegida
            switch (this.opcionP)
            {
                case 0: this.reanudaCronos();
                    break;
                case 1:
                    {
                        frmMarcianos nuevoJuego = new frmMarcianos(this.naveSkin);
                        nuevoJuego.Show();
                        this.Close();
                    }
                    break;
                case 2:
                    {
                        frmMenu menu = new frmMenu(this.naveSkin);
                        menu.Show();
                        this.Close();
                    }
                    break;
            }
        }

        //Paramos los cronos
        private void paraCronos()
        {
            timerJuego.Stop();
            timerBorraPum.Stop();
            timerCuentaSegundos.Stop();
            timerDisparo.Stop();
            timerInvencible.Stop();
            timerVelocidad.Stop();
            timerBoss.Stop();
            timerTransicion.Stop();
        }

        //Reanudamos los cronos
        private void reanudaCronos()
        {
            //Cronos normales
            timerJuego.Start();
            timerBorraPum.Start();
            timerCuentaSegundos.Start();

            //Powers
            if (this.tiempos[0] < 30) timerInvencible.Start();
            if (this.tiempos[1] < 30) timerDisparo.Start();
            if (this.tiempos[2] < 30) timerVelocidad.Start();

            //Boss
            if (this.bossSpawn) timerBoss.Start();
            if (this.muertoBoss) timerTransicion.Start();
        }
        #endregion

        //Skin de la nave
        private void skin() => pbPlayer.Image = iLNaves.Images[this.naveSkin];

        //Contamos los segundos
        private void timerCuentaSegundos_Tick(object sender, EventArgs e) => this.datos[2]++;

        //Temporizador del juego
        private void timerJuego_Tick(object sender, EventArgs e)
        {
            //Vida de la nave
            if (barVidaNave.Value == 0)
                this.gameOver();

            //Movemos al personaje
            this.mueveNave();

            //Meteoro
            Random rnd = new Random();
            if (rnd.Next(0, 31) == 15 && this.enemigos)
                this.creaMeteoro();
            this.mueveMeteoro();
            this.choqueNave();

            //Balas del personaje
            this.mueveBalaBuena();
            this.colisionBalaNave();

            //Caza tie
            if (rnd.Next(0, 201) == 50 && this.enemigos)
                this.creaTie();
            this.mueveTie();

            //Balas tie
            this.mueveBalaTie();
            this.tieMataJugador();

            //Optimizamos
            this.borraObjetos();

            //Power-upds
            if (rnd.Next(0, 1001) == 500)
                if (this.powers)
                    this.crearPowerUp();
            this.muevePower();
            this.golpeaPower();

            //Estrellas
            if (rnd.Next(0, 51) == 25)
                this.creaEstrella();
            this.mueveEstrella();

            //Boss
            if (this.datos[1] == this.bajasParaBoss)
            {
                pbBoss.BringToFront();
                timerBoss.Start();
                pbBoss.Visible = true;
                this.enemigos = false;
                barVidaBoss.Visible = true;
                this.bossSpawn = true;
            }

            //Corazon
            if (rnd.Next(0, 801) == 400 && barVidaNave.Value < 100)
                this.creaCorazon();

            //Fixes del HUD
            confiHUD();
        }

        //Interfaz
        private void confiHUD()
        {
            barAmmo.BringToFront();
            barVidaNave.BringToFront();
            barVidaBoss.BringToFront();
            pbHP.BringToFront();
            pbAmmo.BringToFront();
            labGod.BringToFront();
            labScore.BringToFront();
            labShoot.BringToFront();
        }

        #region Movimiento
        //Movimiento de la nave
        private void mueveNave()
        {
            if (this.drcha)
                pbPlayer.Left += this.velozPersonaje;
            else if (this.izq)
                pbPlayer.Left -= this.velozPersonaje;
        }

        //Movimiento de los meteoros hacia abajo
        private void mueveMeteoro()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && (cn.Tag == "meteoro" || cn.Tag == "<3" || cn.Tag == "ammo"))
                    cn.Top += this.velozMeteoro;
            }
        }

        //Colisiones entre los meteoros y el personaje
        private void choqueNave()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && (cn.Tag == "meteoro" || cn.Tag == "tie"))
                    if (((PictureBox)cn).Bounds.IntersectsWith(pbPlayer.Bounds) && !this.god)
                    {
                        this.creaExplosion(pbPlayer);
                        this.Controls.Remove(cn);
                        barVidaNave.Increment(-25);
                    }
            }
        }

        //Movimiento de la bala
        private void mueveBalaBuena()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && cn.Tag == "balaB")
                    cn.Top -= this.velozBala;
            }
        }

        //Colisiones de la bala y los meteoros
        private void colisionBalaNave()
        {
            foreach (Control m in this.Controls)
            {
                foreach (Control b in this.Controls)
                {
                    if (m is PictureBox && (m.Tag == "meteoro" || m.Tag == "tie"))
                    {
                        if (b is PictureBox && b.Tag == "balaB")
                        {
                            if (((PictureBox)b).Bounds.IntersectsWith(m.Bounds))
                            {
                                this.creaExplosion((PictureBox)m);
                                this.Controls.Remove(m);
                                this.Controls.Remove(b);
                                if (m.Tag == "tie")
                                    this.datos[0]++;
                                else
                                {
                                    this.datos[1]++;
                                    if (this.rnd.Next(0, 11) == 5) this.creaAmmo((PictureBox)m);        //Creamos municion
                                }
                            }
                        }
                    }
                }
            }
        }

        //Movimiento del caza tie
        private void mueveTie()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && cn.Tag == "tie")
                {
                    cn.Top += this.velozTie;
                    cn.Left += this.derrapeTie;
                    if (rnd.Next(0, 21) == 10)
                        this.creaBalaTie((PictureBox)cn);
                }
            }
        }

        //Movimiento de la bala
        private void mueveBalaTie()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && cn.Tag == "balaM")
                    cn.Top += this.velozBalaTie;
            }
        }

        //Colision entre bala del tie y el jugador (vale para las balas del boss)
        private void tieMataJugador()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && (cn.Tag == "balaM" || cn.Tag == "balaBoss"))
                {
                    if (cn.Bounds.IntersectsWith(pbPlayer.Bounds) && !this.god)
                    {
                        this.creaExplosion(pbPlayer);
                        this.Controls.Remove(cn);
                        barVidaNave.Increment(-25);
                    }
                }
            }
        }

        //Borramos objetos si salen del mapa
        private void borraObjetos()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox)
                {
                    if (cn.Top > this.Height + cn.Height || cn.Top < 0 - cn.Height)
                        this.Controls.Remove(cn);
                }
            }
        }

        //Movimiento de los power-ups
        private void muevePower()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && (cn.Tag == "invencible" || cn.Tag == "disparo" || cn.Tag == "velocidad"))
                    cn.Top += 5;
            }
        }

        //Movimiento de las estrellas
        private void mueveEstrella()
        {
            foreach (Control star in this.Controls)
            {
                if (star is PictureBox && star.Tag == "star")
                    star.Top += this.velozStar;
            }
        }

        //Borramos las explosiones
        private void timerBorraPum_Tick(object sender, EventArgs e)
        {
            foreach (Control pum in this.Controls)
            {
                if (pum is PictureBox && pum.Tag == "pum")
                    this.Controls.Remove(pum);
            }
        }
        #endregion

        #region Crear objetos
        //Creamos el meteoro
        private void creaMeteoro()
        {
            int posX = rnd.Next(0, this.Width);             //Posición X

            Bitmap trans = new Bitmap(Properties.Resources.meteorito);
            trans.MakeTransparent();
            PictureBox pbMeteoro = new PictureBox();
            pbMeteoro.Image = trans;

            pbMeteoro.Size = new Size(40, 40);
            pbMeteoro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMeteoro.Tag = "meteoro";
            pbMeteoro.Left = rnd.Next(0, posX);
            pbMeteoro.Top = 0 - pbMeteoro.Height;
            this.Controls.Add(pbMeteoro);
            pbMeteoro.BringToFront();
        }

        //Creamos una bala de la nave principal
        private void creaBalaBuena()
        {
            PictureBox pbBala = new PictureBox();
            pbBala.Image = Properties.Resources.bullet;
            pbBala.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBala.Tag = "balaB";
            pbBala.Location = new Point(pbPlayer.Location.X + pbPlayer.Width / 2, pbPlayer.Location.Y);
            this.Controls.Add(pbBala);
            pbBala.BringToFront();
        }

        //Creamos un enemigo
        private void creaTie()
        {
            int pox = rnd.Next(0, this.Width);      //Posición X

            Bitmap trans = new Bitmap(Properties.Resources.tie);
            trans.MakeTransparent();
            PictureBox pbTIE = new PictureBox();
            pbTIE.Image = trans;

            pbTIE.Size = new Size(50, 50);
            pbTIE.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTIE.Tag = "tie";
            pbTIE.Location = new Point(pox, 0 - pbTIE.Height);
            this.Controls.Add(pbTIE);
            pbTIE.BringToFront();
        }

        //Creamos la bala del tie
        private void creaBalaTie(PictureBox pbTie)
        {
            PictureBox pbBalaTie = new PictureBox();
            pbBalaTie.Image = Properties.Resources.bullet_tie;
            pbBalaTie.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBalaTie.Tag = "balaM";
            pbBalaTie.Location = new Point(pbTie.Location.X + pbTie.Width / 2, pbTie.Location.Y + pbTie.Height);
            this.Controls.Add(pbBalaTie);
            pbBalaTie.BringToFront();
        }

        //Creamos un power-up
        private void crearPowerUp()
        {
            int power = rnd.Next(0, 3);         //Power-up que saldrá

            PictureBox pbPower = new PictureBox();
            pbPower.Image = iLpowerups.Images[power];
            pbPower.SizeMode = PictureBoxSizeMode.AutoSize;
            switch (power)
            {
                case 0:
                    pbPower.Tag = "invencible";
                    break;
                case 1:
                    pbPower.Tag = "velocidad";
                    break;
                case 2:
                    pbPower.Tag = "disparo";
                    break;
            }
            pbPower.Location = new Point(rnd.Next(0, this.Width), 0 - pbPower.Height);
            this.Controls.Add(pbPower);
            pbPower.BringToFront();
        }

        //Creamos una estrella
        private void creaEstrella()
        {
            int pox = rnd.Next(0, this.Width);

            Bitmap trans = new Bitmap(Properties.Resources.estrella);
            trans.MakeTransparent();
            PictureBox pbEstrella = new PictureBox();
            pbEstrella.Image = trans;

            pbEstrella.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEstrella.Size = new Size(10, 10);
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

        //Creamos una explosion
        private void creaExplosion(PictureBox objeto)
        {
            Bitmap trans = new Bitmap(Properties.Resources.explosion);
            trans.MakeTransparent();
            PictureBox pbPum = new PictureBox();
            pbPum.Image = trans;

            pbPum.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPum.Size = new Size(70, 70);
            pbPum.Tag = "pum";
            pbPum.Location = new Point(objeto.Location.X, objeto.Location.Y);
            this.Controls.Add(pbPum);
            pbPum.BringToFront();
        }

        //Creamos un corazon <3
        private void creaCorazon()
        {
            Bitmap hearth = new Bitmap(Properties.Resources.corazon);
            hearth.MakeTransparent();
            PictureBox pbHearth = new PictureBox();
            pbHearth.Image = hearth;

            pbHearth.Size = new Size(30, 30);
            pbHearth.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHearth.Tag = "<3";
            pbHearth.Location = new Point(rnd.Next(0, this.Width), 0 - pbHearth.Height);
            this.Controls.Add(pbHearth);
            pbHearth.BringToFront();
        }

        //Creamos municion
        private void creaAmmo(PictureBox pbMeteoro)
        {
            Bitmap ammo = new Bitmap(Properties.Resources.ammo);
            ammo.MakeTransparent();
            PictureBox pbAmmo = new PictureBox();
            pbAmmo.Image = ammo;

            pbAmmo.Size = new Size(10, 30);
            pbAmmo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAmmo.Tag = "ammo";
            pbAmmo.Location = new Point(pbMeteoro.Location.X, pbMeteoro.Location.Y);
            this.Controls.Add(pbAmmo);
            pbAmmo.BringToFront();
        }

        //Creamos estrellas al principio
        private void estrellasInicio()
        {
            int stars = this.rnd.Next(10, 21);

            for (int i = 0; i < stars; i++)
                this.creaEstrella(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
        }
        #endregion

        #region Powe-Ups     
        //Golpeamos un power-up
        private void golpeaPower()
        {
            foreach (Control cn in this.Controls)
            {
                if (cn is PictureBox && (cn.Tag == "invencible" || cn.Tag == "disparo" || cn.Tag == "velocidad" || cn.Tag == "<3" || cn.Tag == "ammo"))
                {
                    if (pbPlayer.Bounds.IntersectsWith(cn.Bounds))
                    {
                        switch (cn.Tag)
                        {
                            case "invencible":
                                {
                                    pbPlayer.Image = Properties.Resources.x_wing_invencible;
                                    this.god = true;
                                    labGod.Visible = true;
                                    labGod.Text = "God: 30";
                                    timerInvencible.Start();
                                    this.powers = false;
                                }
                                break;
                            case "disparo":
                                {
                                    this.velozBala += 10;
                                    labShoot.Visible = true;
                                    labShoot.Text = "Shoot: 30";
                                    timerDisparo.Start();
                                    this.powers = false;
                                }
                                break;
                            case "velocidad":
                                {
                                    this.velozStar = 3;
                                    this.velozPersonaje += 10;
                                    labSpeed.Visible = true;
                                    labSpeed.Text = "Speed: 30";
                                    timerVelocidad.Start();
                                    this.powers = false;
                                }
                                break;
                            case "<3": barVidaNave.Increment(25);
                                break;
                            case "ammo": barAmmo.Increment(50);
                                break;
                        }
                        this.Controls.Remove(cn);
                    }
                }
            }
        }

        //Powe-up de disparo
        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            this.tiempos[1]--;
            labShoot.Text = "Shoot: " + this.tiempos[1];
            if (this.tiempos[1] < 0)
            {
                this.tiempos[1] = 30;
                this.powers = true;
                this.velozBala -= 10;
                labShoot.Visible = false;
                timerDisparo.Stop();
            }
        }

        //Velocidad de la nave
        private void timerVelocidad_Tick(object sender, EventArgs e)
        {
            this.tiempos[2]--;
            labSpeed.Text = "Speed: " + this.tiempos[2];
            if (this.tiempos[2] < 0)
            {
                this.velozStar = 1;
                this.tiempos[2] = 30;
                this.powers = true;
                this.velozPersonaje -= 10;
                labSpeed.Visible = false;
                timerVelocidad.Stop();
            }
        }

        //Invencible
        private void timerInvencible_Tick(object sender, EventArgs e)
        {
            this.tiempos[0]--;
            labGod.Text = "God: " + this.tiempos[0];
            if (this.tiempos[0] < 0)
            {
                this.tiempos[0] = 30;
                this.powers = true;
                this.god = false;
                this.skin();
                labGod.Visible = false;
                timerInvencible.Stop();
            }
        }
        #endregion

        #region Boss       
        bool bossSpawn = false;         //Aparece el boss
        bool disparaBoss = true;        //Dispara el boss
        bool muertoBoss = false;        //Boss muerto
        int dx = 1;                     //Velocidad lateral del boss
        int dy = 1;                     //Velocidad vertical del boss
        int velozBallaBoss = 20;        //Velocidad de la bala del boss

        //Movimiento
        private void movimientoBoss() => pbBoss.Left += this.dx;

        //Aparicion del boss
        private void apareceBoss()
        {
            if (pbBoss.Top < 0)
                pbBoss.Top += this.dy;
        }

        //Timer del boss
        private void timerBoss_Tick(object sender, EventArgs e)
        {
            //Movimiento iza q drcha
            this.movimientoBoss();
            this.apareceBoss();
            if (pbBoss.Left > this.Width - pbBoss.Width)
                this.dx *= -1;
            else if (pbBoss.Left < 0)
                this.dx *= -1;

            //Creamos las balas del boss
            if (rnd.Next(0, 16) == 8 && this.disparaBoss)
                this.creaBalasBoss(rnd.Next(0, 300));
            this.movimientoBalasBoss();

            //Golpeamos al boss
            if (!this.muertoBoss)
                this.golpeaBoss();

            //Muere el boss
            if (barVidaBoss.Value <= 0 && !this.muertoBoss)
            {
                this.muertoBoss = true;
                this.disparaBoss = false;
                this.dx = 3;
                this.muereBoss();
                timerTransicion.Start();
            }
        }

        //Creamos las balas del boss
        private void creaBalasBoss(int pox)
        {
            PictureBox pbBalaBoss = new PictureBox();
            pbBalaBoss.Image = Properties.Resources.bullet_tie;
            pbBalaBoss.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBalaBoss.Tag = "balaBoss";
            pbBalaBoss.Location = new Point(pbBoss.Location.X + pox, pbBoss.Top + pbBoss.Height);
            this.Controls.Add(pbBalaBoss);
            pbBalaBoss.BringToFront();
        }

        //Movimiento de las balas del boss
        private void movimientoBalasBoss()
        {
            foreach (Control bullet in this.Controls)
            {
                if (bullet is PictureBox && bullet.Tag == "balaBoss")
                    bullet.Top += this.velozBallaBoss;
            }
        }

        //Golpeamos al boss
        private void golpeaBoss()
        {
            foreach (Control bullet in this.Controls)
            {
                if (bullet is PictureBox && bullet.Tag == "balaB")
                {
                    if (pbBoss.Bounds.IntersectsWith(bullet.Bounds) && pbBoss.Visible)
                    {
                        if (this.rnd.Next(0, 21) == 5) this.creaAmmo((PictureBox)bullet);
                        this.creaExplosion((PictureBox)bullet);
                        this.Controls.Remove(bullet);
                        barVidaBoss.Increment(-1);
                    }
                }
            }
        }

        //Muere boss
        private void muereBoss()
        {
            //Gran explosion
            Bitmap pumG = new Bitmap(Properties.Resources.boss_explosion);
            pumG.MakeTransparent();
            PictureBox pbExpl = new PictureBox();
            pbExpl.Image = pumG;
            pbExpl.Size = new Size(300, 300);
            pbExpl.SizeMode = PictureBoxSizeMode.StretchImage;
            pbExpl.Location = (new Point(pbBoss.Left, pbBoss.Top));
            this.Controls.Add(pbExpl);
            pbExpl.BringToFront();

            //Quitamos los sprites del boss
            this.Controls.Remove(pbBoss);
            this.Controls.Remove(barVidaBoss);
        }

        //Ganamos la partida
        private void timerTransicion_Tick(object sender, EventArgs e) => this.gameOver();
        #endregion

        #region Game Over
        //Game Over
        private void gameOver()
        {
            frmPuntuacion muestraPuntuacion = new frmPuntuacion(this.datos[0], this.datos[1], this.datos[2], this.muertoBoss, this.naveSkin);
            muestraPuntuacion.Show();
            this.Close();
        }

        //Mostramos la puntuacion
        private void muestraPuntuacion(int suma)
        {
            this.score += suma;
            labScore.Text = "Score: " + this.score.ToString();
        }
        #endregion
    }
}