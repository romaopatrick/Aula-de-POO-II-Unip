namespace Aula01Chacara
{
    partial class Inicial
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.rbPortugues = new System.Windows.Forms.RadioButton();
            this.rbIngles = new System.Windows.Forms.RadioButton();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(46, 59);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(224, 24);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Digite uma mensagem:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(324, 112);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 26);
            this.lblResult.TabIndex = 1;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(50, 97);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(2);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(207, 20);
            this.txtMensagem.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(324, 65);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 36);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmbCores
            // 
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Amarela",
            "Azul",
            "Vermelho",
            "Verde",
            "Branco",
            "Preto"});
            this.cmbCores.Location = new System.Drawing.Point(50, 132);
            this.cmbCores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(207, 21);
            this.cmbCores.TabIndex = 4;
            // 
            // rbPortugues
            // 
            this.rbPortugues.AutoSize = true;
            this.rbPortugues.Location = new System.Drawing.Point(98, 171);
            this.rbPortugues.Margin = new System.Windows.Forms.Padding(2);
            this.rbPortugues.Name = "rbPortugues";
            this.rbPortugues.Size = new System.Drawing.Size(73, 17);
            this.rbPortugues.TabIndex = 5;
            this.rbPortugues.TabStop = true;
            this.rbPortugues.Text = "Português";
            this.rbPortugues.UseVisualStyleBackColor = true;
            // 
            // rbIngles
            // 
            this.rbIngles.AutoSize = true;
            this.rbIngles.Location = new System.Drawing.Point(200, 171);
            this.rbIngles.Margin = new System.Windows.Forms.Padding(2);
            this.rbIngles.Name = "rbIngles";
            this.rbIngles.Size = new System.Drawing.Size(53, 17);
            this.rbIngles.TabIndex = 6;
            this.rbIngles.TabStop = true;
            this.rbIngles.Text = "Inglês";
            this.rbIngles.UseVisualStyleBackColor = true;
            // 
            // mskCpf
            // 
            this.mskCpf.AccessibleDescription = "mskCpf";
            this.mskCpf.AccessibleName = "mskCpf";
            this.mskCpf.Location = new System.Drawing.Point(50, 218);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(83, 20);
            this.mskCpf.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.rbIngles);
            this.Controls.Add(this.rbPortugues);
            this.Controls.Add(this.cmbCores);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMensagem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mensagem";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmbCores;
        private System.Windows.Forms.RadioButton rbPortugues;
        private System.Windows.Forms.RadioButton rbIngles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCpf;
    }
}

