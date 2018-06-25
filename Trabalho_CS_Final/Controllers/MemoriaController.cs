using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class MemoriaController : BaseManager<Memoria>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Memoria entidade)
        {
            throw new NotImplementedException();
        }

        public Memoria Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Memoria> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Memoria entidade)
        {
            throw new NotImplementedException();
        }
    }
}
