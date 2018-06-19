using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public int ID_Plano { get; set; }

    }
}
