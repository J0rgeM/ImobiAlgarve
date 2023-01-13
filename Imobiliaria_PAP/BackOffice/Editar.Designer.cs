namespace Imobiliaria_PAP
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.cbr_preco = new MetroFramework.Controls.MetroComboBox();
            this.cbr_cidade = new MetroFramework.Controls.MetroComboBox();
            this.cbr_tipologia = new MetroFramework.Controls.MetroComboBox();
            this.cbr_tipo_imovel = new MetroFramework.Controls.MetroComboBox();
            this.cbr_negocio = new MetroFramework.Controls.MetroComboBox();
            this.txt_cod = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbr_preco
            // 
            this.cbr_preco.FormattingEnabled = true;
            this.cbr_preco.ItemHeight = 23;
            this.cbr_preco.Items.AddRange(new object[] {
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
            this.cbr_preco.Location = new System.Drawing.Point(279, 401);
            this.cbr_preco.Name = "cbr_preco";
            this.cbr_preco.PromptText = "Selecione o preço";
            this.cbr_preco.Size = new System.Drawing.Size(226, 29);
            this.cbr_preco.TabIndex = 48;
            this.cbr_preco.UseSelectable = true;
            // 
            // cbr_cidade
            // 
            this.cbr_cidade.FormattingEnabled = true;
            this.cbr_cidade.ItemHeight = 23;
            this.cbr_cidade.Items.AddRange(new object[] {
            "Silves",
            "Lagoa",
            "Albufeira",
            "Portimão"});
            this.cbr_cidade.Location = new System.Drawing.Point(279, 366);
            this.cbr_cidade.Name = "cbr_cidade";
            this.cbr_cidade.PromptText = "Selecione a cidade";
            this.cbr_cidade.Size = new System.Drawing.Size(226, 29);
            this.cbr_cidade.TabIndex = 48;
            this.cbr_cidade.UseSelectable = true;
            // 
            // cbr_tipologia
            // 
            this.cbr_tipologia.FormattingEnabled = true;
            this.cbr_tipologia.ItemHeight = 23;
            this.cbr_tipologia.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "T1 DUPLEX",
            "T2 DUPLEX"});
            this.cbr_tipologia.Location = new System.Drawing.Point(279, 331);
            this.cbr_tipologia.Name = "cbr_tipologia";
            this.cbr_tipologia.PromptText = "Selecione a tipologia";
            this.cbr_tipologia.Size = new System.Drawing.Size(226, 29);
            this.cbr_tipologia.TabIndex = 48;
            this.cbr_tipologia.UseSelectable = true;
            // 
            // cbr_tipo_imovel
            // 
            this.cbr_tipo_imovel.FormattingEnabled = true;
            this.cbr_tipo_imovel.ItemHeight = 23;
            this.cbr_tipo_imovel.Items.AddRange(new object[] {
            "Apartamento",
            "Vivenda",
            "Terreno"});
            this.cbr_tipo_imovel.Location = new System.Drawing.Point(26, 395);
            this.cbr_tipo_imovel.Name = "cbr_tipo_imovel";
            this.cbr_tipo_imovel.PromptText = "Selecione o tipo de imóvel";
            this.cbr_tipo_imovel.Size = new System.Drawing.Size(226, 29);
            this.cbr_tipo_imovel.TabIndex = 48;
            this.cbr_tipo_imovel.UseSelectable = true;
            // 
            // cbr_negocio
            // 
            this.cbr_negocio.FormattingEnabled = true;
            this.cbr_negocio.ItemHeight = 23;
            this.cbr_negocio.Items.AddRange(new object[] {
            "Comprar",
            "Arrendar"});
            this.cbr_negocio.Location = new System.Drawing.Point(28, 360);
            this.cbr_negocio.Name = "cbr_negocio";
            this.cbr_negocio.PromptText = "Selecione o negócio";
            this.cbr_negocio.Size = new System.Drawing.Size(224, 29);
            this.cbr_negocio.TabIndex = 48;
            this.cbr_negocio.UseSelectable = true;
            // 
            // txt_cod
            // 
            // 
            // 
            // 
            this.txt_cod.CustomButton.Image = null;
            this.txt_cod.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txt_cod.CustomButton.Name = "";
            this.txt_cod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cod.CustomButton.TabIndex = 1;
            this.txt_cod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cod.CustomButton.UseSelectable = true;
            this.txt_cod.CustomButton.Visible = false;
            this.txt_cod.Lines = new string[0];
            this.txt_cod.Location = new System.Drawing.Point(26, 331);
            this.txt_cod.MaxLength = 32767;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.PasswordChar = '\0';
            this.txt_cod.PromptText = "Insira o código do imóvel";
            this.txt_cod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cod.SelectedText = "";
            this.txt_cod.SelectionLength = 0;
            this.txt_cod.SelectionStart = 0;
            this.txt_cod.ShortcutsEnabled = true;
            this.txt_cod.Size = new System.Drawing.Size(226, 23);
            this.txt_cod.TabIndex = 33;
            this.txt_cod.UseSelectable = true;
            this.txt_cod.WaterMark = "Insira o código do imóvel";
            this.txt_cod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 244);
            this.dataGridView1.TabIndex = 47;
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_cancel_subscription_321;
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover.Location = new System.Drawing.Point(681, 379);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(126, 42);
            this.btn_remover.TabIndex = 52;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_broom_321;
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(549, 379);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(126, 42);
            this.btn_limpar.TabIndex = 51;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_edit_321;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(549, 331);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(258, 42);
            this.btn_editar.TabIndex = 50;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = global::Imobiliaria_PAP.Properties.Resources.cancel;
            this.btn_fechar.Location = new System.Drawing.Point(2, -1);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(43, 43);
            this.btn_fechar.TabIndex = 50;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.cbr_preco);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.cbr_cidade);
            this.Controls.Add(this.cbr_tipologia);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.cbr_tipo_imovel);
            this.Controls.Add(this.cbr_negocio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.BackOffice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbr_preco;
        private MetroFramework.Controls.MetroComboBox cbr_cidade;
        private MetroFramework.Controls.MetroComboBox cbr_tipologia;
        private MetroFramework.Controls.MetroComboBox cbr_tipo_imovel;
        private MetroFramework.Controls.MetroComboBox cbr_negocio;
        private MetroFramework.Controls.MetroTextBox txt_cod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_remover;
    }
}