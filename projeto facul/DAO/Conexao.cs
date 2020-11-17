using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_facul
{
    public class Conexao
    {
        //TODO CONFIGURAR A LINHA DE CONEXAO 
        public string stringConnection = "Persist Security Info=False;server=localhost;database=escola;uid=root;password=''";
        protected MySqlConnection strConn = null;

        public void abrirConexao()
        {
            try
            {
                strConn = new MySqlConnection(stringConnection);
                strConn.Open();

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void fecharConexao()
        {
            try
            {
                strConn = new MySqlConnection(stringConnection);
                strConn.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
