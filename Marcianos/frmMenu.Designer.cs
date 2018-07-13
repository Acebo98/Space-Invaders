namespace Marcianos
{
    partial class frmMenu
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
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnControles = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            this.timerEstrellas = new System.Windows.Forms.Timer(this.components);
            this.labMove = new System.Windows.Forms.Label();
            this.labSpace = new System.Windows.Forms.Label();
            this.labInfoShoot = new System.Windows.Forms.Label();
            this.labInfoMove = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.labVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.White;
            this.labTitulo.Location = new System.Drawing.Point(16, 65);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(597, 114);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Space Invaders";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(193, 278);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(218, 65);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "Play";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btn_Seleccion_Click);
            this.btnJugar.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnJugar.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // btnControles
            // 
            this.btnControles.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControles.Location = new System.Drawing.Point(193, 392);
            this.btnControles.Name = "btnControles";
            this.btnControles.Size = new System.Drawing.Size(218, 65);
            this.btnControles.TabIndex = 3;
            this.btnControles.Text = "Controls";
            this.btnControles.UseVisualStyleBackColor = true;
            this.btnControles.Click += new System.EventHandler(this.btn_Seleccion_Click);
            this.btnControles.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnControles.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // btnTienda
            // 
            this.btnTienda.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienda.Location = new System.Drawing.Point(193, 506);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(218, 65);
            this.btnTienda.TabIndex = 4;
            this.btnTienda.Text = "Shop";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btn_Seleccion_Click);
            this.btnTienda.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnTienda.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // timerEstrellas
            // 
            this.timerEstrellas.Enabled = true;
            this.timerEstrellas.Interval = 20;
            this.timerEstrellas.Tick += new System.EventHandler(this.timerEstrellas_Tick);
            // 
            // labMove
            // 
            this.labMove.AutoSize = true;
            this.labMove.BackColor = System.Drawing.Color.Transparent;
            this.labMove.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMove.ForeColor = System.Drawing.Color.White;
            this.labMove.Location = new System.Drawing.Point(457, 403);
            this.labMove.Name = "labMove";
            this.labMove.Size = new System.Drawing.Size(105, 28);
            this.labMove.TabIndex = 5;
            this.labMove.Text = "A D (Keys)";
            // 
            // labSpace
            // 
            this.labSpace.AutoSize = true;
            this.labSpace.BackColor = System.Drawing.Color.Transparent;
            this.labSpace.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSpace.ForeColor = System.Drawing.Color.White;
            this.labSpace.Location = new System.Drawing.Point(41, 403);
            this.labSpace.Name = "labSpace";
            this.labSpace.Size = new System.Drawing.Size(104, 28);
            this.labSpace.TabIndex = 6;
            this.labSpace.Text = "Space bar";
            // 
            // labInfoShoot
            // 
            this.labInfoShoot.AutoSize = true;
            this.labInfoShoot.BackColor = System.Drawing.Color.Transparent;
            this.labInfoShoot.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfoShoot.ForeColor = System.Drawing.Color.White;
            this.labInfoShoot.Location = new System.Drawing.Point(59, 432);
            this.labInfoShoot.Name = "labInfoShoot";
            this.labInfoShoot.Size = new System.Drawing.Size(64, 28);
            this.labInfoShoot.TabIndex = 7;
            this.labInfoShoot.Text = "Shoot";
            // 
            // labInfoMove
            // 
            this.labInfoMove.AutoSize = true;
            this.labInfoMove.BackColor = System.Drawing.Color.Transparent;
            this.labInfoMove.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfoMove.ForeColor = System.Drawing.Color.White;
            this.labInfoMove.Location = new System.Drawing.Point(480, 432);
            this.labInfoMove.Name = "labInfoMove";
            this.labInfoMove.Size = new System.Drawing.Size(59, 28);
            this.labInfoMove.TabIndex = 8;
            this.labInfoMove.Text = "Move";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(538, 626);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVersion.ForeColor = System.Drawing.Color.White;
            this.labVersion.Location = new System.Drawing.Point(12, 629);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(39, 28);
            this.labVersion.TabIndex = 10;
            this.labVersion.Text = "1.0";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 673);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.labInfoMove);
            this.Controls.Add(this.labInfoShoot);
            this.Controls.Add(this.labSpace);
            this.Controls.Add(this.labMove);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.btnControles);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.labTitulo);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnControles;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Timer timerEstrellas;
        private System.Windows.Forms.Label labMove;
        private System.Windows.Forms.Label labSpace;
        private System.Windows.Forms.Label labInfoShoot;
        private System.Windows.Forms.Label labInfoMove;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label labVersion;
    }
}