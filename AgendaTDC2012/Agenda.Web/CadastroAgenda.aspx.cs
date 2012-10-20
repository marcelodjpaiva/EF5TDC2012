using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda.Web
{
    public partial class CadastroAgenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new ContextoAgendaWeb())
            {
                var contato = new Agenda.Dominio.Contato
                {
                    Nome = "José da Silva Web",
                    Endereco = "Endereço teste",
                    Tipo = Agenda.Dominio.TipoContato.PessoaFisica,
                    Telefone = "62 111-1212312"
                };

                ctx.Contatos.Add(contato);
                ctx.SaveChanges();
            }
        }
    }
}