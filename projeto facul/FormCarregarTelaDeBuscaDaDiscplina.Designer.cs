namespace projeto_facul
{
    partial class FormCarregarTelaDeBuscaDaDiscplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarregarTelaDeBuscaDaDiscplina));
            this.tbPalavraPesquisada = new Guna.UI.WinForms.GunaTextBox();
            this.btnPesquisarDisciplina = new XanderUI.XUIButton();
            this.dataGridViewPesquisarDisciplina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPalavraPesquisada
            // 
            this.tbPalavraPesquisada.BaseColor = System.Drawing.Color.White;
            this.tbPalavraPesquisada.BorderColor = System.Drawing.Color.Silver;
            this.tbPalavraPesquisada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPalavraPesquisada.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPalavraPesquisada.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPalavraPesquisada.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPalavraPesquisada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPalavraPesquisada.Location = new System.Drawing.Point(12, 12);
            this.tbPalavraPesquisada.Name = "tbPalavraPesquisada";
            this.tbPalavraPesquisada.PasswordChar = '\0';
            this.tbPalavraPesquisada.SelectedText = "";
            this.tbPalavraPesquisada.Size = new System.Drawing.Size(313, 27);
            this.tbPalavraPesquisada.TabIndex = 40;
            this.tbPalavraPesquisada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPalavraPesquisada_KeyDown);
            // 
            // btnPesquisarDisciplina
            // 
            this.btnPesquisarDisciplina.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisarDisciplina.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDisciplina.ButtonImage")));
            this.btnPesquisarDisciplina.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPesquisarDisciplina.ButtonText = "PESQUISAR";
            this.btnPesquisarDisciplina.ClickBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisarDisciplina.ClickTextColor = System.Drawing.Color.White;
            this.btnPesquisarDisciplina.CornerRadius = 5;
            this.btnPesquisarDisciplina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarDisciplina.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPesquisarDisciplina.HoverBackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisarDisciplina.HoverTextColor = System.Drawing.Color.White;
            this.btnPesquisarDisciplina.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPesquisarDisciplina.Location = new System.Drawing.Point(330, 12);
            this.btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            this.btnPesquisarDisciplina.Size = new System.Drawing.Size(111, 28);
            this.btnPesquisarDisciplina.TabIndex = 41;
            this.btnPesquisarDisciplina.TextColor = System.Drawing.Color.White;
            this.btnPesquisarDisciplina.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPesquisarDisciplina.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // dataGridViewPesquisarDisciplina
            // 
            this.dataGridViewPesquisarDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisarDisciplina.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewPesquisarDisciplina.Name = "dataGridViewPesquisarDisciplina";
            this.dataGridViewPesquisarDisciplina.Size = new System.Drawing.Size(429, 180);
            this.dataGridViewPesquisarDisciplina.TabIndex = 42;
            // 
            // FormCarregarTelaDeBuscaDaDiscplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(454, 280);
            this.Controls.Add(this.dataGridViewPesquisarDisciplina);
            this.Controls.Add(this.btnPesquisarDisciplina);
            this.Controls.Add(this.tbPalavraPesquisada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCarregarTelaDeBuscaDaDiscplina";
            this.Text = "PESQUISAR DISCIPLINA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarDisciplina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tbPalavraPesquisada;
        private XanderUI.XUIButton btnPesquisarDisciplina;
        private System.Windows.Forms.DataGridView dataGridViewPesquisarDisciplina;
    }
}