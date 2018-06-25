using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class PlacaMaeController : BaseManager<PlacaMae>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(PlacaMae entidade)
        {
            throw new NotImplementedException();
        }

        public PlacaMae Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlacaMae> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(PlacaMae entidade)
        {
            throw new NotImplementedException();
        }
    }
}
