using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace Agenda.Dominio
{
    [Table("Pessoas")]
    public class Contato
    {
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }
    }
}
