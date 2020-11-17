using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_facul.MODELS;
using projeto_facul.DAO;
using System.Windows.Forms;

namespace projeto_facul.BLL
{
    public class NotaBLL
    {
        NotaDAO notaDAO = new NotaDAO();
        public void Visualizar(DataGridView dataGridView, string palavraBuscada)
        {
            notaDAO.Visualizar(dataGridView, palavraBuscada);
        }
    }
}
