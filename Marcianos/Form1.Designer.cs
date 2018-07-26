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
            this.timerVelocidad = new System.Windows.Forms.Timer(this.components);
            this.timerInvencible = new System.Windows.Forms.Timer(this.components);
            this.timerBoss = new System.Windows.Forms.Timer(this.components);
            this.barVidaBoss = new System.Windows.Forms.ProgressBar();
            this.barVidaNave = new System.Windows.Forms.ProgressBar();
            this.timerBorraPum = new System.Windows.Forms.Timer(this.components);
            this.timerTransicion = new System.Windows.Forms.Timer(this.components);
            this.iLNaves = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barAmmo = new System.Windows.Forms.ProgressBar();
            this.pbAmmo = new System.Windows.Forms.PictureBox();
            this.pbHP = new System.Windows.Forms.PictureBox();
            this.pbBoss = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.labNoAmmo = new System.Windows.Forms.Label();
            this.barPotenciador = new System.Windows.Forms.ProgressBar();
            this.labPotenciador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmmo)).BeginInit();
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
            this.labScore.Location = new System.Drawing.Point(519, 461);
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
            // timerVelocidad
            // 
            this.timerVelocidad.Interval = 1000;
            this.timerVelocidad.Tick += new System.EventHandler(this.timerVelocidad_Tick);
            // 
            // timerInvencible
            // 
            this.timerInvencible.Interval = 1000;
            this.timerInvencible.Tick += new System.EventHandler(this.timerInvencible_Tick);
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
            // barAmmo
            // 
            this.barAmmo.ForeColor = System.Drawing.Color.Red;
            this.barAmmo.Location = new System.Drawing.Point(485, 638);
            this.barAmmo.Name = "barAmmo";
            this.barAmmo.Size = new System.Drawing.Size(124, 23);
            this.barAmmo.Step = 25;
            this.barAmmo.TabIndex = 9;
            this.barAmmo.Value = 100;
            // 
            // pbAmmo
            // 
            this.pbAmmo.BackColor = System.Drawing.Color.Transparent;
            this.pbAmmo.Image = ((System.Drawing.Image)(resources.GetObject("pbAmmo.Image")));
            this.pbAmmo.Location = new System.Drawing.Point(463, 638);
            this.pbAmmo.Name = "pbAmmo";
            this.pbAmmo.Size = new System.Drawing.Size(16, 23);
            this.pbAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAmmo.TabIndex = 10;
            this.pbAmmo.TabStop = false;
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
            this.pbPlayer.Location = new System.Drawing.Point(272, 565);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 70);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // labNoAmmo
            // 
            this.labNoAmmo.AutoSize = true;
            this.labNoAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoAmmo.ForeColor = System.Drawing.Color.Red;
            this.labNoAmmo.Location = new System.Drawing.Point(500, 615);
            this.labNoAmmo.Name = "labNoAmmo";
            this.labNoAmmo.Size = new System.Drawing.Size(94, 20);
            this.labNoAmmo.TabIndex = 11;
            this.labNoAmmo.Text = "(no ammo)";
            // 
            // barPotenciador
            // 
            this.barPotenciador.Location = new System.Drawing.Point(547, 12);
            this.barPotenciador.Name = "barPotenciador";
            this.barPotenciador.Size = new System.Drawing.Size(62, 23);
            this.barPotenciador.TabIndex = 12;
            // 
            // labPotenciador
            // 
            this.labPotenciador.AutoSize = true;
            this.labPotenciador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPotenciador.Location = new System.Drawing.Point(483, 15);
            this.labPotenciador.Name = "labPotenciador";
            this.labPotenciador.Size = new System.Drawing.Size(58, 20);
            this.labPotenciador.TabIndex = 13;
            this.labPotenciador.Text = "Power";
            // 
            // frmMarcianos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 673);
            this.Controls.Add(this.labPotenciador);
            this.Controls.Add(this.barPotenciador);
            this.Controls.Add(this.labNoAmmo);
            this.Controls.Add(this.pbAmmo);
            this.Controls.Add(this.barAmmo);
            this.Controls.Add(this.pbHP);
            this.Controls.Add(this.barVidaNave);
            this.Controls.Add(this.barVidaBoss);
            this.Controls.Add(this.pbBoss);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.pbPlayer);
            this.Name = "frmMarcianos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMarcianos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMarcianos_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMarcianos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbAmmo)).EndInit();
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
        private System.Windows.Forms.Timer timerVelocidad;
        private System.Windows.Forms.Timer timerInvencible;
        private System.Windows.Forms.PictureBox pbBoss;
        private System.Windows.Forms.Timer timerBoss;
        private System.Windows.Forms.ProgressBar barVidaBoss;
        private System.Windows.Forms.ProgressBar barVidaNave;
        private System.Windows.Forms.Timer timerBorraPum;
        private System.Windows.Forms.Timer timerTransicion;
        private System.Windows.Forms.ImageList iLNaves;
        private System.Windows.Forms.PictureBox pbHP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar barAmmo;
        private System.Windows.Forms.PictureBox pbAmmo;
        private System.Windows.Forms.Label labNoAmmo;
        private System.Windows.Forms.ProgressBar barPotenciador;
        private System.Windows.Forms.Label labPotenciador;
    }
}

