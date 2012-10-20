using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AgendaTDC2012
{
    public class ContextoAgenda : DbContext
    {
        public ContextoAgenda() : base("conexao")
        {            
        }

        public DbSet<Agenda.Dominio.Contato> Contatos { get; set; }
        public DbSet<Agenda.Dominio.Anotacao> Anotacoes { get; set; }

    }
}
