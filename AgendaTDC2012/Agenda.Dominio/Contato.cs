using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace Agenda.Dominio
{
    public enum TipoContato
    {
        PessoaFisica,
        PessoaJuridica
    }

    [Table("Contatos")]
    public class Contato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string Nome { get; set; }

        [StringLength(100)]
        public virtual string Endereco { get; set; }

        [StringLength(20)]
        public virtual string Telefone { get; set; }

        public virtual TipoContato Tipo { get; set; }

        public virtual ICollection<Anotacao> Anotacoes { get; set; }
    }
}
