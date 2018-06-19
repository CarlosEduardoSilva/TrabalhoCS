using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }
        [Required, StringLength(30)]
        public string Login { get; set; }
        [Required, StringLength(30)]
        public string Senha { get; set; }
        [Required, StringLength(30)]
        public string Email { get; set; }


        

        public bool Ativo { get; set; }

       // public int ID_Plano { get; set; }

    }
}
