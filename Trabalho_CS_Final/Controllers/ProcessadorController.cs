using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ProcessadorController : BaseManager<Processador>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Processador entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Processador Buscar(int id)
        {
            return contexto.Processador.Find(id);
        }

        public List<Processador> BuscarTodos()
        {
            return contexto.Processador.ToList();
        }

        public void Excluir(int id)
        {
            Processador p = Buscar(id);

            if (p != null)
            {
                contexto.Processador.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(Processador entidade)
        {
            contexto.Processador.Add(entidade);
            contexto.SaveChanges();
            
        }
    }
}
