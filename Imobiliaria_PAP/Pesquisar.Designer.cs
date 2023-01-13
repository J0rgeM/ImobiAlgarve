namespace Imobiliaria_PAP
{
    partial class Pesquisar
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmb_preco = new MetroFramework.Controls.MetroComboBox();
            this.cmb_tipologia = new MetroFramework.Controls.MetroComboBox();
            this.cmb_cidade = new MetroFramework.Controls.MetroComboBox();
            this.cmb_tipoimovel = new MetroFramework.Controls.MetroComboBox();
            this.cmb_negocio = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(12, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(852, 321);
            this.dataGridView2.TabIndex = 27;
            // 
            // cmb_preco
            // 
            this.cmb_preco.FormattingEnabled = true;
            this.cmb_preco.ItemHeight = 23;
            this.cmb_preco.Items.AddRange(new object[] {
            "100",
            "250",
            "500",
            "750",
            "1000",
            "50000",
            "75000",
            "100000",
            "250000",
            "500000",
            "750000",
            "1000000",
            "1500000",
            "2000000"});
            this.cmb_preco.Location = new System.Drawing.Point(587, 89);
            this.cmb_preco.Name = "cmb_preco";
            this.cmb_preco.PromptText = "Selecionar";
            this.cmb_preco.Size = new System.Drawing.Size(134, 29);
            this.cmb_preco.TabIndex = 26;
            this.cmb_preco.UseSelectable = true;
            // 
            // cmb_tipologia
            // 
            this.cmb_tipologia.FormattingEnabled = true;
            this.cmb_tipologia.ItemHeight = 23;
            this.cmb_tipologia.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "T1 DUPLEX",
            "T2 DUPLEX"});
            this.cmb_tipologia.Location = new System.Drawing.Point(294, 88);
            this.cmb_tipologia.Name = "cmb_tipologia";
            this.cmb_tipologia.PromptText = "Selecionar";
            this.cmb_tipologia.Size = new System.Drawing.Size(136, 29);
            this.cmb_tipologia.TabIndex = 24;
            this.cmb_tipologia.UseSelectable = true;
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.ItemHeight = 23;
            this.cmb_cidade.Items.AddRange(new object[] {
            "Silves",
            "Lagoa",
            "Albufeira",
            "Portimão"});
            this.cmb_cidade.Location = new System.Drawing.Point(445, 88);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.PromptText = "Selecionar";
            this.cmb_cidade.Size = new System.Drawing.Size(136, 29);
            this.cmb_cidade.TabIndex = 21;
            this.cmb_cidade.UseSelectable = true;
            // 
            // cmb_tipoimovel
            // 
            this.cmb_tipoimovel.FormattingEnabled = true;
            this.cmb_tipoimovel.ItemHeight = 23;
            this.cmb_tipoimovel.Items.AddRange(new object[] {
            "Apartamento",
            "Vivenda",
            "Terreno"});
            this.cmb_tipoimovel.Location = new System.Drawing.Point(147, 89);
            this.cmb_tipoimovel.Name = "cmb_tipoimovel";
            this.cmb_tipoimovel.PromptText = "Selecionar";
            this.cmb_tipoimovel.Size = new System.Drawing.Size(132, 29);
            this.cmb_tipoimovel.TabIndex = 19;
            this.cmb_tipoimovel.UseSelectable = true;
            // 
            // cmb_negocio
            // 
            this.cmb_negocio.FormattingEnabled = true;
            this.cmb_negocio.ItemHeight = 23;
            this.cmb_negocio.Items.AddRange(new object[] {
            "Comprar",
            "Arrendar"});
            this.cmb_negocio.Location = new System.Drawing.Point(12, 89);
            this.cmb_negocio.Name = "cmb_negocio";
            this.cmb_negocio.PromptText = "Selecionar";
            this.cmb_negocio.Size = new System.Drawing.Size(120, 29);
            this.cmb_negocio.TabIndex = 17;
            this.cmb_negocio.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Negócio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo de Imóvel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tipologia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cidade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Preço até";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_broom_322;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(727, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 36;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_search_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(727, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = global::Imobiliaria_PAP.Properties.Resources.cancel;
            this.btn_fechar.Location = new System.Drawing.Point(1, -1);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(43, 43);
            this.btn_fechar.TabIndex = 28;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmb_preco);
            this.Controls.Add(this.cmb_tipologia);
            this.Controls.Add(this.cmb_cidade);
            this.Controls.Add(this.cmb_tipoimovel);
            this.Controls.Add(this.cmb_negocio);
            this.Name = "Pesquisar";
            this.Text = " Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroComboBox cmb_preco;
        private MetroFramework.Controls.MetroComboBox cmb_tipologia;
        private MetroFramework.Controls.MetroComboBox cmb_cidade;
        private MetroFramework.Controls.MetroComboBox cmb_tipoimovel;
        private MetroFramework.Controls.MetroComboBox cmb_negocio;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}