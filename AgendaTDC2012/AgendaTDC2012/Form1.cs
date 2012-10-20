﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                ctx.Contatos.Add(new Agenda.Dominio.Contato { Nome = "TESTE"});
                ctx.SaveChanges();               
            }
        }
    }
}
