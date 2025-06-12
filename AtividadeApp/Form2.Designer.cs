namespace AtividadeApp
{
    partial class frmEx2
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
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtVel = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblVel = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lblLU = new System.Windows.Forms.Label();
            this.txtLU = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(373, 45);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(317, 29);
            this.txtTempo.TabIndex = 0;
            // 
            // txtVel
            // 
            this.txtVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVel.Location = new System.Drawing.Point(373, 116);
            this.txtVel.Name = "txtVel";
            this.txtVel.Size = new System.Drawing.Size(317, 29);
            this.txtVel.TabIndex = 1;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(99, 45);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(204, 24);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo gasto (horas)";
            // 
            // lblVel
            // 
            this.lblVel.AutoSize = true;
            this.lblVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel.Location = new System.Drawing.Point(99, 116);
            this.lblVel.Name = "lblVel";
            this.lblVel.Size = new System.Drawing.Size(244, 24);
            this.lblVel.TabIndex = 3;
            this.lblVel.Text = "Velocidade média (km/h)";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.Location = new System.Drawing.Point(99, 188);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(243, 24);
            this.lblDist.TabIndex = 5;
            this.lblDist.Text = "Distância percorrida (km)";
            // 
            // txtDist
            // 
            this.txtDist.Enabled = false;
            this.txtDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDist.Location = new System.Drawing.Point(373, 188);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(317, 29);
            this.txtDist.TabIndex = 4;
            // 
            // lblLU
            // 
            this.lblLU.AutoSize = true;
            this.lblLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLU.Location = new System.Drawing.Point(99, 261);
            this.lblLU.Name = "lblLU";
            this.lblLU.Size = new System.Drawing.Size(133, 24);
            this.lblLU.TabIndex = 7;
            this.lblLU.Text = "Litros usados";
            // 
            // txtLU
            // 
            this.txtLU.Enabled = false;
            this.txtLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLU.Location = new System.Drawing.Point(373, 261);
            this.txtLU.Name = "txtLU";
            this.txtLU.Size = new System.Drawing.Size(317, 29);
            this.txtLU.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(116, 369);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(143, 34);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(325, 369);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 34);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(528, 369);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 34);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblLU);
            this.Controls.Add(this.txtLU);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.lblVel);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtVel);
            this.Controls.Add(this.txtTempo);
            this.Name = "frmEx2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtVel;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblVel;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label lblLU;
        private System.Windows.Forms.TextBox txtLU;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}