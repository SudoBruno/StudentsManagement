using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_facul
{
    public partial class FormCadastrarNotas : Form
    {
        public FormCadastrarNotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja Efetuar o Cadastro?", "Efetuar Cadastro", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Nota inserida com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
            
            
        }

        private void pesquisarIdDoCurso_Click(object sender, EventArgs e)
        {
            FormCarregarTelaDeBuscaDaDiscplina formCarregarTelaDeBuscaDaDiscplina = new FormCarregarTelaDeBuscaDaDiscplina();
            formCarregarTelaDeBuscaDaDiscplina.ShowDialog();
        }

        private void FormCadastrarNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
