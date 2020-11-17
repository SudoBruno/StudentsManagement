using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_facul.MODELS;
using projeto_facul.BLL;

namespace projeto_facul
{
    public partial class FormCadastroProf : Form
    {
        public FormCadastroProf()
        {
            InitializeComponent();
        }
      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario.NomeUsuario = tbUsuario.Text;
                usuario.Senha = tbSenha.Text;

                if (tbSenha.Text == tbConfirmarSenha.Text)
                {
                    
                    DialogResult dialogResult = MessageBox.Show("Deseja Efetuar o Cadastro?", "Efetuar Cadastro", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        cadastrarUsuario(usuario);

                        MessageBox.Show("Usuario cadastrado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }

                }
                else
                {
                    MessageBox.Show("Senha Não Conferem");
                }
                

            }
            catch(Exception erro )
            {
                throw erro;
            }
        }

        public void cadastrarUsuario(Usuario usuario)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();                     

            usuario.NomeUsuario = tbUsuario.Text;
            usuario.Senha = tbSenha.Text;

            usuarioBLL.Cadastrar(usuario);

        }               
    }
}
