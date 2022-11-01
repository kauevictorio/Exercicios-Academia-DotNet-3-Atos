namespace Exercicio_11
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_ListaNomes = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Nome.Size = new System.Drawing.Size(125, 21);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome Completo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 23);
            this.textBox1.TabIndex = 4;
            // 
            // txt_ListaNomes
            // 
            this.txt_ListaNomes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ListaNomes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ListaNomes.Location = new System.Drawing.Point(12, 151);
            this.txt_ListaNomes.Multiline = true;
            this.txt_ListaNomes.Name = "txt_ListaNomes";
            this.txt_ListaNomes.ReadOnly = true;
            this.txt_ListaNomes.Size = new System.Drawing.Size(163, 330);
            this.txt_ListaNomes.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(200, 151);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 330);
            this.textBox2.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(143, 53);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(423, 23);
            this.txt_Email.TabIndex = 7;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(12, 55);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 21);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "E-mail:";
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(396, 151);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 330);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 610);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_ListaNomes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label lbl_Nome;
        private TextBox textBox1;
        private TextBox txt_ListaNomes;
        private TextBox textBox2;
        private TextBox txt_Email;
        private Label lbl_Email;
        private TextBox textBox3;
    }
}