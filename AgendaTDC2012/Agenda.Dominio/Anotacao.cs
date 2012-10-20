using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace Agenda.Dominio
{
    [Table("Anotacoes")]
    public class Anotacao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(250)]
        public virtual string Nota { get; set; }

        public virtual Contato Contato { get; set; }

    }
}
