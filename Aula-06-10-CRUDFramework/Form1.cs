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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadTelefoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadTelefoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadAgendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AtualizaGrid();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    tb.ObjetoAgenda.Add(new Agenda { nome = txtNome.Text, telefone = txtTelefone.Text, CEP = txtCEP.Text, Salario = Convert.ToDouble(txtSalario.Text) });
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

        public void limpacampos()
        {

            txtNome.Focus();
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtSalario.Clear();
            AtualizaGrid();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtId.Text));
                    objeto.nome = txtNome.Text;
                    objeto.telefone = txtTelefone.Text;
                    objeto.CEP = txtCEP.Text;
                    objeto.Salario = Convert.ToDouble(txtSalario.Text);

                    tb.Entry(objeto).State = EntityState.Modified;                          //entitystate.modified update na tabela
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

        public void AtualizaGrid()
        {

            using (var tb = new Contexto())
            {

                grid.DataSource = null;
                grid.DataSource = tb.ObjetoAgenda.ToList();             //ToList pega os dados e coloca em lista

            }

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtCEP.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtSalario.Text = grid.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoAgenda.Remove(objeto);
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
