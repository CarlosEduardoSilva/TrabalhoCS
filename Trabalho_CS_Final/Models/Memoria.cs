using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Memoria
    {
        [Key]
        public int ID_Memoria { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

    }
}
