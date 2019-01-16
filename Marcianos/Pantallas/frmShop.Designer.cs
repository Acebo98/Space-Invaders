namespace Marcianos
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.labShop = new System.Windows.Forms.Label();
            this.labHighScore = new System.Windows.Forms.Label();
            this.pbN1 = new System.Windows.Forms.PictureBox();
            this.pbN2 = new System.Windows.Forms.PictureBox();
            this.pbN3 = new System.Windows.Forms.PictureBox();
            this.pbN4 = new System.Windows.Forms.PictureBox();
            this.iLNaves = new System.Windows.Forms.ImageList(this.components);
            this.labN1 = new System.Windows.Forms.Label();
            this.labN2 = new System.Windows.Forms.Label();
            this.labN3 = new System.Windows.Forms.Label();
            this.labN4 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.timerEstrellas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN4)).BeginInit();
            this.SuspendLayout();
            // 
            // labShop
            // 
            this.labShop.AutoSize = true;
            this.labShop.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShop.Location = new System.Drawing.Point(240, 9);
            this.labShop.Name = "labShop";
            this.labShop.Size = new System.Drawing.Size(131, 67);
            this.labShop.TabIndex = 0;
            this.labShop.Text = "Shop";
            // 
            // labHighScore
            // 
            this.labHighScore.AutoSize = true;
            this.labHighScore.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHighScore.Location = new System.Drawing.Point(12, 584);
            this.labHighScore.Name = "labHighScore";
            this.labHighScore.Size = new System.Drawing.Size(178, 28);
            this.labHighScore.TabIndex = 1;
            this.labHighScore.Text = "Hight Score: 0000";
            // 
            // pbN1
            // 
            this.pbN1.Location = new System.Drawing.Point(76, 130);
            this.pbN1.Name = "pbN1";
            this.pbN1.Size = new System.Drawing.Size(130, 130);
            this.pbN1.TabIndex = 3;
            this.pbN1.TabStop = false;
            this.pbN1.Tag = "0";
            this.pbN1.Click += new System.EventHandler(this.pbNave_Seleccion);
            // 
            // pbN2
            // 
            this.pbN2.Location = new System.Drawing.Point(405, 130);
            this.pbN2.Name = "pbN2";
            this.pbN2.Size = new System.Drawing.Size(130, 130);
            this.pbN2.TabIndex = 4;
            this.pbN2.TabStop = false;
            this.pbN2.Tag = "100";
            this.pbN2.Click += new System.EventHandler(this.pbNave_Seleccion);
            // 
            // pbN3
            // 
            this.pbN3.Location = new System.Drawing.Point(76, 361);
            this.pbN3.Name = "pbN3";
            this.pbN3.Size = new System.Drawing.Size(130, 130);
            this.pbN3.TabIndex = 5;
            this.pbN3.TabStop = false;
            this.pbN3.Tag = "300";
            this.pbN3.Click += new System.EventHandler(this.pbNave_Seleccion);
            // 
            // pbN4
            // 
            this.pbN4.Location = new System.Drawing.Point(405, 361);
            this.pbN4.Name = "pbN4";
            this.pbN4.Size = new System.Drawing.Size(130, 130);
            this.pbN4.TabIndex = 6;
            this.pbN4.TabStop = false;
            this.pbN4.Tag = "500";
            this.pbN4.Click += new System.EventHandler(this.pbNave_Seleccion);
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
            // labN1
            // 
            this.labN1.AutoSize = true;
            this.labN1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN1.Location = new System.Drawing.Point(100, 263);
            this.labN1.Name = "labN1";
            this.labN1.Size = new System.Drawing.Size(79, 28);
            this.labN1.TabIndex = 7;
            this.labN1.Text = "Default";
            // 
            // labN2
            // 
            this.labN2.AutoSize = true;
            this.labN2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN2.Location = new System.Drawing.Point(431, 263);
            this.labN2.Name = "labN2";
            this.labN2.Size = new System.Drawing.Size(73, 28);
            this.labN2.TabIndex = 8;
            this.labN2.Text = "100 HS";
            // 
            // labN3
            // 
            this.labN3.AutoSize = true;
            this.labN3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN3.Location = new System.Drawing.Point(100, 494);
            this.labN3.Name = "labN3";
            this.labN3.Size = new System.Drawing.Size(76, 28);
            this.labN3.TabIndex = 9;
            this.labN3.Text = "300 HS";
            // 
            // labN4
            // 
            this.labN4.AutoSize = true;
            this.labN4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labN4.Location = new System.Drawing.Point(431, 494);
            this.labN4.Name = "labN4";
            this.labN4.Size = new System.Drawing.Size(76, 28);
            this.labN4.TabIndex = 10;
            this.labN4.Text = "500 HS";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(520, 574);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(93, 35);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Confirm";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // timerEstrellas
            // 
            this.timerEstrellas.Enabled = true;
            this.timerEstrellas.Interval = 1;
            this.timerEstrellas.Tick += new System.EventHandler(this.timerEstrellas_Tick_1);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 621);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.labN4);
            this.Controls.Add(this.labN3);
            this.Controls.Add(this.labN2);
            this.Controls.Add(this.labN1);
            this.Controls.Add(this.pbN4);
            this.Controls.Add(this.pbN3);
            this.Controls.Add(this.pbN2);
            this.Controls.Add(this.pbN1);
            this.Controls.Add(this.labHighScore);
            this.Controls.Add(this.labShop);
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShop;
        private System.Windows.Forms.Label labHighScore;
        private System.Windows.Forms.PictureBox pbN1;
        private System.Windows.Forms.PictureBox pbN2;
        private System.Windows.Forms.PictureBox pbN3;
        private System.Windows.Forms.PictureBox pbN4;
        private System.Windows.Forms.ImageList iLNaves;
        private System.Windows.Forms.Label labN1;
        private System.Windows.Forms.Label labN2;
        private System.Windows.Forms.Label labN3;
        private System.Windows.Forms.Label labN4;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer timerEstrellas;
    }
}