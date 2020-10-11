using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_10_CRUDFramework
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        public void limpacampos()
        {

            txtProf.Focus();
            txtId.Clear();
            txtProf.Clear();
            txtSala.Clear();
            txtCurso.Clear();
            txtData.Clear();
            AtualizaGrid();

        }

        private void btnInserirA_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    tb.ObjetoSalaAula.Add(new SalaAula { professor = txtProf.Text, sala = Convert.ToInt32(txtSala.Text), curso = txtCurso.Text, data = Convert.ToDateTime(txtData.Text) }); ;
                    tb.SaveChanges();
                    limpacampos();
                    MessageBox.Show("Incluido com sucesso!", "Inclusão");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = datagrid.CurrentRow.Cells[0].Value.ToString();
            txtProf.Text = datagrid.CurrentRow.Cells[1].Value.ToString();
            txtSala.Text = datagrid.CurrentRow.Cells[2].Value.ToString();
            txtCurso.Text = datagrid.CurrentRow.Cells[3].Value.ToString();
            txtData.Text = datagrid.CurrentRow.Cells[4].Value.ToString();

        }

        public void AtualizaGrid()
        {

            using (var tb = new Contexto())
            {

                datagrid.DataSource = null;
                datagrid.DataSource = tb.ObjetoSalaAula.ToList();

            }

        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtProf.Focus();
        }

        private void btnAlterarA_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    var objeto = tb.ObjetoSalaAula.Find(Convert.ToInt32(txtId.Text));
                    objeto.professor = txtProf.Text;
                    objeto.sala = Convert.ToInt32(txtSala.Text);
                    objeto.curso = txtCurso.Text;
                    objeto.data = Convert.ToDateTime(txtData.Text);

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração Concluida", "Alteração");
                    limpacampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnExcluirA_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    var objetoaula = tb.ObjetoSalaAula.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoSalaAula.Remove(objetoaula);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com sucesso!", "Exclusão");
                    limpacampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
