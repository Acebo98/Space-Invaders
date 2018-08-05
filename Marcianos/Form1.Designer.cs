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
            this.labNoAmmo = new System.Windows.Forms.Label();
            this.barPotenciador = new System.Windows.Forms.ProgressBar();
            this.labPotenciador = new System.Windows.Forms.Label();
            this.pbAmmo = new System.Windows.Forms.PictureBox();
            this.pbHP = new System.Windows.Forms.PictureBox();
            this.pbBoss = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbSkull = new System.Windows.Forms.PictureBox();
            this.timerIman = new System.Windows.Forms.Timer(this.components);
            this.barIman = new System.Windows.Forms.ProgressBar();
            this.labIman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull)).BeginInit();
            this.SuspendLayout();
            // 
            // timerJuego
            // 
            this.timerJuego.Enabled = true;
            this.timerJuego.Interval = 1;
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick);
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
            this.barVidaBoss.Location = new System.Drawing.Point(25, 8);
            this.barVidaBoss.Margin = new System.Windows.Forms.Padding(2);
            this.barVidaBoss.Name = "barVidaBoss";
            this.barVidaBoss.Size = new System.Drawing.Size(83, 16);
            this.barVidaBoss.Step = 1;
            this.barVidaBoss.TabIndex = 6;
            this.barVidaBoss.Value = 100;
            // 
            // barVidaNave
            // 
            this.barVidaNave.ForeColor = System.Drawing.Color.Red;
            this.barVidaNave.Location = new System.Drawing.Point(25, 415);
            this.barVidaNave.Margin = new System.Windows.Forms.Padding(2);
            this.barVidaNave.Name = "barVidaNave";
            this.barVidaNave.Size = new System.Drawing.Size(83, 15);
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
            this.barAmmo.Location = new System.Drawing.Point(596, 415);
            this.barAmmo.Margin = new System.Windows.Forms.Padding(2);
            this.barAmmo.Name = "barAmmo";
            this.barAmmo.Size = new System.Drawing.Size(83, 15);
            this.barAmmo.Step = 25;
            this.barAmmo.TabIndex = 9;
            this.barAmmo.Value = 100;
            // 
            // labNoAmmo
            // 
            this.labNoAmmo.AutoSize = true;
            this.labNoAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoAmmo.ForeColor = System.Drawing.Color.Red;
            this.labNoAmmo.Location = new System.Drawing.Point(603, 399);
            this.labNoAmmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNoAmmo.Name = "labNoAmmo";
            this.labNoAmmo.Size = new System.Drawing.Size(65, 13);
            this.labNoAmmo.TabIndex = 11;
            this.labNoAmmo.Text = "(no ammo)";
            // 
            // barPotenciador
            // 
            this.barPotenciador.Location = new System.Drawing.Point(638, 8);
            this.barPotenciador.Margin = new System.Windows.Forms.Padding(2);
            this.barPotenciador.Name = "barPotenciador";
            this.barPotenciador.Size = new System.Drawing.Size(41, 15);
            this.barPotenciador.TabIndex = 12;
            // 
            // labPotenciador
            // 
            this.labPotenciador.AutoSize = true;
            this.labPotenciador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPotenciador.Location = new System.Drawing.Point(592, 9);
            this.labPotenciador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPotenciador.Name = "labPotenciador";
            this.labPotenciador.Size = new System.Drawing.Size(42, 13);
            this.labPotenciador.TabIndex = 13;
            this.labPotenciador.Text = "Power";
            // 
            // pbAmmo
            // 
            this.pbAmmo.BackColor = System.Drawing.Color.Transparent;
            this.pbAmmo.Image = ((System.Drawing.Image)(resources.GetObject("pbAmmo.Image")));
            this.pbAmmo.Location = new System.Drawing.Point(581, 415);
            this.pbAmmo.Margin = new System.Windows.Forms.Padding(2);
            this.pbAmmo.Name = "pbAmmo";
            this.pbAmmo.Size = new System.Drawing.Size(11, 15);
            this.pbAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAmmo.TabIndex = 10;
            this.pbAmmo.TabStop = false;
            // 
            // pbHP
            // 
            this.pbHP.BackColor = System.Drawing.Color.Transparent;
            this.pbHP.Image = global::Marcianos.Properties.Resources.hp_bar;
            this.pbHP.Location = new System.Drawing.Point(4, 415);
            this.pbHP.Margin = new System.Windows.Forms.Padding(2);
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(17, 15);
            this.pbHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHP.TabIndex = 8;
            this.pbHP.TabStop = false;
            // 
            // pbBoss
            // 
            this.pbBoss.BackColor = System.Drawing.Color.Transparent;
            this.pbBoss.Image = global::Marcianos.Properties.Resources.boss;
            this.pbBoss.Location = new System.Drawing.Point(171, 9);
            this.pbBoss.Margin = new System.Windows.Forms.Padding(2);
            this.pbBoss.Name = "pbBoss";
            this.pbBoss.Size = new System.Drawing.Size(339, 144);
            this.pbBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoss.TabIndex = 5;
            this.pbBoss.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::Marcianos.Properties.Resources.x_wing;
            this.pbPlayer.Location = new System.Drawing.Point(313, 367);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(47, 45);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbSkull
            // 
            this.pbSkull.BackColor = System.Drawing.Color.Transparent;
            this.pbSkull.Image = global::Marcianos.Properties.Resources.skull_boss;
            this.pbSkull.Location = new System.Drawing.Point(4, 8);
            this.pbSkull.Margin = new System.Windows.Forms.Padding(2);
            this.pbSkull.Name = "pbSkull";
            this.pbSkull.Size = new System.Drawing.Size(17, 15);
            this.pbSkull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSkull.TabIndex = 14;
            this.pbSkull.TabStop = false;
            // 
            // timerIman
            // 
            this.timerIman.Interval = 1000;
            this.timerIman.Tick += new System.EventHandler(this.timerIman_Tick);
            // 
            // barIman
            // 
            this.barIman.Location = new System.Drawing.Point(638, 25);
            this.barIman.Margin = new System.Windows.Forms.Padding(2);
            this.barIman.Name = "barIman";
            this.barIman.Size = new System.Drawing.Size(41, 15);
            this.barIman.TabIndex = 15;
            // 
            // labIman
            // 
            this.labIman.AutoSize = true;
            this.labIman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIman.Location = new System.Drawing.Point(585, 25);
            this.labIman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labIman.Name = "labIman";
            this.labIman.Size = new System.Drawing.Size(49, 13);
            this.labIman.TabIndex = 16;
            this.labIman.Text = "Magnet";
            // 
            // frmMarcianos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.labIman);
            this.Controls.Add(this.barIman);
            this.Controls.Add(this.pbSkull);
            this.Controls.Add(this.labPotenciador);
            this.Controls.Add(this.barPotenciador);
            this.Controls.Add(this.labNoAmmo);
            this.Controls.Add(this.pbAmmo);
            this.Controls.Add(this.barAmmo);
            this.Controls.Add(this.pbHP);
            this.Controls.Add(this.barVidaNave);
            this.Controls.Add(this.barVidaBoss);
            this.Controls.Add(this.pbBoss);
            this.Controls.Add(this.pbPlayer);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerJuego;
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
        private System.Windows.Forms.PictureBox pbSkull;
        private System.Windows.Forms.Timer timerIman;
        private System.Windows.Forms.ProgressBar barIman;
        private System.Windows.Forms.Label labIman;
    }
}

