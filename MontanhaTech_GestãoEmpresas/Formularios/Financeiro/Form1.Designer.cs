namespace MontanhaTech_GestaoEmpresas.Formularios.Financeiro
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabelaEmpresa = new MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresa();
            this.tabelaEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMPTableAdapter = new MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresaTableAdapters.MEMPTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminhoLogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrMunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContribICMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailNFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codIBGEMunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.logoDataGridViewImageColumn,
            this.nomeEmpresaDataGridViewTextBoxColumn,
            this.caminhoLogoDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.inscrEstadualDataGridViewTextBoxColumn,
            this.inscrMunicipalDataGridViewTextBoxColumn,
            this.cNAEDataGridViewTextBoxColumn,
            this.cRTDataGridViewTextBoxColumn,
            this.tipoContribICMSDataGridViewTextBoxColumn,
            this.emailNFeDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn,
            this.codIBGEMunicipioDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.codPaisDataGridViewTextBoxColumn,
            this.tipoEmpresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabelaEmpresa
            // 
            this.tabelaEmpresa.DataSetName = "TabelaEmpresa";
            this.tabelaEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaEmpresaBindingSource
            // 
            this.tabelaEmpresaBindingSource.DataSource = this.tabelaEmpresa;
            this.tabelaEmpresaBindingSource.Position = 0;
            // 
            // mEMPBindingSource
            // 
            this.mEMPBindingSource.DataMember = "MEMP";
            this.mEMPBindingSource.DataSource = this.tabelaEmpresaBindingSource;
            // 
            // mEMPTableAdapter
            // 
            this.mEMPTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // logoDataGridViewImageColumn
            // 
            this.logoDataGridViewImageColumn.DataPropertyName = "Logo";
            this.logoDataGridViewImageColumn.HeaderText = "Logo";
            this.logoDataGridViewImageColumn.Name = "logoDataGridViewImageColumn";
            // 
            // nomeEmpresaDataGridViewTextBoxColumn
            // 
            this.nomeEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.HeaderText = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.Name = "nomeEmpresaDataGridViewTextBoxColumn";
            // 
            // caminhoLogoDataGridViewTextBoxColumn
            // 
            this.caminhoLogoDataGridViewTextBoxColumn.DataPropertyName = "CaminhoLogo";
            this.caminhoLogoDataGridViewTextBoxColumn.HeaderText = "CaminhoLogo";
            this.caminhoLogoDataGridViewTextBoxColumn.Name = "caminhoLogoDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // inscrEstadualDataGridViewTextBoxColumn
            // 
            this.inscrEstadualDataGridViewTextBoxColumn.DataPropertyName = "InscrEstadual";
            this.inscrEstadualDataGridViewTextBoxColumn.HeaderText = "InscrEstadual";
            this.inscrEstadualDataGridViewTextBoxColumn.Name = "inscrEstadualDataGridViewTextBoxColumn";
            // 
            // inscrMunicipalDataGridViewTextBoxColumn
            // 
            this.inscrMunicipalDataGridViewTextBoxColumn.DataPropertyName = "InscrMunicipal";
            this.inscrMunicipalDataGridViewTextBoxColumn.HeaderText = "InscrMunicipal";
            this.inscrMunicipalDataGridViewTextBoxColumn.Name = "inscrMunicipalDataGridViewTextBoxColumn";
            // 
            // cNAEDataGridViewTextBoxColumn
            // 
            this.cNAEDataGridViewTextBoxColumn.DataPropertyName = "CNAE";
            this.cNAEDataGridViewTextBoxColumn.HeaderText = "CNAE";
            this.cNAEDataGridViewTextBoxColumn.Name = "cNAEDataGridViewTextBoxColumn";
            // 
            // cRTDataGridViewTextBoxColumn
            // 
            this.cRTDataGridViewTextBoxColumn.DataPropertyName = "CRT";
            this.cRTDataGridViewTextBoxColumn.HeaderText = "CRT";
            this.cRTDataGridViewTextBoxColumn.Name = "cRTDataGridViewTextBoxColumn";
            // 
            // tipoContribICMSDataGridViewTextBoxColumn
            // 
            this.tipoContribICMSDataGridViewTextBoxColumn.DataPropertyName = "TipoContribICMS";
            this.tipoContribICMSDataGridViewTextBoxColumn.HeaderText = "TipoContribICMS";
            this.tipoContribICMSDataGridViewTextBoxColumn.Name = "tipoContribICMSDataGridViewTextBoxColumn";
            // 
            // emailNFeDataGridViewTextBoxColumn
            // 
            this.emailNFeDataGridViewTextBoxColumn.DataPropertyName = "EmailNFe";
            this.emailNFeDataGridViewTextBoxColumn.HeaderText = "EmailNFe";
            this.emailNFeDataGridViewTextBoxColumn.Name = "emailNFeDataGridViewTextBoxColumn";
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            // 
            // codIBGEMunicipioDataGridViewTextBoxColumn
            // 
            this.codIBGEMunicipioDataGridViewTextBoxColumn.DataPropertyName = "CodIBGEMunicipio";
            this.codIBGEMunicipioDataGridViewTextBoxColumn.HeaderText = "CodIBGEMunicipio";
            this.codIBGEMunicipioDataGridViewTextBoxColumn.Name = "codIBGEMunicipioDataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // codPaisDataGridViewTextBoxColumn
            // 
            this.codPaisDataGridViewTextBoxColumn.DataPropertyName = "CodPais";
            this.codPaisDataGridViewTextBoxColumn.HeaderText = "CodPais";
            this.codPaisDataGridViewTextBoxColumn.Name = "codPaisDataGridViewTextBoxColumn";
            // 
            // tipoEmpresaDataGridViewTextBoxColumn
            // 
            this.tipoEmpresaDataGridViewTextBoxColumn.DataPropertyName = "TipoEmpresa";
            this.tipoEmpresaDataGridViewTextBoxColumn.HeaderText = "TipoEmpresa";
            this.tipoEmpresaDataGridViewTextBoxColumn.Name = "tipoEmpresaDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Receber";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Contas Receber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tabelaEmpresaBindingSource;
        private DataSouces.TabelaEmpresa tabelaEmpresa;
        private System.Windows.Forms.BindingSource mEMPBindingSource;
        private DataSouces.TabelaEmpresaTableAdapters.MEMPTableAdapter mEMPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminhoLogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscrEstadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscrMunicipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContribICMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailNFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codIBGEMunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}