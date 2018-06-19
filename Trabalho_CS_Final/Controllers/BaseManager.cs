using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    interface BaseManager<T> where T : class
    {
        void Salvar(T entidade);
        void Atualizar(T entidade);
        void Excluir(int id);
        T Buscar(int id);
        List<T> BuscarTodos();
    }
}
