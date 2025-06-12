namespace AtividadeApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.celsiusParaFahrenheidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiEx1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiEx2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiEx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiEx4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiEx5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLucas = new System.Windows.Forms.Label();
            this.lblPedro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusParaFahrenheidToolStripMenuItem,
            this.mstiSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // celsiusParaFahrenheidToolStripMenuItem
            // 
            this.celsiusParaFahrenheidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstiEx1,
            this.mstiEx2,
            this.mstiEx3,
            this.mstiEx4,
            this.mstiEx5});
            this.celsiusParaFahrenheidToolStripMenuItem.Name = "celsiusParaFahrenheidToolStripMenuItem";
            this.celsiusParaFahrenheidToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.celsiusParaFahrenheidToolStripMenuItem.Text = "Exercícios";
            // 
            // mstiEx1
            // 
            this.mstiEx1.Name = "mstiEx1";
            this.mstiEx1.Size = new System.Drawing.Size(180, 22);
            this.mstiEx1.Text = "Exercício 1";
            this.mstiEx1.Click += new System.EventHandler(this.mstiEx1_Click);
            // 
            // mstiEx2
            // 
            this.mstiEx2.Name = "mstiEx2";
            this.mstiEx2.Size = new System.Drawing.Size(180, 22);
            this.mstiEx2.Text = "Exercício 2";
            this.mstiEx2.Click += new System.EventHandler(this.mstiEx2_Click);
            // 
            // mstiEx3
            // 
            this.mstiEx3.Name = "mstiEx3";
            this.mstiEx3.Size = new System.Drawing.Size(180, 22);
            this.mstiEx3.Text = "Exercício 3";
            this.mstiEx3.Click += new System.EventHandler(this.mstiEx3_Click);
            // 
            // mstiEx4
            // 
            this.mstiEx4.Name = "mstiEx4";
            this.mstiEx4.Size = new System.Drawing.Size(180, 22);
            this.mstiEx4.Text = "Exercício 4";
            this.mstiEx4.Click += new System.EventHandler(this.mstiEx4_Click);
            // 
            // mstiEx5
            // 
            this.mstiEx5.Name = "mstiEx5";
            this.mstiEx5.Size = new System.Drawing.Size(180, 22);
            this.mstiEx5.Text = "Exercício 5";
            this.mstiEx5.Click += new System.EventHandler(this.mstiEx5_Click);
            // 
            // mstiSair
            // 
            this.mstiSair.Name = "mstiSair";
            this.mstiSair.Size = new System.Drawing.Size(41, 20);
            this.mstiSair.Text = "Sair";
            this.mstiSair.Click += new System.EventHandler(this.mstiSair_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(269, 145);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Atividade APP";
            // 
            // lblLucas
            // 
            this.lblLucas.AutoSize = true;
            this.lblLucas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucas.Location = new System.Drawing.Point(23, 328);
            this.lblLucas.Name = "lblLucas";
            this.lblLucas.Size = new System.Drawing.Size(176, 20);
            this.lblLucas.TabIndex = 2;
            this.lblLucas.Text = "Lucas de Comi Côrte";
            // 
            // lblPedro
            // 
            this.lblPedro.AutoSize = true;
            this.lblPedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedro.Location = new System.Drawing.Point(25, 369);
            this.lblPedro.Name = "lblPedro";
            this.lblPedro.Size = new System.Drawing.Size(137, 20);
            this.lblPedro.TabIndex = 3;
            this.lblPedro.Text = "Pedro Santaella";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblPedro);
            this.Controls.Add(this.lblLucas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem celsiusParaFahrenheidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstiEx1;
        private System.Windows.Forms.ToolStripMenuItem mstiEx2;
        private System.Windows.Forms.ToolStripMenuItem mstiEx3;
        private System.Windows.Forms.ToolStripMenuItem mstiEx4;
        private System.Windows.Forms.ToolStripMenuItem mstiEx5;
        private System.Windows.Forms.ToolStripMenuItem mstiSair;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLucas;
        private System.Windows.Forms.Label lblPedro;
    }
}

