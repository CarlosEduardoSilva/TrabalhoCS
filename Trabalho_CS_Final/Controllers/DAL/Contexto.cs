using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("StrCon")
        {

        }
        public virtual DbSet<Atividade> Atividades { get; set; }

    }
}
