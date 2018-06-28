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

        public HD HD { get; set; }
        public Processador Processador { get; set; }
        public PlacaMae PlacaMae { get; set; }
        public Fonte Fonte { get; set; }
        public Memoria Memoria { get; set; }

        public decimal ValorTotal { get; set; }

    }
}
