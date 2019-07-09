using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCRUDFornecedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor add = new Fornecedor();
            add.ShowDialog();
        }

        private void SAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
