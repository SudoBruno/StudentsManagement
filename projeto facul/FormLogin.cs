using projeto_facul.BLL;
using projeto_facul.DAO;
using projeto_facul.MODELS;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NomeUsuario = tbUsuarioLogin.Text;
            usuario.Senha = tbSenhaLogin.Text;


            if (!logar(usuario))
            {                                  
                MessageBox.Show("Usuario não encontrado !");
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }            
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool logar(Usuario usuario)
        {
            
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            usuario.NomeUsuario = tbUsuarioLogin.Text;
            usuario.Senha = tbSenhaLogin.Text;

            return usuarioBLL.Logar(usuario);

            

        }
    }
}
