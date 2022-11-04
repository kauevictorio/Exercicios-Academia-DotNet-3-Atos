namespace GestaoJogadores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nomeJogador = new System.Windows.Forms.Label();
            this.button_inserir = new System.Windows.Forms.Button();
            this.label_totalNomes = new System.Windows.Forms.Label();
            this.button_limparTudo = new System.Windows.Forms.Button();
            this.textBox_nomeJogador = new System.Windows.Forms.TextBox();
            this.textBox_listaJogador = new System.Windows.Forms.TextBox();
            this.label_ListaJogadores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nomeJogador
            // 
            this.label_nomeJogador.AutoSize = true;
            this.label_nomeJogador.Cursor = System.Windows.Forms.Cursors.No;
            this.label_nomeJogador.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nomeJogador.Location = new System.Drawing.Point(0, 12);
            this.label_nomeJogador.Name = "label_nomeJogador";
            this.label_nomeJogador.Size = new System.Drawing.Size(161, 23);
            this.label_nomeJogador.TabIndex = 0;
            this.label_nomeJogador.Text = "Nome Jogador:";
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(683, 9);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(105, 30);
            this.button_inserir.TabIndex = 3;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // label_totalNomes
            // 
            this.label_totalNomes.AutoSize = true;
            this.label_totalNomes.Location = new System.Drawing.Point(12, 317);
            this.label_totalNomes.Name = "label_totalNomes";
            this.label_totalNomes.Size = new System.Drawing.Size(82, 15);
            this.label_totalNomes.TabIndex = 4;
            this.label_totalNomes.Text = "Total Nomes 0";
            // 
            // button_limparTudo
            // 
            this.button_limparTudo.Location = new System.Drawing.Point(683, 45);
            this.button_limparTudo.Name = "button_limparTudo";
            this.button_limparTudo.Size = new System.Drawing.Size(105, 30);
            this.button_limparTudo.TabIndex = 5;
            this.button_limparTudo.Text = "Limpar";
            this.button_limparTudo.UseVisualStyleBackColor = true;
            this.button_limparTudo.Click += new System.EventHandler(this.button_limparTudo_Click);
            // 
            // textBox_nomeJogador
            // 
            this.textBox_nomeJogador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_nomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeJogador.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_nomeJogador.HideSelection = false;
            this.textBox_nomeJogador.Location = new System.Drawing.Point(167, 12);
            this.textBox_nomeJogador.Name = "textBox_nomeJogador";
            this.textBox_nomeJogador.Size = new System.Drawing.Size(510, 23);
            this.textBox_nomeJogador.TabIndex = 6;
            this.textBox_nomeJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_listaJogador
            // 
            this.textBox_listaJogador.Enabled = false;
            this.textBox_listaJogador.Location = new System.Drawing.Point(12, 101);
            this.textBox_listaJogador.Multiline = true;
            this.textBox_listaJogador.Name = "textBox_listaJogador";
            this.textBox_listaJogador.ReadOnly = true;
            this.textBox_listaJogador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaJogador.Size = new System.Drawing.Size(776, 203);
            this.textBox_listaJogador.TabIndex = 7;
            // 
            // label_ListaJogadores
            // 
            this.label_ListaJogadores.AutoSize = true;
            this.label_ListaJogadores.CausesValidation = false;
            this.label_ListaJogadores.Cursor = System.Windows.Forms.Cursors.No;
            this.label_ListaJogadores.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ListaJogadores.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_ListaJogadores.Location = new System.Drawing.Point(265, 78);
            this.label_ListaJogadores.Name = "label_ListaJogadores";
            this.label_ListaJogadores.Size = new System.Drawing.Size(201, 18);
            this.label_ListaJogadores.TabIndex = 8;
            this.label_ListaJogadores.Text = "Jogadores Cadastrados";
            this.label_ListaJogadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.label_ListaJogadores);
            this.Controls.Add(this.textBox_listaJogador);
            this.Controls.Add(this.textBox_nomeJogador);
            this.Controls.Add(this.button_limparTudo);
            this.Controls.Add(this.label_totalNomes);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.label_nomeJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cadastro de Jogadores";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_nomeJogador;
        private Button button_inserir;
        private Label label_totalNomes;
        private Button button_limparTudo;
        private TextBox textBox_nomeJogador;
        private TextBox textBox_listaJogador;
        private Label label_ListaJogadores;
    }
}