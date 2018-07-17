namespace Marcianos
{
    partial class frmMarcianos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcianos));
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.labScore = new System.Windows.Forms.Label();
            this.timerCuentaSegundos = new System.Windows.Forms.Timer(this.components);
            this.iLpowerups = new System.Windows.Forms.ImageList(this.components);
            this.timerDisparo = new System.Windows.Forms.Timer(this.components);
            this.labShoot = new System.Windows.Forms.Label();
            this.timerVelocidad = new System.Windows.Forms.Timer(this.components);
            this.labSpeed = new System.Windows.Forms.Label();
            this.timerInvencible = new System.Windows.Forms.Timer(this.components);
            this.labGod = new System.Windows.Forms.Label();
            this.timerBoss = new System.Windows.Forms.Timer(this.components);
            this.barVidaBoss = new System.Windows.Forms.ProgressBar();
            this.barVidaNave = new System.Windows.Forms.ProgressBar();
            this.timerBorraPum = new System.Windows.Forms.Timer(this.components);
            this.timerTransicion = new System.Windows.Forms.Timer(this.components);
            this.iLNaves = new System.Windows.Forms.ImageList(this.components);
            this.pbHP = new System.Windows.Forms.PictureBox();
            this.pbBoss = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timerJuego
            // 
            this.timerJuego.Enabled = true;
            this.timerJuego.Interval = 1;
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(515, 531);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(94, 26);
            this.labScore.TabIndex = 1;
            this.labScore.Text = "Score:_";
            // 
            // timerCuentaSegundos
            // 
            this.timerCuentaSegundos.Enabled = true;
            this.timerCuentaSegundos.Interval = 1000;
            this.timerCuentaSegundos.Tick += new System.EventHandler(this.timerCuentaSegundos_Tick);
            // 
            // iLpowerups
            // 
            this.iLpowerups.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLpowerups.ImageStream")));
            this.iLpowerups.TransparentColor = System.Drawing.Color.Transparent;
            this.iLpowerups.Images.SetKeyName(0, "poweup_invencible.png");
            this.iLpowerups.Images.SetKeyName(1, "poweup_velocidad.png");
            this.iLpowerups.Images.SetKeyName(2, "poweup_disparar.png");
            // 
            // timerDisparo
            // 
            this.timerDisparo.Interval = 1000;
            this.timerDisparo.Tick += new System.EventHandler(this.timerDisparo_Tick);
            // 
            // labShoot
            // 
            this.labShoot.AutoSize = true;
            this.labShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShoot.Location = new System.Drawing.Point(497, 609);
            this.labShoot.Name = "labShoot";
            this.labShoot.Size = new System.Drawing.Size(114, 26);
            this.labShoot.TabIndex = 2;
            this.labShoot.Text = "Shoot: 30";
            // 
            // timerVelocidad
            // 
            this.timerVelocidad.Interval = 1000;
            this.timerVelocidad.Tick += new System.EventHandler(this.timerVelocidad_Tick);
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSpeed.Location = new System.Drawing.Point(491, 557);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(120, 26);
            this.labSpeed.TabIndex = 3;
            this.labSpeed.Text = "Speed: 30";
            // 
            // timerInvencible
            // 
            this.timerInvencible.Interval = 1000;
            this.timerInvencible.Tick += new System.EventHandler(this.timerInvencible_Tick);
            // 
            // labGod
            // 
            this.labGod.AutoSize = true;
            this.labGod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGod.Location = new System.Drawing.Point(515, 583);
            this.labGod.Name = "labGod";
            this.labGod.Size = new System.Drawing.Size(96, 26);
            this.labGod.TabIndex = 4;
            this.labGod.Text = "God: 30";
            // 
            // timerBoss
            // 
            this.timerBoss.Interval = 20;
            this.timerBoss.Tick += new System.EventHandler(this.timerBoss_Tick);
            // 
            // barVidaBoss
            // 
            this.barVidaBoss.BackColor = System.Drawing.SystemColors.Control;
            this.barVidaBoss.ForeColor = System.Drawing.Color.Red;
            this.barVidaBoss.Location = new System.Drawing.Point(12, 12);
            this.barVidaBoss.Name = "barVidaBoss";
            this.barVidaBoss.Size = new System.Drawing.Size(124, 25);
            this.barVidaBoss.Step = 1;
            this.barVidaBoss.TabIndex = 6;
            this.barVidaBoss.Value = 100;
            // 
            // barVidaNave
            // 
            this.barVidaNave.ForeColor = System.Drawing.Color.Red;
            this.barVidaNave.Location = new System.Drawing.Point(37, 638);
            this.barVidaNave.Name = "barVidaNave";
            this.barVidaNave.Size = new System.Drawing.Size(124, 23);
            this.barVidaNave.Step = 25;
            this.barVidaNave.TabIndex = 7;
            this.barVidaNave.Value = 100;
            // 
            // timerBorraPum
            // 
            this.timerBorraPum.Enabled = true;
            this.timerBorraPum.Interval = 1000;
            this.timerBorraPum.Tick += new System.EventHandler(this.timerBorraPum_Tick);
            // 
            // timerTransicion
            // 
            this.timerTransicion.Interval = 2000;
            this.timerTransicion.Tick += new System.EventHandler(this.timerTransicion_Tick);
            // 
            // iLNaves
            // 
            this.iLNaves.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLNaves.ImageStream")));
            this.iLNaves.TransparentColor = System.Drawing.Color.Transparent;
            this.iLNaves.Images.SetKeyName(0, "x_wing.png");
            this.iLNaves.Images.SetKeyName(1, "x_wing_2.png");
            this.iLNaves.Images.SetKeyName(2, "x_wing_3.png");
            this.iLNaves.Images.SetKeyName(3, "x_wing_4.png");
            // 
            // pbHP
            // 
            this.pbHP.BackColor = System.Drawing.Color.Transparent;
            this.pbHP.Image = global::Marcianos.Properties.Resources.hp_bar;
            this.pbHP.Location = new System.Drawing.Point(6, 638);
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(25, 23);
            this.pbHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHP.TabIndex = 8;
            this.pbHP.TabStop = false;
            // 
            // pbBoss
            // 
            this.pbBoss.BackColor = System.Drawing.Color.Transparent;
            this.pbBoss.Image = global::Marcianos.Properties.Resources.boss;
            this.pbBoss.Location = new System.Drawing.Point(54, 12);
            this.pbBoss.Name = "pbBoss";
            this.pbBoss.Size = new System.Drawing.Size(508, 221);
            this.pbBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoss.TabIndex = 5;
            this.pbBoss.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::Marcianos.Properties.Resources.x_wing;
            this.pbPlayer.Location = new System.Drawing.Point(268, 591);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 70);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // frmMarcianos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 673);
            this.Controls.Add(this.pbHP);
            this.Controls.Add(this.barVidaNave);
            this.Controls.Add(this.barVidaBoss);
            this.Controls.Add(this.pbBoss);
            this.Controls.Add(this.labGod);
            this.Controls.Add(this.labSpeed);
            this.Controls.Add(this.labShoot);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.pbPlayer);
            this.Name = "frmMarcianos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMarcianos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMarcianos_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMarcianos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerJuego;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer timerCuentaSegundos;
        private System.Windows.Forms.ImageList iLpowerups;
        private System.Windows.Forms.Timer timerDisparo;
        private System.Windows.Forms.Label labShoot;
        private System.Windows.Forms.Timer timerVelocidad;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.Timer timerInvencible;
        private System.Windows.Forms.Label labGod;
        private System.Windows.Forms.PictureBox pbBoss;
        private System.Windows.Forms.Timer timerBoss;
        private System.Windows.Forms.ProgressBar barVidaBoss;
        private System.Windows.Forms.ProgressBar barVidaNave;
        private System.Windows.Forms.Timer timerBorraPum;
        private System.Windows.Forms.Timer timerTransicion;
        private System.Windows.Forms.ImageList iLNaves;
        private System.Windows.Forms.PictureBox pbHP;
    }
}

