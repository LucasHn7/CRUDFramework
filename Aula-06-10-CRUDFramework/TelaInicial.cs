using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_10_CRUDFramework
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void msSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msCadAgenda_Click(object sender, EventArgs e)
        {
            Form1 cadagenda = new Form1();
            cadagenda.Show();
        }

        private void msCadAulas_Click(object sender, EventArgs e)
        {
            Alunos cadalunos = new Alunos();
            cadalunos.Show();
        }
    }
}
