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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            userControlDashboard1.Show();
            userControlAluno1.Hide();
            userControlCurso1.Hide();
            userControlDisciplina11.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            userControlAluno1.Hide();
            userControlDashboard1.Show();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Hide();
            userControlCurso2.Hide();
            userControlDisciplina1.Hide();
            userControlAluno1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            userControlDashboard1.Hide();
            userControlDisciplina1.Hide();
            userControlAluno1.Hide();
            userControlCurso2.Show(); 
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Hide();
            userControlAluno1.Hide();
            userControlCurso2.Hide();
            userControlDisciplina1.Show();
        }
    }
}
