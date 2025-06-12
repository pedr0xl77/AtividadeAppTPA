namespace AtividadeApp
{
    partial class frmEx3
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
            this.lblReal = new System.Windows.Forms.Label();
            this.lblPrecoDolar = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtPrecoDolar = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(81, 55);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(152, 24);
            this.lblReal.TabIndex = 0;
            this.lblReal.Text = "Valor em Reais";
            // 
            // lblPrecoDolar
            // 
            this.lblPrecoDolar.AutoSize = true;
            this.lblPrecoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoDolar.Location = new System.Drawing.Point(81, 158);
            this.lblPrecoDolar.Name = "lblPrecoDolar";
            this.lblPrecoDolar.Size = new System.Drawing.Size(171, 24);
            this.lblPrecoDolar.TabIndex = 1;
            this.lblPrecoDolar.Text = "Cotação do Dólar";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD.Location = new System.Drawing.Point(81, 263);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(177, 24);
            this.lblUSD.TabIndex = 2;
            this.lblUSD.Text = "Preço em Dólares";
            // 
            // txtReal
            // 
            this.txtReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal.Location = new System.Drawing.Point(308, 55);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(346, 29);
            this.txtReal.TabIndex = 3;
            // 
            // txtPrecoDolar
            // 
            this.txtPrecoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoDolar.Location = new System.Drawing.Point(308, 158);
            this.txtPrecoDolar.Name = "txtPrecoDolar";
            this.txtPrecoDolar.Size = new System.Drawing.Size(346, 29);
            this.txtPrecoDolar.TabIndex = 4;
            // 
            // txtUSD
            // 
            this.txtUSD.Enabled = false;
            this.txtUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSD.Location = new System.Drawing.Point(308, 263);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(346, 29);
            this.txtUSD.TabIndex = 5;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(100, 381);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(114, 40);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(332, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(554, 381);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 40);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtPrecoDolar);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.lblPrecoDolar);
            this.Controls.Add(this.lblReal);
            this.Name = "frmEx3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblPrecoDolar;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtPrecoDolar;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}