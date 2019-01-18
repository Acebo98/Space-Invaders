namespace Marcianos
{
    partial class frmPuntuacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntuacion));
            this.labGameOver = new System.Windows.Forms.Label();
            this.labNew = new System.Windows.Forms.Label();
            this.labEnemigos = new System.Windows.Forms.Label();
            this.labMeteors = new System.Windows.Forms.Label();
            this.labTiempo = new System.Windows.Forms.Label();
            this.labScoreFinal = new System.Windows.Forms.Label();
            this.timerPuntuacion = new System.Windows.Forms.Timer(this.components);
            this.labBossKilled = new System.Windows.Forms.Label();
            this.pbNave = new System.Windows.Forms.PictureBox();
            this.iLNaves = new System.Windows.Forms.ImageList(this.components);
            this.timerEstrellas = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).BeginInit();
            this.SuspendLayout();
            // 
            // labGameOver
            // 
            this.labGameOver.AutoSize = true;
            this.labGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGameOver.Location = new System.Drawing.Point(32, 44);
            this.labGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGameOver.Name = "labGameOver";
            this.labGameOver.Size = new System.Drawing.Size(363, 73);
            this.labGameOver.TabIndex = 0;
            this.labGameOver.Text = "Game Over";
            // 
            // labNew
            // 
            this.labNew.AutoSize = true;
            this.labNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNew.Location = new System.Drawing.Point(215, 114);
            this.labNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNew.Name = "labNew";
            this.labNew.Size = new System.Drawing.Size(168, 26);
            this.labNew.TabIndex = 1;
            this.labNew.Text = "New high score!";
            // 
            // labEnemigos
            // 
            this.labEnemigos.AutoSize = true;
            this.labEnemigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnemigos.Location = new System.Drawing.Point(41, 190);
            this.labEnemigos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEnemigos.Name = "labEnemigos";
            this.labEnemigos.Size = new System.Drawing.Size(118, 20);
            this.labEnemigos.TabIndex = 2;
            this.labEnemigos.Text = "Enemies killed: ";
            // 
            // labMeteors
            // 
            this.labMeteors.AutoSize = true;
            this.labMeteors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMeteors.Location = new System.Drawing.Point(41, 249);
            this.labMeteors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMeteors.Name = "labMeteors";
            this.labMeteors.Size = new System.Drawing.Size(153, 20);
            this.labMeteors.TabIndex = 3;
            this.labMeteors.Text = "Meteors destroyed:  ";
            // 
            // labTiempo
            // 
            this.labTiempo.AutoSize = true;
            this.labTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiempo.Location = new System.Drawing.Point(41, 308);
            this.labTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTiempo.Name = "labTiempo";
            this.labTiempo.Size = new System.Drawing.Size(112, 20);
            this.labTiempo.TabIndex = 4;
            this.labTiempo.Text = "Time survived: ";
            // 
            // labScoreFinal
            // 
            this.labScoreFinal.AutoSize = true;
            this.labScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScoreFinal.Location = new System.Drawing.Point(41, 376);
            this.labScoreFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labScoreFinal.Name = "labScoreFinal";
            this.labScoreFinal.Size = new System.Drawing.Size(107, 20);
            this.labScoreFinal.TabIndex = 5;
            this.labScoreFinal.Text = "Final score: ";
            // 
            // timerPuntuacion
            // 
            this.timerPuntuacion.Interval = 1000;
            this.timerPuntuacion.Tick += new System.EventHandler(this.timerPuntuacion_Tick);
            // 
            // labBossKilled
            // 
            this.labBossKilled.AutoSize = true;
            this.labBossKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBossKilled.Location = new System.Drawing.Point(249, 146);
            this.labBossKilled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBossKilled.Name = "labBossKilled";
            this.labBossKilled.Size = new System.Drawing.Size(128, 20);
            this.labBossKilled.TabIndex = 7;
            this.labBossKilled.Text = "Boss killed + 200";
            // 
            // pbNave
            // 
            this.pbNave.Location = new System.Drawing.Point(287, 236);
            this.pbNave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(93, 91);
            this.pbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNave.TabIndex = 8;
            this.pbNave.TabStop = false;
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
            // timerEstrellas
            // 
            this.timerEstrellas.Enabled = true;
            this.timerEstrellas.Interval = 1;
            this.timerEstrellas.Tick += new System.EventHandler(this.timerEstrellas_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(325, 400);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 27);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnSeleccion_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(325, 369);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Score";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSeleccion_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // frmPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 437);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbNave);
            this.Controls.Add(this.labBossKilled);
            this.Controls.Add(this.labScoreFinal);
            this.Controls.Add(this.labTiempo);
            this.Controls.Add(this.labMeteors);
            this.Controls.Add(this.labEnemigos);
            this.Controls.Add(this.labNew);
            this.Controls.Add(this.labGameOver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPuntuacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPuntuacion";
            this.Load += new System.EventHandler(this.frmPuntuacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGameOver;
        private System.Windows.Forms.Label labNew;
        private System.Windows.Forms.Label labEnemigos;
        private System.Windows.Forms.Label labMeteors;
        private System.Windows.Forms.Label labTiempo;
        private System.Windows.Forms.Label labScoreFinal;
        private System.Windows.Forms.Timer timerPuntuacion;
        private System.Windows.Forms.Label labBossKilled;
        private System.Windows.Forms.PictureBox pbNave;
        private System.Windows.Forms.ImageList iLNaves;
        private System.Windows.Forms.Timer timerEstrellas;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}