﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas.Formularios.Financeiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tabelaEmpresa.MEMP'. Você pode movê-la ou removê-la conforme necessário.
            this.mEMPTableAdapter.Fill(this.tabelaEmpresa.MEMP);

        }
    }
}
