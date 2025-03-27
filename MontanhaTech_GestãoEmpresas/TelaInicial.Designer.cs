namespace MontanhaTech_GestãoEmpresas
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("CadastroEmpresa");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Atualizar Banco Dados");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Administração", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Cadastro Cliente");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Clientes", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Cadastro Item");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Item", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Adicionar Estoque Manual");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Adicionar Nota Fiscal");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Realizar Venda");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Estoque", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Cadastro Fornecedor");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Cadastro Consultor");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Fornecedor", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Relatórios");
            this.MenuInicial = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // MenuInicial
            // 
            this.MenuInicial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MenuInicial.Location = new System.Drawing.Point(12, 12);
            this.MenuInicial.Name = "MenuInicial";
            treeNode31.Name = "CadastroEmpresa";
            treeNode31.Tag = "1";
            treeNode31.Text = "CadastroEmpresa";
            treeNode32.Name = "AtualizarBancoDados";
            treeNode32.Tag = "2";
            treeNode32.Text = "Atualizar Banco Dados";
            treeNode33.Name = "Adm";
            treeNode33.Text = "Administração";
            treeNode34.Name = "CadastroCliente";
            treeNode34.Tag = "3";
            treeNode34.Text = "Cadastro Cliente";
            treeNode35.Name = "Clientes";
            treeNode35.Text = "Clientes";
            treeNode36.Name = "CadastroItem";
            treeNode36.Tag = "4";
            treeNode36.Text = "Cadastro Item";
            treeNode37.Name = "Item";
            treeNode37.Text = "Item";
            treeNode38.Name = "AdicionarEstoque";
            treeNode38.Tag = "5";
            treeNode38.Text = "Adicionar Estoque Manual";
            treeNode39.Name = "NotaFiscal";
            treeNode39.Tag = "6";
            treeNode39.Text = "Adicionar Nota Fiscal";
            treeNode40.Name = "RealizarVenda";
            treeNode40.Tag = "7";
            treeNode40.Text = "Realizar Venda";
            treeNode41.Name = "Estoque";
            treeNode41.Text = "Estoque";
            treeNode42.Name = "CadastroFornecedor";
            treeNode42.Tag = "8";
            treeNode42.Text = "Cadastro Fornecedor";
            treeNode43.Name = "CadastroConsultor";
            treeNode43.Tag = "9";
            treeNode43.Text = "Cadastro Consultor";
            treeNode44.Name = "Fornecedor";
            treeNode44.Text = "Fornecedor";
            treeNode45.Name = "Relatórios";
            treeNode45.Text = "Relatórios";
            this.MenuInicial.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode37,
            treeNode41,
            treeNode44,
            treeNode45});
            this.MenuInicial.Size = new System.Drawing.Size(274, 628);
            this.MenuInicial.TabIndex = 0;
            this.MenuInicial.Visible = false;
            this.MenuInicial.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MenuInicial_AfterSelect);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MontanhaTech_GestãoEmpresas.Properties.Resources.logoPng___Copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1223, 652);
            this.Controls.Add(this.MenuInicial);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "TelaInicial";
            this.Text = "MontanhaTech_GestãoEmpresa";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView MenuInicial;
    }
}