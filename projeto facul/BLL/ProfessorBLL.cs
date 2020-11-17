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
    public class ProfessorBLL
    {
        ProfessorDAO ProfessorDAO = new ProfessorDAO();

        // Cadastrar usuario.
        
        public void Cadastrar(Professor usuario)
        {
            try
            {
                ProfessorDAO.Cadastrar(usuario);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // Alteração de Usuarios.

        public void Alterar(Professor usuario, int id)
        {
            try
            {
                ProfessorDAO.Alterar(usuario, id);
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
                ProfessorDAO.Excluir(id);
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
                ProfessorDAO.Visualizar(dataGridView);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }


}
