using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Computador
    {

        public string Nome_Cliente { get; set; }

        public HD HD { get; set; }
        public Processador Processador { get; set; }
        public PlacaMae PlacaMae { get; set; }
        public Fonte Fonte { get; set; }
        public Memoria Memoria { get; set; }

        public decimal ValorTotal { get; set; }

    }
}
