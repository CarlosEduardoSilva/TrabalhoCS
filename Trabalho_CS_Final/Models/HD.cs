using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HD
    {
        [Key]
        public int ID_HD { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

    }
}
