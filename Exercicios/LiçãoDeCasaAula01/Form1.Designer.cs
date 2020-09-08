namespace LiçãoDeCasaAula01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectId = new System.Windows.Forms.TextBox();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.txtSelectNome = new System.Windows.Forms.TextBox();
            this.txtInsertNome = new System.Windows.Forms.TextBox();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.txtUpdateNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUpdateNome);
            this.groupBox1.Controls.Add(this.txtUpdateId);
            this.groupBox1.Controls.Add(this.txtInsertNome);
            this.groupBox1.Controls.Add(this.txtSelectNome);
            this.groupBox1.Controls.Add(this.txtDeleteId);
            this.groupBox1.Controls.Add(this.txtSelectId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Location = new System.Drawing.Point(38, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar uma Tabela Inteira";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(450, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(488, 249);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(488, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(488, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME";
            // 
            // txtSelectId
            // 
            this.txtSelectId.Location = new System.Drawing.Point(38, 251);
            this.txtSelectId.Name = "txtSelectId";
            this.txtSelectId.Size = new System.Drawing.Size(100, 20);
            this.txtSelectId.TabIndex = 7;
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(38, 311);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteId.TabIndex = 8;
            // 
            // txtSelectNome
            // 
            this.txtSelectNome.Location = new System.Drawing.Point(186, 251);
            this.txtSelectNome.Name = "txtSelectNome";
            this.txtSelectNome.Size = new System.Drawing.Size(195, 20);
            this.txtSelectNome.TabIndex = 9;
            // 
            // txtInsertNome
            // 
            this.txtInsertNome.Location = new System.Drawing.Point(186, 281);
            this.txtInsertNome.Name = "txtInsertNome";
            this.txtInsertNome.Size = new System.Drawing.Size(195, 20);
            this.txtInsertNome.TabIndex = 10;
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(38, 341);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateId.TabIndex = 11;
            // 
            // txtUpdateNome
            // 
            this.txtUpdateNome.Location = new System.Drawing.Point(186, 341);
            this.txtUpdateNome.Name = "txtUpdateNome";
            this.txtUpdateNome.Size = new System.Drawing.Size(195, 20);
            this.txtUpdateNome.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "STATUS";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Cyan;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(142, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(421, 19);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateNome;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.TextBox txtInsertNome;
        private System.Windows.Forms.TextBox txtSelectNome;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.TextBox txtSelectId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
    }
}

