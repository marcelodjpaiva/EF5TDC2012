//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agenda.WebEDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contato
    {
        public Contato()
        {
            this.Anotacoes = new HashSet<Anotaco>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Tipo { get; set; }
    
        public virtual ICollection<Anotaco> Anotacoes { get; set; }
    }
}