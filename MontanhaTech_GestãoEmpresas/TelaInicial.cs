﻿using MontanhaTech_GestaoEmpresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MontanhaTech_GestãoEmpresas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent(); 
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void MenuInicial_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (MenuInicial.SelectedNode.Tag)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":// Cadastro Item
                    CadastroItem CadastroItem = new CadastroItem();
                    CadastroItem.MdiParent = this;
                    CadastroItem.Show();
                    CadastroItem.BringToFront();
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                default:
                    break;
            }
        }
    }
}
