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
    public class ProfessorDAO
    {
        MySqlCommand sqlCommand = null;

        public void Cadastrar(Professor usuario)
        {
            try
            {

                sqlCommand = new MySqlCommand
                    (
                    " INSERT INTO                       " +
                    "   Escola (Usuario, Senha)   " +
                    " VALUES                            " +
                    "   (@Usuario, @Senha)              "

                    );

                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.Nome);
                sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {

            }
        }

        public void Excluir(int id)
        {
            try
            {

                sqlCommand = new MySqlCommand
                    (
                    " DELETE FROM               " +
                    "   Escola            " +
                    " WHERE                     " +
                    "   id = @id           "


                    );

                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {

            }

        }
        public void Alterar(Professor usuario, int id)
        {
            try
            {

                sqlCommand = new MySqlCommand
                    (
                    " UPDATE                    " +
                    "   Escola            " +
                    " SET                       " +
                    " usuario = @usuario,             " +
                    " senha = @senha      " +
                    " WHERE                     " +
                    "   id = @id           "

                    );

                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                sqlCommand.Parameters.AddWithValue("Senha", usuario.Senha);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {

            }
        }
        public void Visualizar(DataGridView dataGridView)
        {
            try
            {
                
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT            " +
                    "   id,        " +
                    "   usuario            " +
                    " FROM              " +
                    "   ESCOLA    "
                    
                    );

                dataAdapter.SelectCommand = sqlCommand;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = dataSet.Tables[0].TableName;
            }
            catch(Exception erro)
            {
                throw erro; 
            }
            finally
            {

            }
        }

    }
}
