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
            this.montanhaTechDataSet = new MontanhaTech_GestaoEmpresas.MontanhaTechDataSet();
            this.montanhaTechDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaUser = new MontanhaTech_GestaoEmpresas.TabelaUser();
            this.tabelaUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.TextBox();
            this.Ramo = new System.Windows.Forms.ComboBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.Cnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.montanhaTechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montanhaTechDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // montanhaTechDataSet
            // 
            this.montanhaTechDataSet.DataSetName = "MontanhaTechDataSet";
            this.montanhaTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // montanhaTechDataSetBindingSource
            // 
            this.montanhaTechDataSetBindingSource.DataSource = this.montanhaTechDataSet;
            this.montanhaTechDataSetBindingSource.Position = 0;
            // 
            // tabelaUser
            // 
            this.tabelaUser.DataSetName = "TabelaUser";
            this.tabelaUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaUserBindingSource
            // 
            this.tabelaUserBindingSource.DataSource = this.tabelaUser;
            this.tabelaUserBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ramo Empresa";
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.Location = new System.Drawing.Point(98, 12);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(311, 20);
            this.NomeEmpresa.TabIndex = 3;
            // 
            // Logo
            // 
            this.Logo.Enabled = false;
            this.Logo.Location = new System.Drawing.Point(98, 39);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 20);
            this.Logo.TabIndex = 4;
            // 
            // Ramo
            // 
            this.Ramo.FormattingEnabled = true;
            this.Ramo.Location = new System.Drawing.Point(98, 67);
            this.Ramo.Name = "Ramo";
            this.Ramo.Size = new System.Drawing.Size(168, 21);
            this.Ramo.TabIndex = 5;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 141);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 7;
            this.Btn1.Text = "OK";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(98, 141);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 23);
            this.Btn2.TabIndex = 8;
            this.Btn2.Text = "Cancelar";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // BtnLogo
            // 
            this.BtnLogo.Location = new System.Drawing.Point(372, 38);
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
            this.Cnpj.Location = new System.Drawing.Point(98, 94);
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.Size = new System.Drawing.Size(168, 20);
            this.Cnpj.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CNPJ";
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::MontanhaTech_GestaoEmpresas.Properties.Resources.logoPng___Copia;
            this.PbLogo.Location = new System.Drawing.Point(309, 67);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(100, 56);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            this.PbLogo.WaitOnLoad = true;
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(334, 142);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(75, 23);
            this.BtnUser.TabIndex = 13;
            this.BtnUser.Text = "Usuários";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 177);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.Cnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLogo);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Ramo);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroEmpresa";
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.CadastroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.montanhaTechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montanhaTechDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tabelaUserBindingSource;
        private TabelaUser tabelaUser;
        private MontanhaTechDataSet montanhaTechDataSet;
        private System.Windows.Forms.BindingSource montanhaTechDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeEmpresa;
        private System.Windows.Forms.TextBox Logo;
        private System.Windows.Forms.ComboBox Ramo;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button BtnLogo;
        private System.Windows.Forms.TextBox Cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbLogo;
        private Button BtnUser;
    }
}