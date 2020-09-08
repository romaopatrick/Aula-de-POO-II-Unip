namespace Aula01Chacara
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttConultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSelect = new System.Windows.Forms.TextBox();
            this.txtNomeSelect = new System.Windows.Forms.TextBox();
            this.bttSelect = new System.Windows.Forms.Button();
            this.bttInsert = new System.Windows.Forms.Button();
            this.txtNomeInsert = new System.Windows.Forms.TextBox();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.txtNomeUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeUpdate);
            this.groupBox1.Controls.Add(this.txtIdUpdate);
            this.groupBox1.Controls.Add(this.bttUpdate);
            this.groupBox1.Controls.Add(this.bttDelete);
            this.groupBox1.Controls.Add(this.txtIdDelete);
            this.groupBox1.Controls.Add(this.txtNomeInsert);
            this.groupBox1.Controls.Add(this.bttInsert);
            this.groupBox1.Controls.Add(this.bttSelect);
            this.groupBox1.Controls.Add(this.txtNomeSelect);
            this.groupBox1.Controls.Add(this.txtIdSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.bttConultar);
            this.groupBox2.Location = new System.Drawing.Point(61, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar uma Tabela Inteira";
            // 
            // bttConultar
            // 
            this.bttConultar.Location = new System.Drawing.Point(538, 22);
            this.bttConultar.Name = "bttConultar";
            this.bttConultar.Size = new System.Drawing.Size(85, 23);
            this.bttConultar.TabIndex = 0;
            this.bttConultar.Text = "Consultar";
            this.bttConultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtIdSelect
            // 
            this.txtIdSelect.Location = new System.Drawing.Point(94, 333);
            this.txtIdSelect.Name = "txtIdSelect";
            this.txtIdSelect.Size = new System.Drawing.Size(144, 23);
            this.txtIdSelect.TabIndex = 3;
            this.txtIdSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeSelect
            // 
            this.txtNomeSelect.Location = new System.Drawing.Point(281, 332);
            this.txtNomeSelect.Name = "txtNomeSelect";
            this.txtNomeSelect.Size = new System.Drawing.Size(271, 23);
            this.txtNomeSelect.TabIndex = 4;
            this.txtNomeSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttSelect
            // 
            this.bttSelect.Location = new System.Drawing.Point(599, 332);
            this.bttSelect.Name = "bttSelect";
            this.bttSelect.Size = new System.Drawing.Size(85, 23);
            this.bttSelect.TabIndex = 5;
            this.bttSelect.Text = "Select";
            this.bttSelect.UseVisualStyleBackColor = true;
            // 
            // bttInsert
            // 
            this.bttInsert.Location = new System.Drawing.Point(599, 382);
            this.bttInsert.Name = "bttInsert";
            this.bttInsert.Size = new System.Drawing.Size(85, 23);
            this.bttInsert.TabIndex = 6;
            this.bttInsert.Text = "Insert";
            this.bttInsert.UseVisualStyleBackColor = true;
            // 
            // txtNomeInsert
            // 
            this.txtNomeInsert.Location = new System.Drawing.Point(281, 382);
            this.txtNomeInsert.Name = "txtNomeInsert";
            this.txtNomeInsert.Size = new System.Drawing.Size(271, 23);
            this.txtNomeInsert.TabIndex = 7;
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(94, 431);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(144, 23);
            this.txtIdDelete.TabIndex = 8;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(599, 431);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(85, 23);
            this.bttDelete.TabIndex = 9;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(599, 482);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(85, 23);
            this.bttUpdate.TabIndex = 10;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(94, 482);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(144, 23);
            this.txtIdUpdate.TabIndex = 11;
            // 
            // txtNomeUpdate
            // 
            this.txtNomeUpdate.Location = new System.Drawing.Point(281, 482);
            this.txtNomeUpdate.Name = "txtNomeUpdate";
            this.txtNomeUpdate.Size = new System.Drawing.Size(271, 23);
            this.txtNomeUpdate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblShowStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowStatus.Location = new System.Drawing.Point(281, 528);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(403, 17);
            this.lblShowStatus.TabIndex = 14;
            this.lblShowStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 585);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShowStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.TextBox txtNomeInsert;
        private System.Windows.Forms.Button bttInsert;
        private System.Windows.Forms.Button bttSelect;
        private System.Windows.Forms.TextBox txtNomeSelect;
        private System.Windows.Forms.TextBox txtIdSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttConultar;
    }
}