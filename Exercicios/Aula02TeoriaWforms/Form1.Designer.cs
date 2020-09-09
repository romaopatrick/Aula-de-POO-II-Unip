namespace Aula02TeoriaWforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btmClickHere = new System.Windows.Forms.Button();
            this.lblHW = new System.Windows.Forms.Label();
            this.lblCursoCampus = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmClickHere
            // 
            resources.ApplyResources(this.btmClickHere, "btmClickHere");
            this.btmClickHere.Name = "btmClickHere";
            this.btmClickHere.UseVisualStyleBackColor = true;
            this.btmClickHere.Click += new System.EventHandler(this.btmClickHere_Click);
            // 
            // lblHW
            // 
            resources.ApplyResources(this.lblHW, "lblHW");
            this.lblHW.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHW.Name = "lblHW";
            this.lblHW.UseCompatibleTextRendering = true;
            // 
            // lblCursoCampus
            // 
            resources.ApplyResources(this.lblCursoCampus, "lblCursoCampus");
            this.lblCursoCampus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCursoCampus.Name = "lblCursoCampus";
            this.lblCursoCampus.UseCompatibleTextRendering = true;
            // 
            // lblSemestre
            // 
            resources.ApplyResources(this.lblSemestre, "lblSemestre");
            this.lblSemestre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSemestre.Name = "lblSemestre";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblCursoCampus);
            this.Controls.Add(this.lblHW);
            this.Controls.Add(this.btmClickHere);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmClickHere;
        private System.Windows.Forms.Label lblHW;
        private System.Windows.Forms.Label lblCursoCampus;
        private System.Windows.Forms.Label lblSemestre;
    }
}

