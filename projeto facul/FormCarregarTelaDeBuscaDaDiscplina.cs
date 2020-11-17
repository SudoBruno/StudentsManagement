using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_facul.BLL;

namespace projeto_facul
{
    public partial class FormCarregarTelaDeBuscaDaDiscplina : Form
    {
        public FormCarregarTelaDeBuscaDaDiscplina()
        {
            InitializeComponent();
        }
        public void preencerDataGridView(DataGridView dataGridView, string palavraPesquisada)
        {
            NotaBLL notaBLL = new NotaBLL();
            notaBLL.Visualizar(dataGridView, palavraPesquisada);
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbPalavraPesquisada_KeyDown(object sender, KeyEventArgs e)
        {
            preencerDataGridView(dataGridViewPesquisarDisciplina, tbPalavraPesquisada.Text);
        }
    }
}
