using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Computador
    {
        public int ID_Cliente { get; set; }
        [Key]
        public int ID_Computador{ get; set; }

        public int HDID { get; set; }
        public HD HD { get; set; }

        public int ProcessadorID { get; set; }
        public virtual Processador _Processador { get; set; }

        public int PlacamaeID { get; set; }
        public virtual PlacaMae PlacaMae { get; set; }

        public int FonteID { get; set; }
        public virtual Fonte Fonte { get; set; }

        public int MemoriaID { get; set; }
        public Memoria Memoria { get; set; }

        public decimal ValorTotal { get; set; }

    }
}
