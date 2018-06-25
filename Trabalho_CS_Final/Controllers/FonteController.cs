using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class FonteController : BaseManager<Fonte>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Fonte entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Fonte Buscar(int id)
        {
            return contexto.Fonte.Find(id);
        }

        public List<Fonte> BuscarTodos()
        {
            return contexto.Fonte.ToList();
        }

        public void Excluir(int id)
        {
            Fonte p = Buscar(id);

            if (p != null)
            {
                contexto.Fonte.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(Fonte entidade)
        {
            contexto.Fonte.Add(entidade);
            contexto.SaveChanges();
        }
    }
}
