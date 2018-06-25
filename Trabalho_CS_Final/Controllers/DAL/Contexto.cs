using Models;
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
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Processador> Processador { get; set; }
        public virtual DbSet<HD> HD { get; set; }
        public virtual DbSet<Memoria> Memoria { get; set; }
        public virtual DbSet<PlacaMae> PlacaMae { get; set; }
        public virtual DbSet<Fonte> Fonte { get; set; }

    }
}
