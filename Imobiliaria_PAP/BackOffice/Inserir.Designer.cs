namespace Imobiliaria_PAP
{
    partial class Inserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir));
            this.cb_preco = new MetroFramework.Controls.MetroComboBox();
            this.cb_cidade = new MetroFramework.Controls.MetroComboBox();
            this.cb_tipologia = new MetroFramework.Controls.MetroComboBox();
            this.cb_tipo_imovel = new MetroFramework.Controls.MetroComboBox();
            this.cb_negocio = new MetroFramework.Controls.MetroComboBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_preco
            // 
            this.cb_preco.FormattingEnabled = true;
            this.cb_preco.ItemHeight = 23;
            this.cb_preco.Items.AddRange(new object[] {
            "100",
            "250",
            "500",
            "750",
            "1000",
            "50000",
            "7000",
            "10000",
            "250000",
            "500000",
            "750000",
            "1000000",
            "1500000",
            "2000000"});
            this.cb_preco.Location = new System.Drawing.Point(92, 324);
            this.cb_preco.Name = "cb_preco";
            this.cb_preco.PromptText = "Insira o preço";
            this.cb_preco.Size = new System.Drawing.Size(403, 29);
            this.cb_preco.TabIndex = 24;
            this.cb_preco.UseSelectable = true;
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.ItemHeight = 23;
            this.cb_cidade.Items.AddRange(new object[] {
            "Silves",
            "Lagoa",
            "Albufeira",
            "Portimão"});
            this.cb_cidade.Location = new System.Drawing.Point(92, 256);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.PromptText = "Insira a cidade";
            this.cb_cidade.Size = new System.Drawing.Size(402, 29);
            this.cb_cidade.TabIndex = 23;
            this.cb_cidade.UseSelectable = true;
            // 
            // cb_tipologia
            // 
            this.cb_tipologia.FormattingEnabled = true;
            this.cb_tipologia.ItemHeight = 23;
            this.cb_tipologia.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "T1 DUPLEX",
            "T2 DUPLEX"});
            this.cb_tipologia.Location = new System.Drawing.Point(93, 194);
            this.cb_tipologia.Name = "cb_tipologia";
            this.cb_tipologia.PromptText = "Insira a tipologia do imóvel";
            this.cb_tipologia.Size = new System.Drawing.Size(402, 29);
            this.cb_tipologia.TabIndex = 22;
            this.cb_tipologia.UseSelectable = true;
            // 
            // cb_tipo_imovel
            // 
            this.cb_tipo_imovel.FormattingEnabled = true;
            this.cb_tipo_imovel.ItemHeight = 23;
            this.cb_tipo_imovel.Items.AddRange(new object[] {
            "Apartamento",
            "Vivenda",
            "Terreno"});
            this.cb_tipo_imovel.Location = new System.Drawing.Point(95, 129);
            this.cb_tipo_imovel.Name = "cb_tipo_imovel";
            this.cb_tipo_imovel.PromptText = "Insira o tipo de imóvel";
            this.cb_tipo_imovel.Size = new System.Drawing.Size(402, 29);
            this.cb_tipo_imovel.TabIndex = 21;
            this.cb_tipo_imovel.UseSelectable = true;
            // 
            // cb_negocio
            // 
            this.cb_negocio.FormattingEnabled = true;
            this.cb_negocio.ItemHeight = 23;
            this.cb_negocio.Items.AddRange(new object[] {
            "Comprar",
            "Arrendar"});
            this.cb_negocio.Location = new System.Drawing.Point(95, 70);
            this.cb_negocio.Name = "cb_negocio";
            this.cb_negocio.PromptText = "Insira o tipo de negócio";
            this.cb_negocio.Size = new System.Drawing.Size(403, 29);
            this.cb_negocio.TabIndex = 20;
            this.cb_negocio.UseSelectable = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = global::Imobiliaria_PAP.Properties.Resources.cancel;
            this.btn_fechar.Location = new System.Drawing.Point(1, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(43, 43);
            this.btn_fechar.TabIndex = 26;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_add_file_32;
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(92, 378);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(213, 47);
            this.btn_inserir.TabIndex = 51;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_broom_321;
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(311, 378);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(183, 47);
            this.btn_limpar.TabIndex = 52;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.cb_preco);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.cb_tipologia);
            this.Controls.Add(this.cb_tipo_imovel);
            this.Controls.Add(this.cb_negocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cb_preco;
        private MetroFramework.Controls.MetroComboBox cb_cidade;
        private MetroFramework.Controls.MetroComboBox cb_tipologia;
        private MetroFramework.Controls.MetroComboBox cb_tipo_imovel;
        private MetroFramework.Controls.MetroComboBox cb_negocio;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_limpar;
    }
}