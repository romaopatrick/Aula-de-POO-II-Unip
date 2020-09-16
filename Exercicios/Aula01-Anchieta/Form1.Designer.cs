namespace Aula01
{
    partial class PrimeiraTela
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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblRecebe = new System.Windows.Forms.Label();
            this.txtEntrada2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(57, 9);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(280, 29);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Digite uma mensagem:";
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(62, 57);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(259, 22);
            this.txtEntrada.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(62, 128);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(259, 36);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblRecebe
            // 
            this.lblRecebe.AutoSize = true;
            this.lblRecebe.Location = new System.Drawing.Point(371, 57);
            this.lblRecebe.Name = "lblRecebe";
            this.lblRecebe.Size = new System.Drawing.Size(0, 17);
            this.lblRecebe.TabIndex = 3;
            // 
            // txtEntrada2
            // 
            this.txtEntrada2.Location = new System.Drawing.Point(62, 86);
            this.txtEntrada2.Name = "txtEntrada2";
            this.txtEntrada2.Size = new System.Drawing.Size(259, 22);
            this.txtEntrada2.TabIndex = 4;
            // 
            // PrimeiraTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 193);
            this.Controls.Add(this.txtEntrada2);
            this.Controls.Add(this.lblRecebe);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Name = "PrimeiraTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblRecebe;
        private System.Windows.Forms.TextBox txtEntrada2;
    }
}

