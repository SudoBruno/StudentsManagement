using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_facul.MODELS;
using System.Windows.Forms;
using System.Data;

namespace projeto_facul.DAO
{
    public class NotaDAO : Conexao
    {
        MySqlCommand sqlCommand = null;

        public void Visualizar(DataGridView dataGridView, string palavraBuscada)
        {
            try
            {
                abrirConexao();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT                    " +
                    "   nome_disciplina         " +
                    " FROM                      " +
                    "   disciplina              " +
                    " WHERE                     " +
                    "   nome_disciplina         " +
                    "LIKE                       " +
                    " @palavraBuscada       ",
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@palavraBuscada", '%'+palavraBuscada+'%');

                dataAdapter.SelectCommand = sqlCommand;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = dataSet.Tables[0].TableName;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {

            }
        }

    }
}
