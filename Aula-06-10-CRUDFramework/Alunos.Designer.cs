namespace Aula_06_10_CRUDFramework
{
    partial class Alunos
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.btnInserirA = new System.Windows.Forms.Button();
            this.btnAlterarA = new System.Windows.Forms.Button();
            this.btnExcluirA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(24, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(83, 52);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(313, 20);
            this.txtProf.TabIndex = 3;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(6, 55);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(51, 13);
            this.lblProf.TabIndex = 2;
            this.lblProf.Text = "Professor";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(83, 89);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(72, 20);
            this.txtSala.TabIndex = 5;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(29, 92);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 13);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Sala";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(83, 124);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(237, 20);
            this.txtCurso.TabIndex = 7;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(23, 127);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Curso";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(22, 165);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(83, 162);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(72, 20);
            this.txtData.TabIndex = 9;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 227);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(524, 200);
            this.datagrid.TabIndex = 10;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            // 
            // btnInserirA
            // 
            this.btnInserirA.Location = new System.Drawing.Point(12, 193);
            this.btnInserirA.Name = "btnInserirA";
            this.btnInserirA.Size = new System.Drawing.Size(75, 23);
            this.btnInserirA.TabIndex = 11;
            this.btnInserirA.Text = "Inserir";
            this.btnInserirA.UseVisualStyleBackColor = true;
            this.btnInserirA.Click += new System.EventHandler(this.btnInserirA_Click);
            // 
            // btnAlterarA
            // 
            this.btnAlterarA.Location = new System.Drawing.Point(95, 193);
            this.btnAlterarA.Name = "btnAlterarA";
            this.btnAlterarA.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarA.TabIndex = 12;
            this.btnAlterarA.Text = "Alterar";
            this.btnAlterarA.UseVisualStyleBackColor = true;
            this.btnAlterarA.Click += new System.EventHandler(this.btnAlterarA_Click);
            // 
            // btnExcluirA
            // 
            this.btnExcluirA.Location = new System.Drawing.Point(176, 193);
            this.btnExcluirA.Name = "btnExcluirA";
            this.btnExcluirA.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirA.TabIndex = 13;
            this.btnExcluirA.Text = "Excluir";
            this.btnExcluirA.UseVisualStyleBackColor = true;
            this.btnExcluirA.Click += new System.EventHandler(this.btnExcluirA_Click);
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 439);
            this.Controls.Add(this.btnExcluirA);
            this.Controls.Add(this.btnAlterarA);
            this.Controls.Add(this.btnInserirA);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button btnInserirA;
        private System.Windows.Forms.Button btnAlterarA;
        private System.Windows.Forms.Button btnExcluirA;
    }
}