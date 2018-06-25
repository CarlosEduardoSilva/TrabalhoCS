using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class MemoriaController : BaseManager<Memoria>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Memoria entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Memoria Buscar(int id)
        {
            return contexto.Memoria.Find(id);
        }

        public List<Memoria> BuscarTodos()
        {
            return contexto.Memoria.ToList();
        }

        public void Excluir(int id)
        {
            Memoria p = Buscar(id);

            if (p != null)
            {
                contexto.Memoria.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(Memoria entidade)
        {
            contexto.Memoria.Add(entidade);
            contexto.SaveChanges();
        }
    }
}
