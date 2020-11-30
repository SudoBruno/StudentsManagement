namespace projeto_facul
{
    partial class FormCadastroProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProf));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbSenha = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbConfirmarSenha = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(200, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 40);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "CANCEL";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BaseColor = System.Drawing.Color.White;
            this.tbUsuario.BorderColor = System.Drawing.Color.Silver;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.tbUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsuario.Location = new System.Drawing.Point(70, 176);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.Size = new System.Drawing.Size(237, 37);
            this.tbUsuario.TabIndex = 38;
            
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(70, 368);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 40);
            this.btnCadastrar.TabIndex = 37;
            this.btnCadastrar.Text = "CADASTRAR-SE";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(67, 223);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 17);
            this.gunaLabel2.TabIndex = 36;
            this.gunaLabel2.Text = "Senha";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(67, 156);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "Usuário";
            // 
            // tbSenha
            // 
            this.tbSenha.BaseColor = System.Drawing.Color.White;
            this.tbSenha.BorderColor = System.Drawing.Color.Silver;
            this.tbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSenha.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSenha.Location = new System.Drawing.Point(70, 243);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.SelectedText = "";
            this.tbSenha.Size = new System.Drawing.Size(237, 37);
            this.tbSenha.TabIndex = 34;
           
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(12, 93);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(365, 10);
            this.gunaLinePanel2.TabIndex = 33;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(48, 90);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(293, 10);
            this.gunaLinePanel1.TabIndex = 32;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel4.Location = new System.Drawing.Point(140, 106);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(119, 30);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "CADASTRO";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(134, 1);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(135, 127);
            this.bunifuTileButton1.TabIndex = 30;
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.BaseColor = System.Drawing.Color.White;
            this.tbConfirmarSenha.BorderColor = System.Drawing.Color.Silver;
            this.tbConfirmarSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmarSenha.FocusedBaseColor = System.Drawing.Color.White;
            this.tbConfirmarSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbConfirmarSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmarSenha.Location = new System.Drawing.Point(70, 312);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.PasswordChar = '*';
            this.tbConfirmarSenha.SelectedText = "";
            this.tbConfirmarSenha.Size = new System.Drawing.Size(237, 37);
            this.tbConfirmarSenha.TabIndex = 41;
            
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(67, 292);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(104, 17);
            this.gunaLabel3.TabIndex = 42;
            this.gunaLabel3.Text = "Confirmar senha";
            // 
            // FormCadastroProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(395, 449);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.tbConfirmarSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.bunifuTileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroProf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private Guna.UI.WinForms.GunaTextBox tbUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tbSenha;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Guna.UI.WinForms.GunaTextBox tbConfirmarSenha;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}