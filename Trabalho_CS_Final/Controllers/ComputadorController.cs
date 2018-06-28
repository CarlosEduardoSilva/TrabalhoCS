using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ComputadorController : BaseManager<Computador>
    {

        private Contexto contexto = new Contexto();

        public void Atualizar(Computador entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Computador Buscar(int id)
        {
            return contexto.Computador.Find(id);
        }

        public List<Computador> BuscarTodos()
        {
            //return contexto.Computador.Include("Processador").Include("Memoria").ToList();
            return contexto.Computador.ToList();
        }

        public void Excluir(int id)
        {
            Computador p = Buscar(id);

            if (p != null)
            {
                contexto.Computador.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(Computador entidade)
        {
            contexto.Computador.Add(entidade);
            contexto.SaveChanges();
        }

        
    }
}
