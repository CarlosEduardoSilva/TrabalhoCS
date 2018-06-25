using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class FonteController : BaseManager<Fonte>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Fonte entidade)
        {
            throw new NotImplementedException();
        }

        public Fonte Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fonte> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Fonte entidade)
        {
            throw new NotImplementedException();
        }
    }
}
