namespace Imobiliaria_PAP
{
    partial class Utilizadores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.txt_apelido = new MetroFramework.Controls.MetroTextBox();
            this.txt_nome = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.txt_confpassword = new MetroFramework.Controls.MetroTextBox();
            this.txt_codigo = new MetroFramework.Controls.MetroTextBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.cmb_Cargo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(34, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 262);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(784, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(34, 44);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Pesquise pelo nome de utilizador";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(806, 24);
            this.metroTextBox2.TabIndex = 33;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Pesquise pelo nome de utilizador";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = global::Imobiliaria_PAP.Properties.Resources.cancel;
            this.btn_fechar.Location = new System.Drawing.Point(0, -4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(43, 43);
            this.btn_fechar.TabIndex = 34;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_edit_321;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(553, 342);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(260, 41);
            this.btn_editar.TabIndex = 51;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.CustomButton.Image = null;
            this.txt_username.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_username.CustomButton.Name = "";
            this.txt_username.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_username.CustomButton.TabIndex = 1;
            this.txt_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_username.CustomButton.UseSelectable = true;
            this.txt_username.CustomButton.Visible = false;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(33, 380);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PromptText = "Insira o username";
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(234, 22);
            this.txt_username.TabIndex = 52;
            this.txt_username.UseSelectable = true;
            this.txt_username.WaterMark = "Insira o username";
            this.txt_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_apelido
            // 
            // 
            // 
            // 
            this.txt_apelido.CustomButton.Image = null;
            this.txt_apelido.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_apelido.CustomButton.Name = "";
            this.txt_apelido.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_apelido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apelido.CustomButton.TabIndex = 1;
            this.txt_apelido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apelido.CustomButton.UseSelectable = true;
            this.txt_apelido.CustomButton.Visible = false;
            this.txt_apelido.Lines = new string[0];
            this.txt_apelido.Location = new System.Drawing.Point(33, 462);
            this.txt_apelido.MaxLength = 32767;
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.PasswordChar = '\0';
            this.txt_apelido.PromptText = "Insira o apelido";
            this.txt_apelido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apelido.SelectedText = "";
            this.txt_apelido.SelectionLength = 0;
            this.txt_apelido.SelectionStart = 0;
            this.txt_apelido.ShortcutsEnabled = true;
            this.txt_apelido.Size = new System.Drawing.Size(234, 22);
            this.txt_apelido.TabIndex = 53;
            this.txt_apelido.UseSelectable = true;
            this.txt_apelido.WaterMark = "Insira o apelido";
            this.txt_apelido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apelido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_nome
            // 
            // 
            // 
            // 
            this.txt_nome.CustomButton.Image = null;
            this.txt_nome.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_nome.CustomButton.Name = "";
            this.txt_nome.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nome.CustomButton.TabIndex = 1;
            this.txt_nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nome.CustomButton.UseSelectable = true;
            this.txt_nome.CustomButton.Visible = false;
            this.txt_nome.Lines = new string[0];
            this.txt_nome.Location = new System.Drawing.Point(33, 420);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PromptText = "Insira o nome";
            this.txt_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.ShortcutsEnabled = true;
            this.txt_nome.Size = new System.Drawing.Size(234, 22);
            this.txt_nome.TabIndex = 54;
            this.txt_nome.UseSelectable = true;
            this.txt_nome.WaterMark = "Insira o nome";
            this.txt_nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(289, 342);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Insira o email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(239, 22);
            this.txt_email.TabIndex = 55;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Insira o email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(289, 380);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PromptText = "Insira a password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(239, 22);
            this.txt_password.TabIndex = 56;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMark = "Insira a password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_confpassword
            // 
            // 
            // 
            // 
            this.txt_confpassword.CustomButton.Image = null;
            this.txt_confpassword.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txt_confpassword.CustomButton.Name = "";
            this.txt_confpassword.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_confpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confpassword.CustomButton.TabIndex = 1;
            this.txt_confpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confpassword.CustomButton.UseSelectable = true;
            this.txt_confpassword.CustomButton.Visible = false;
            this.txt_confpassword.Lines = new string[0];
            this.txt_confpassword.Location = new System.Drawing.Point(289, 420);
            this.txt_confpassword.MaxLength = 32767;
            this.txt_confpassword.Name = "txt_confpassword";
            this.txt_confpassword.PasswordChar = '\0';
            this.txt_confpassword.PromptText = "Confirma a password";
            this.txt_confpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confpassword.SelectedText = "";
            this.txt_confpassword.SelectionLength = 0;
            this.txt_confpassword.SelectionStart = 0;
            this.txt_confpassword.ShortcutsEnabled = true;
            this.txt_confpassword.Size = new System.Drawing.Size(239, 22);
            this.txt_confpassword.TabIndex = 57;
            this.txt_confpassword.UseSelectable = true;
            this.txt_confpassword.WaterMark = "Confirma a password";
            this.txt_confpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_codigo
            // 
            // 
            // 
            // 
            this.txt_codigo.CustomButton.Image = null;
            this.txt_codigo.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_codigo.CustomButton.Name = "";
            this.txt_codigo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_codigo.CustomButton.TabIndex = 1;
            this.txt_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_codigo.CustomButton.UseSelectable = true;
            this.txt_codigo.CustomButton.Visible = false;
            this.txt_codigo.Lines = new string[0];
            this.txt_codigo.Location = new System.Drawing.Point(33, 342);
            this.txt_codigo.MaxLength = 32767;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.PromptText = "Insira o código";
            this.txt_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo.SelectedText = "";
            this.txt_codigo.SelectionLength = 0;
            this.txt_codigo.SelectionStart = 0;
            this.txt_codigo.ShortcutsEnabled = true;
            this.txt_codigo.Size = new System.Drawing.Size(234, 22);
            this.txt_codigo.TabIndex = 58;
            this.txt_codigo.UseSelectable = true;
            this.txt_codigo.WaterMark = "Insira o código";
            this.txt_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_cancel_subscription_321;
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover.Location = new System.Drawing.Point(686, 389);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(127, 42);
            this.btn_remover.TabIndex = 61;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::Imobiliaria_PAP.Properties.Resources.icons8_broom_32;
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(553, 389);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(127, 42);
            this.btn_limpar.TabIndex = 60;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.ItemHeight = 23;
            this.cmb_Cargo.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.cmb_Cargo.Location = new System.Drawing.Point(289, 455);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.PromptText = "Insira o cargo";
            this.cmb_Cargo.Size = new System.Drawing.Size(239, 29);
            this.cmb_Cargo.TabIndex = 63;
            this.cmb_Cargo.UseSelectable = true;
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 496);
            this.Controls.Add(this.cmb_Cargo);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_confpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Utilizadores";
            this.Text = "Gerir Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_editar;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroTextBox txt_apelido;
        private MetroFramework.Controls.MetroTextBox txt_nome;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTextBox txt_confpassword;
        private MetroFramework.Controls.MetroTextBox txt_codigo;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limpar;
        private MetroFramework.Controls.MetroComboBox cmb_Cargo;
    }
}