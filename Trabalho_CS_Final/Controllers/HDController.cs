using Controllers;
using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers 
{
    class HDController : BaseManager<HD>
    {
        private Contexto contexto = new Contexto();

        public void Atualizar(HD entidade)
        {
            throw new NotImplementedException();
        }

        public HD Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<HD> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(HD entidade)
        {
            throw new NotImplementedException();
        }
    }
}
