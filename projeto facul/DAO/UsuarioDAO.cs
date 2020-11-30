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
    public class UsuarioDAO : Conexao

    {
        MySqlCommand sqlCommand = null;

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                abrirConexao();
                sqlCommand = new MySqlCommand
                    (
                    " INSERT INTO                       " +
                    "   usuario (nome, senha)           " +
                    " VALUES                            " +
                    "   (@nome, @senha)                 ",
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@nome", usuario.NomeUsuario);
                sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Excluir(int id)
        {
            try
            {
                abrirConexao();
                sqlCommand = new MySqlCommand
                    (
                    " DELETE FROM               " +
                    "     esc                   " +
                    " WHERE                     " +
                    "   id = @id                ",
                    strConn
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
                fecharConexao();
            }

        }

        public void Alterar(Usuario usuario, int id)
        {
            try
            {
                abrirConexao();
                sqlCommand = new MySqlCommand
                    (
                    " UPDATE              " +
                    "   Escola            " +
                    " SET                 " +
                    " usuario = @usuario, " +
                    " senha = @senha      " +
                    " WHERE               " +
                    "   id = @id          "

                    );

                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.NomeUsuario);
                sqlCommand.Parameters.AddWithValue("Senha", usuario.Senha);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Visualizar(DataGridView dataGridView)
        {
            try
            {
                abrirConexao();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT            " +
                    "   id,             " +
                    "   usuario         " +
                    " FROM              " +
                    "   ESCOLA    "

                    );

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
                fecharConexao();

            }
        }

        public bool Logar(Usuario usuario)
        {
            bool result = false;
            try
            {
                abrirConexao();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT              " +
                    "   *                 " +
                    " from                " +
                    " usuario             " +
                    " WHERE               " +
                    "   nome = @login     " +
                    " AND                 " +
                    " senha = @senha      ",
                    strConn
                    );


                sqlCommand.Parameters.AddWithValue("@login", usuario.NomeUsuario);
                sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);

                sqlCommand.ExecuteNonQuery();

                MySqlDataReader data = sqlCommand.ExecuteReader();
                result = data.HasRows;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            return result;
        }
    }
}
