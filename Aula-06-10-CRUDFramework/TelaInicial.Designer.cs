namespace Aula_06_10_CRUDFramework
{
    partial class TelaInicial
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
            this.msSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSistema,
            this.msSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSistema
            // 
            this.msSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadAgenda,
            this.msCadAulas});
            this.msSistema.Name = "msSistema";
            this.msSistema.Size = new System.Drawing.Size(60, 20);
            this.msSistema.Text = "Sistema";
            // 
            // msCadAgenda
            // 
            this.msCadAgenda.Name = "msCadAgenda";
            this.msCadAgenda.Size = new System.Drawing.Size(180, 22);
            this.msCadAgenda.Text = "Cadastro Agenda";
            this.msCadAgenda.Click += new System.EventHandler(this.msCadAgenda_Click);
            // 
            // msCadAulas
            // 
            this.msCadAulas.Name = "msCadAulas";
            this.msCadAulas.Size = new System.Drawing.Size(180, 22);
            this.msCadAulas.Text = "Cadastro Aulas";
            this.msCadAulas.Click += new System.EventHandler(this.msCadAulas_Click);
            // 
            // msSair
            // 
            this.msSair.Name = "msSair";
            this.msSair.Size = new System.Drawing.Size(38, 20);
            this.msSair.Text = "Sair";
            this.msSair.Click += new System.EventHandler(this.msSair_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSistema;
        private System.Windows.Forms.ToolStripMenuItem msCadAgenda;
        private System.Windows.Forms.ToolStripMenuItem msCadAulas;
        private System.Windows.Forms.ToolStripMenuItem msSair;
    }
}