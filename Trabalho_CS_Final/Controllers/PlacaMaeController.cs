using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PlacaMaeController : BaseManager<PlacaMae>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(PlacaMae entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public PlacaMae Buscar(int id)
        {
            return contexto.PlacaMae.Find(id);
        }

        public List<PlacaMae> BuscarTodos()
        {
            return contexto.PlacaMae.ToList();
        }

        public void Excluir(int id)
        {
            PlacaMae p = Buscar(id);

            if (p != null)
            {
                contexto.PlacaMae.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(PlacaMae entidade)
        {
            contexto.PlacaMae.Add(entidade);
            contexto.SaveChanges();
        }
    }
}
