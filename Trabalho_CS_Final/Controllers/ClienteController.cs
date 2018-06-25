using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClienteController
    {
        private Contexto contexto = new Contexto();

        public void Salvar(Cliente entity)
        {
            entity.Ativo = true;
            contexto.Clientes.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Cliente entity)
        {
            contexto.Entry(entity).State =
            System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Excluir(int ID_Cliente)
        {
            Cliente u = Buscar(ID_Cliente);

            if (u != null)
            {
                contexto.Clientes.Remove(u);
                contexto.SaveChanges();
            }
        }

        public Cliente Buscar(int ID_Cliente)
        {
            return contexto.Clientes.Find(ID_Cliente);
        }

        public List<Cliente> BuscarTodos()
        {
            return contexto.Clientes.ToList();
        }


    }
}
