namespace MeuPrimeiroApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ligar = new System.Windows.Forms.Button();
            this.Desligar = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Evento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(68, 53);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(168, 73);
            this.Ligar.TabIndex = 0;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(262, 53);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(174, 73);
            this.Desligar.TabIndex = 1;
            this.Desligar.Text = "Desligar";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Location = new System.Drawing.Point(490, 53);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(155, 73);
            this.Detalhes.TabIndex = 2;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // Evento
            // 
            this.Evento.Location = new System.Drawing.Point(68, 235);
            this.Evento.Name = "Evento";
            this.Evento.Size = new System.Drawing.Size(168, 76);
            this.Evento.TabIndex = 3;
            this.Evento.Text = "Evento";
            this.Evento.UseVisualStyleBackColor = true;
            this.Evento.Click += new System.EventHandler(this.Evento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Evento);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.Ligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button Evento;
    }
}

