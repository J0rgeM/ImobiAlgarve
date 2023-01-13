namespace Imobiliaria_PAP
{
    partial class Registar
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            this.btn_registar = new MetroFramework.Controls.MetroButton();
            this.cmb_Cargo = new MetroFramework.Controls.MetroComboBox();
            this.txt_apelido = new MetroFramework.Controls.MetroTextBox();
            this.txt_nome = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_confpass = new MetroFramework.Controls.MetroTextBox();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.panel_barratitulo = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registar
            // 
            this.btn_registar.Location = new System.Drawing.Point(280, 400);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(255, 42);
            this.btn_registar.TabIndex = 3;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseSelectable = true;
            this.btn_registar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.ItemHeight = 23;
            this.cmb_Cargo.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.cmb_Cargo.Location = new System.Drawing.Point(280, 349);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.PromptText = "Insira o cargo";
            this.cmb_Cargo.Size = new System.Drawing.Size(255, 29);
            this.cmb_Cargo.TabIndex = 9;
            this.cmb_Cargo.UseSelectable = true;
            // 
            // txt_apelido
            // 
            // 
            // 
            // 
            this.txt_apelido.CustomButton.Image = null;
            this.txt_apelido.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txt_apelido.CustomButton.Name = "";
            this.txt_apelido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apelido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apelido.CustomButton.TabIndex = 1;
            this.txt_apelido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apelido.CustomButton.UseSelectable = true;
            this.txt_apelido.CustomButton.Visible = false;
            this.txt_apelido.DisplayIcon = true;
            this.txt_apelido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_apelido.Icon = ((System.Drawing.Image)(resources.GetObject("txt_apelido.Icon")));
            this.txt_apelido.Lines = new string[0];
            this.txt_apelido.Location = new System.Drawing.Point(280, 167);
            this.txt_apelido.MaxLength = 32767;
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.PasswordChar = '\0';
            this.txt_apelido.PromptText = "Insira o apelido";
            this.txt_apelido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apelido.SelectedText = "";
            this.txt_apelido.SelectionLength = 0;
            this.txt_apelido.SelectionStart = 0;
            this.txt_apelido.ShortcutsEnabled = true;
            this.txt_apelido.Size = new System.Drawing.Size(255, 23);
            this.txt_apelido.TabIndex = 80;
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
            this.txt_nome.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txt_nome.CustomButton.Name = "";
            this.txt_nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nome.CustomButton.TabIndex = 1;
            this.txt_nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nome.CustomButton.UseSelectable = true;
            this.txt_nome.CustomButton.Visible = false;
            this.txt_nome.DisplayIcon = true;
            this.txt_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nome.Icon = ((System.Drawing.Image)(resources.GetObject("txt_nome.Icon")));
            this.txt_nome.Lines = new string[0];
            this.txt_nome.Location = new System.Drawing.Point(280, 118);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PromptText = "Insira o nome";
            this.txt_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.ShortcutsEnabled = true;
            this.txt_nome.Size = new System.Drawing.Size(255, 23);
            this.txt_nome.TabIndex = 79;
            this.txt_nome.UseSelectable = true;
            this.txt_nome.WaterMark = "Insira o nome";
            this.txt_nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 386);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.CustomButton.Image = null;
            this.txt_pass.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txt_pass.CustomButton.Name = "";
            this.txt_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pass.CustomButton.TabIndex = 1;
            this.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pass.CustomButton.UseSelectable = true;
            this.txt_pass.CustomButton.Visible = false;
            this.txt_pass.DisplayIcon = true;
            this.txt_pass.Icon = ((System.Drawing.Image)(resources.GetObject("txt_pass.Icon")));
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(280, 266);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PromptText = "Insira uma palavra-passe";
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(236, 23);
            this.txt_pass.TabIndex = 7;
            this.txt_pass.UseSelectable = true;
            this.txt_pass.WaterMark = "Insira uma palavra-passe";
            this.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.DisplayIcon = true;
            this.txt_email.Icon = ((System.Drawing.Image)(resources.GetObject("txt_email.Icon")));
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(280, 219);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PromptText = "Insira um email";
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(255, 23);
            this.txt_email.TabIndex = 6;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMark = "Insira um email";
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_confpass
            // 
            // 
            // 
            // 
            this.txt_confpass.CustomButton.Image = null;
            this.txt_confpass.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txt_confpass.CustomButton.Name = "";
            this.txt_confpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_confpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confpass.CustomButton.TabIndex = 1;
            this.txt_confpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confpass.CustomButton.UseSelectable = true;
            this.txt_confpass.CustomButton.Visible = false;
            this.txt_confpass.DisplayIcon = true;
            this.txt_confpass.Icon = ((System.Drawing.Image)(resources.GetObject("txt_confpass.Icon")));
            this.txt_confpass.Lines = new string[0];
            this.txt_confpass.Location = new System.Drawing.Point(280, 308);
            this.txt_confpass.MaxLength = 32767;
            this.txt_confpass.Name = "txt_confpass";
            this.txt_confpass.PasswordChar = '*';
            this.txt_confpass.PromptText = "Confirmar a palavra-passe";
            this.txt_confpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confpass.SelectedText = "";
            this.txt_confpass.SelectionLength = 0;
            this.txt_confpass.SelectionStart = 0;
            this.txt_confpass.ShortcutsEnabled = true;
            this.txt_confpass.Size = new System.Drawing.Size(255, 23);
            this.txt_confpass.TabIndex = 5;
            this.txt_confpass.UseSelectable = true;
            this.txt_confpass.WaterMark = "Confirmar a palavra-passe";
            this.txt_confpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_user
            // 
            // 
            // 
            // 
            this.txt_user.CustomButton.Image = null;
            this.txt_user.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txt_user.CustomButton.Name = "";
            this.txt_user.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_user.CustomButton.TabIndex = 1;
            this.txt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_user.CustomButton.UseSelectable = true;
            this.txt_user.CustomButton.Visible = false;
            this.txt_user.DisplayIcon = true;
            this.txt_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_user.Icon = ((System.Drawing.Image)(resources.GetObject("txt_user.Icon")));
            this.txt_user.Lines = new string[0];
            this.txt_user.Location = new System.Drawing.Point(280, 76);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PromptText = "Insira um username";
            this.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.ShortcutsEnabled = true;
            this.txt_user.Size = new System.Drawing.Size(255, 23);
            this.txt_user.TabIndex = 1;
            this.txt_user.UseSelectable = true;
            this.txt_user.WaterMark = "Insira um username";
            this.txt_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel_barratitulo
            // 
            this.panel_barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel_barratitulo.Controls.Add(this.btnminimizar);
            this.panel_barratitulo.Controls.Add(this.pictureBox3);
            this.panel_barratitulo.Controls.Add(this.button4);
            this.panel_barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barratitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_barratitulo.Location = new System.Drawing.Point(0, 0);
            this.panel_barratitulo.Name = "panel_barratitulo";
            this.panel_barratitulo.Size = new System.Drawing.Size(626, 45);
            this.panel_barratitulo.TabIndex = 81;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(578, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 15);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 26;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(599, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 45);
            this.button4.TabIndex = 18;
            this.button4.Text = "Registar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // linkSignUp
            // 
            this.linkSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkColor = System.Drawing.Color.Gray;
            this.linkSignUp.Location = new System.Drawing.Point(319, 455);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(182, 17);
            this.linkSignUp.TabIndex = 82;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Já tem conta? Inicie sessão";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 554);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.panel_barratitulo);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmb_Cargo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_confpass);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroButton btn_registar;
        private MetroFramework.Controls.MetroTextBox txt_confpass;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private MetroFramework.Controls.MetroComboBox cmb_Cargo;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txt_nome;
        private MetroFramework.Controls.MetroTextBox txt_apelido;
        private System.Windows.Forms.Panel panel_barratitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.LinkLabel linkSignUp;
    }
}

