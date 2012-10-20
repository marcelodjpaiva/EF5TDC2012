using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agenda.Web
{
    public class ContextoAgendaWeb: DbContext
    {
        public ContextoAgendaWeb() : base("conexao")
        {            
        }

        public DbSet<Agenda.Dominio.Contato> Contatos { get; set; }
        public DbSet<Agenda.Dominio.Anotacao> Anotacoes { get; set; }

    }
}