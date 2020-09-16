namespace Aula01
{
    partial class Cadastro
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtNome03 = new System.Windows.Forms.TextBox();
            this.txtNome02 = new System.Windows.Forms.TextBox();
            this.txtNome01 = new System.Windows.Forms.TextBox();
            this.txtID03 = new System.Windows.Forms.TextBox();
            this.txtID02 = new System.Windows.Forms.TextBox();
            this.txtID01 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnConsultar);
            this.gb1.Controls.Add(this.dgvDados);
            this.gb1.Location = new System.Drawing.Point(55, 50);
            this.gb1.Margin = new System.Windows.Forms.Padding(2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(2);
            this.gb1.Size = new System.Drawing.Size(477, 166);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Consultando dados tabela";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(347, 49);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 25);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(20, 30);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(265, 122);
            this.dgvDados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.txtNome03);
            this.groupBox1.Controls.Add(this.txtNome02);
            this.groupBox1.Controls.Add(this.txtNome01);
            this.groupBox1.Controls.Add(this.txtID03);
            this.groupBox1.Controls.Add(this.txtID02);
            this.groupBox1.Controls.Add(this.txtID01);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(52, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(479, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(95, 183);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(358, 37);
            this.lblStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(372, 132);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(81, 20);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(372, 100);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 26);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(372, 68);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 27);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(372, 34);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(81, 29);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtNome03
            // 
            this.txtNome03.Location = new System.Drawing.Point(165, 108);
            this.txtNome03.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome03.Name = "txtNome03";
            this.txtNome03.Size = new System.Drawing.Size(168, 20);
            this.txtNome03.TabIndex = 7;
            // 
            // txtNome02
            // 
            this.txtNome02.Location = new System.Drawing.Point(165, 78);
            this.txtNome02.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome02.Name = "txtNome02";
            this.txtNome02.Size = new System.Drawing.Size(168, 20);
            this.txtNome02.TabIndex = 6;
            // 
            // txtNome01
            // 
            this.txtNome01.Location = new System.Drawing.Point(165, 48);
            this.txtNome01.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome01.Name = "txtNome01";
            this.txtNome01.Size = new System.Drawing.Size(168, 20);
            this.txtNome01.TabIndex = 5;
            // 
            // txtID03
            // 
            this.txtID03.Location = new System.Drawing.Point(36, 109);
            this.txtID03.Margin = new System.Windows.Forms.Padding(2);
            this.txtID03.Name = "txtID03";
            this.txtID03.Size = new System.Drawing.Size(76, 20);
            this.txtID03.TabIndex = 4;
            // 
            // txtID02
            // 
            this.txtID02.Location = new System.Drawing.Point(36, 79);
            this.txtID02.Margin = new System.Windows.Forms.Padding(2);
            this.txtID02.Name = "txtID02";
            this.txtID02.Size = new System.Drawing.Size(76, 20);
            this.txtID02.TabIndex = 3;
            // 
            // txtID01
            // 
            this.txtID01.Location = new System.Drawing.Point(36, 48);
            this.txtID01.Margin = new System.Windows.Forms.Padding(2);
            this.txtID01.Name = "txtID01";
            this.txtID01.Size = new System.Drawing.Size(76, 20);
            this.txtID01.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(163, 18);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 18);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome03;
        private System.Windows.Forms.TextBox txtNome02;
        private System.Windows.Forms.TextBox txtNome01;
        private System.Windows.Forms.TextBox txtID03;
        private System.Windows.Forms.TextBox txtID02;
        private System.Windows.Forms.TextBox txtID01;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}