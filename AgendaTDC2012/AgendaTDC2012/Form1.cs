using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaTDC2012.Migrations;

namespace AgendaTDC2012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new ContextoAgenda())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextoAgenda, Configuration>());

                var contato = new Agenda.Dominio.Contato
                    {
                        Nome = "José da Silva",
                        Endereco = "Endereço teste",
                        Tipo = Agenda.Dominio.TipoContato.PessoaFisica,
                        Telefone = "62 111-1212312"
                    };

                var anotacao = new Agenda.Dominio.Anotacao { Nota = "Anotação teste", Contato = contato };

                ctx.Contatos.Add(contato);
                ctx.Anotacoes.Add(anotacao);
                ctx.SaveChanges();               
            }
        }
    }
}
