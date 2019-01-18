namespace Marcianos
{
    partial class frmLeader
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
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.labLeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.timerEstrellas = new System.Windows.Forms.Timer(this.components);
            this.labNoData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScores
            // 
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Location = new System.Drawing.Point(12, 66);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.Size = new System.Drawing.Size(583, 241);
            this.dgvScores.TabIndex = 0;
            // 
            // labLeader
            // 
            this.labLeader.AutoSize = true;
            this.labLeader.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLeader.ForeColor = System.Drawing.Color.White;
            this.labLeader.Location = new System.Drawing.Point(197, 9);
            this.labLeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLeader.Name = "labLeader";
            this.labLeader.Size = new System.Drawing.Size(203, 44);
            this.labLeader.TabIndex = 1;
            this.labLeader.Text = "Leaderboard";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 315);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 27);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnSeleccion_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(527, 315);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSeleccion_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btn_Enter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btn_Leave);
            // 
            // timerEstrellas
            // 
            this.timerEstrellas.Enabled = true;
            this.timerEstrellas.Interval = 1;
            this.timerEstrellas.Tick += new System.EventHandler(this.timerEstrellas_Tick);
            // 
            // labNoData
            // 
            this.labNoData.AutoSize = true;
            this.labNoData.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoData.ForeColor = System.Drawing.Color.White;
            this.labNoData.Location = new System.Drawing.Point(519, 44);
            this.labNoData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNoData.Name = "labNoData";
            this.labNoData.Size = new System.Drawing.Size(76, 19);
            this.labNoData.TabIndex = 12;
            this.labNoData.Text = "(no scores)";
            this.labNoData.Visible = false;
            // 
            // frmLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(607, 352);
            this.Controls.Add(this.labNoData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labLeader);
            this.Controls.Add(this.dgvScores);
            this.Name = "frmLeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLeader";
            this.Load += new System.EventHandler(this.frmLeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Label labLeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timerEstrellas;
        private System.Windows.Forms.Label labNoData;
    }
}