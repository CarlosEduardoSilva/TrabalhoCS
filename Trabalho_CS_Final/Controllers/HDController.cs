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
    public class HDController : BaseManager<HD>
    {
        private Contexto contexto = new Contexto();

        public void Atualizar(HD entidade)
        {
            contexto.Entry(entidade).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public HD Buscar(int id)
        {
            return contexto.HD.Find(id);
        }

        public List<HD> BuscarTodos()
        {
            return contexto.HD.ToList();
        }

        public void Excluir(int id)
        {
            HD p = Buscar(id);

            if (p != null)
            {
                contexto.HD.Remove(p);
                contexto.SaveChanges();
            }
        }

        public void Salvar(HD entidade)
        {
            contexto.HD.Add(entidade);
            contexto.SaveChanges();
        }
    }
}
