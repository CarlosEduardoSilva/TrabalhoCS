using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ProcessadorController : BaseManager<Processador>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Processador entidade)
        {
            throw new NotImplementedException();
        }

        public Processador Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Processador> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Processador entidade)
        {
            contexto.Processador.Add(entidade);
            contexto.SaveChanges();
            
        }
    }
}
