namespace MontanhaTech_GestaoEmpresas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cadastro Empresa", 0, -2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Atualiza Banco de Dados", 3, -2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Administração", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Contas Pagar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Contas Receber");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Financeiro", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cadastro Cliente");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Cliente", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cadastro Item");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Item", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Atualiza Estoque");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Ordem de Serviço");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Estoque", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Cadastro Fornecedor");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Cadastro Consultor");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Fornecedor", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Posição Estoque");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Relatório", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.MenuInicial = new Krypton.Toolkit.KryptonTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // MenuInicial
            // 
            this.MenuInicial.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuInicial.HideSelection = false;
            this.MenuInicial.ImageIndex = 4;
            this.MenuInicial.ImageList = this.imageList1;
            this.MenuInicial.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuInicial.Location = new System.Drawing.Point(0, 0);
            this.MenuInicial.Name = "MenuInicial";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "CadastroEmpresa";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.SelectedImageIndex = -2;
            treeNode1.Tag = "1";
            treeNode1.Text = "Cadastro Empresa";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "AtualizaBanco";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageIndex = -2;
            treeNode2.Tag = "2";
            treeNode2.Text = "Atualiza Banco de Dados";
            treeNode3.Checked = true;
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Adm";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.SelectedImageIndex = -2;
            treeNode3.Text = "Administração";
            treeNode4.Name = "Pagar";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.SelectedImageIndex = -2;
            treeNode4.Text = "Contas Pagar";
            treeNode5.Name = "Receber";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.SelectedImageIndex = -2;
            treeNode5.Text = "Contas Receber";
            treeNode6.Name = "Finan";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.SelectedImageIndex = -2;
            treeNode6.Text = "Financeiro";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "CadastroCliente";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode7.Tag = "3";
            treeNode7.Text = "Cadastro Cliente";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Cliente";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "Cliente";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "CadastroItem";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode9.Tag = "4";
            treeNode9.Text = "Cadastro Item";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "Item";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode10.Text = "Item";
            treeNode11.ImageIndex = 5;
            treeNode11.Name = "InserirEstoque";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode11.Tag = "5";
            treeNode11.Text = "Atualiza Estoque";
            treeNode12.ImageIndex = 6;
            treeNode12.Name = "Os";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode12.Tag = "6";
            treeNode12.Text = "Ordem de Serviço";
            treeNode13.ImageIndex = 5;
            treeNode13.Name = "Estoque";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode13.Text = "Estoque";
            treeNode14.ImageIndex = 7;
            treeNode14.Name = "CadForn";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode14.Tag = "7";
            treeNode14.Text = "Cadastro Fornecedor";
            treeNode15.ImageIndex = 7;
            treeNode15.Name = "CadConsult";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode15.Tag = "8";
            treeNode15.Text = "Cadastro Consultor";
            treeNode16.ImageIndex = 7;
            treeNode16.Name = "Fornecedor";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode16.Text = "Fornecedor";
            treeNode17.ImageIndex = 5;
            treeNode17.Name = "PosicaoEst";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode17.Tag = "9";
            treeNode17.Text = "Posição Estoque";
            treeNode18.ImageIndex = 8;
            treeNode18.Name = "Relat";
            treeNode18.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode18.Text = "Relatório";
            this.MenuInicial.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode13,
            treeNode16,
            treeNode18});
            this.MenuInicial.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.MenuInicial.PathSeparator = "";
            this.MenuInicial.SelectedImageIndex = 0;
            this.MenuInicial.ShowNodeToolTips = true;
            this.MenuInicial.Size = new System.Drawing.Size(294, 652);
            this.MenuInicial.StateImageList = this.imageList1;
            this.MenuInicial.TabIndex = 4;
            this.MenuInicial.Visible = false;
            this.MenuInicial.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MenuInicial_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "corporativo.png");
            this.imageList1.Images.SetKeyName(1, "equipe.png");
            this.imageList1.Images.SetKeyName(2, "produtos.png");
            this.imageList1.Images.SetKeyName(3, "arquivo-de-banco-de-dados.png");
            this.imageList1.Images.SetKeyName(4, "direito.png");
            this.imageList1.Images.SetKeyName(5, "estoque-pronto.png");
            this.imageList1.Images.SetKeyName(6, "engrenagem.png");
            this.imageList1.Images.SetKeyName(7, "fornecedor-de-hoteis.png");
            this.imageList1.Images.SetKeyName(8, "relatorio-de-lucro.png");
            // 
            // TelaInicial
            // 
            this.AllowButtonSpecToolTips = true;
            this.AllowFormChrome = false;
            this.AllowStatusStripMerge = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::MontanhaTech_GestaoEmpresas.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1223, 652);
            this.Controls.Add(this.MenuInicial);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "TelaInicial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MontanhaTech_GestãoEmpresa";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        public Krypton.Toolkit.KryptonTreeView MenuInicial;
    }
}