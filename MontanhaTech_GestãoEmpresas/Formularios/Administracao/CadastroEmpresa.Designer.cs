using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    partial class CadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.Cnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnUser = new System.Windows.Forms.Button();
            this.TipoEmp = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabelaEmpresa = new MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresa();
            this.mEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMPTableAdapter = new MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresaTableAdapters.MEMPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ramo Empresa";
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEMPBindingSource, "NomeEmpresa", true));
            this.NomeEmpresa.Location = new System.Drawing.Point(98, 41);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(311, 20);
            this.NomeEmpresa.TabIndex = 3;
            // 
            // Logo
            // 
            this.Logo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEMPBindingSource, "CaminhoLogo", true));
            this.Logo.Enabled = false;
            this.Logo.Location = new System.Drawing.Point(98, 68);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 20);
            this.Logo.TabIndex = 4;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 170);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 7;
            this.Btn1.Text = "OK";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(98, 170);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 23);
            this.Btn2.TabIndex = 8;
            this.Btn2.Text = "Cancelar";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // BtnLogo
            // 
            this.BtnLogo.Location = new System.Drawing.Point(372, 67);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(37, 21);
            this.BtnLogo.TabIndex = 9;
            this.BtnLogo.Text = "...";
            this.BtnLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLogo.UseVisualStyleBackColor = true;
            this.BtnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // Cnpj
            // 
            this.Cnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEMPBindingSource, "CNPJ", true));
            this.Cnpj.Location = new System.Drawing.Point(98, 123);
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.Size = new System.Drawing.Size(168, 20);
            this.Cnpj.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CNPJ";
            // 
            // PbLogo
            // 
            this.PbLogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mEMPBindingSource, "Logo", true));
            this.PbLogo.Image = global::MontanhaTech_GestaoEmpresas.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(309, 96);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(100, 56);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            this.PbLogo.WaitOnLoad = true;
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(334, 171);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(75, 23);
            this.BtnUser.TabIndex = 13;
            this.BtnUser.Text = "Usuários";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // TipoEmp
            // 
            this.TipoEmp.CausesValidation = false;
            this.TipoEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mEMPBindingSource, "TipoEmpresa", true));
            this.TipoEmp.DataSource = this.tabelaEmpresa;
            this.TipoEmp.FormatString = "N0";
            this.TipoEmp.FormattingEnabled = true;
            this.TipoEmp.Location = new System.Drawing.Point(98, 96);
            this.TipoEmp.Name = "TipoEmp";
            this.TipoEmp.Size = new System.Drawing.Size(168, 21);
            this.TipoEmp.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Id
            // 
            this.Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEMPBindingSource, "Id", true));
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(98, 15);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(168, 20);
            this.Id.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código";
            // 
            // tabelaEmpresa
            // 
            this.tabelaEmpresa.DataSetName = "TabelaEmpresa";
            this.tabelaEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMPBindingSource
            // 
            this.mEMPBindingSource.DataMember = "MEMP";
            this.mEMPBindingSource.DataSource = this.tabelaEmpresa;
            // 
            // mEMPTableAdapter
            // 
            this.mEMPTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 207);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoEmp);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.Cnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLogo);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroEmpresa";
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.CadastroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeEmpresa;
        private System.Windows.Forms.TextBox Logo;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button BtnLogo;
        private System.Windows.Forms.TextBox Cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbLogo;
        private Button BtnUser;
        private ComboBox TipoEmp;
        private OpenFileDialog openFileDialog1;
        private TextBox Id;
        private Label label5;
        private DataSouces.TabelaEmpresa tabelaEmpresa;
        private BindingSource mEMPBindingSource;
        private DataSouces.TabelaEmpresaTableAdapters.MEMPTableAdapter mEMPTableAdapter;
    }
}