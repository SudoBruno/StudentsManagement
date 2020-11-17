using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_facul.DAO;
using projeto_facul.MODELS;

namespace projeto_facul.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAO UsuarioDAO = new UsuarioDAO();

        // Cadastrar usuario.
        
        public void Cadastrar(Usuario usuario)
        {
            try
            {
                UsuarioDAO.Cadastrar(usuario);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // Alteração de Usuarios.

        public void Alterar(Usuario usuario, int id)
        {
            try
            {
                UsuarioDAO.Alterar(usuario, id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Exclusão de Usuarios

        public void Excluir( int id)
        {
            try
            {
                UsuarioDAO.Excluir(id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        // Visualição do Usuario

        public void Visualizar(DataGridView dataGridView)
        {
            try
            {
                UsuarioDAO.Visualizar(dataGridView);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }


}
