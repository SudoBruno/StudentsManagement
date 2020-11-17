using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_facul
{
    public partial class UserControlAluno : UserControl
    {
        public UserControlAluno()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FormInserirAluno formInserirAluno = new FormInserirAluno();
            formInserirAluno.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            FormCadastrarNotas formCadastrarNotas = new FormCadastrarNotas();
            formCadastrarNotas.ShowDialog();
        }
    }
}
