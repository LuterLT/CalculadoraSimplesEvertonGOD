namespace CalculadoraSimplesEvertonDeusSupremo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdicao = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonSinal = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonParenteses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.textBoxDisplay.Location = new System.Drawing.Point(21, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(424, 100);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(22, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(111, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(203, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplicacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMultiplicacao.Location = new System.Drawing.Point(291, 221);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(72, 70);
            this.buttonMultiplicacao.TabIndex = 4;
            this.buttonMultiplicacao.Text = "x";
            this.buttonMultiplicacao.UseVisualStyleBackColor = false;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(22, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(111, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(203, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 70);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonSubtracao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSubtracao.Location = new System.Drawing.Point(291, 307);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(72, 70);
            this.buttonSubtracao.TabIndex = 8;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = false;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(22, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 70);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(111, 393);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 70);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(203, 393);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 70);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonAdicao
            // 
            this.buttonAdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdicao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdicao.Location = new System.Drawing.Point(291, 393);
            this.buttonAdicao.Name = "buttonAdicao";
            this.buttonAdicao.Size = new System.Drawing.Size(72, 70);
            this.buttonAdicao.TabIndex = 12;
            this.buttonAdicao.Text = "+";
            this.buttonAdicao.UseVisualStyleBackColor = false;
            this.buttonAdicao.Click += new System.EventHandler(this.buttonAdicao_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button0.Location = new System.Drawing.Point(22, 478);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(72, 70);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVirgula.Location = new System.Drawing.Point(111, 478);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(72, 70);
            this.buttonVirgula.TabIndex = 14;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = false;
            this.buttonVirgula.Click += new System.EventHandler(this.buttonVirgula_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonBackspace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackspace.Location = new System.Drawing.Point(203, 478);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(72, 70);
            this.buttonBackspace.TabIndex = 15;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonResultado
            // 
            this.buttonResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResultado.Location = new System.Drawing.Point(291, 478);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(72, 70);
            this.buttonResultado.TabIndex = 16;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = false;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonDivisao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDivisao.Location = new System.Drawing.Point(291, 136);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(72, 70);
            this.buttonDivisao.TabIndex = 17;
            this.buttonDivisao.Text = "÷";
            this.buttonDivisao.UseVisualStyleBackColor = false;
            this.buttonDivisao.Click += new System.EventHandler(this.ButtonDivisao_Click);
            // 
            // buttonSinal
            // 
            this.buttonSinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonSinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSinal.Location = new System.Drawing.Point(203, 136);
            this.buttonSinal.Name = "buttonSinal";
            this.buttonSinal.Size = new System.Drawing.Size(72, 70);
            this.buttonSinal.TabIndex = 18;
            this.buttonSinal.Text = "+/-";
            this.buttonSinal.UseVisualStyleBackColor = false;
            this.buttonSinal.Click += new System.EventHandler(this.buttonSinal_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.35F, System.Drawing.FontStyle.Bold);
            this.buttonCopiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCopiar.Location = new System.Drawing.Point(111, 136);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(72, 70);
            this.buttonCopiar.TabIndex = 19;
            this.buttonCopiar.Text = "Ⓒ";
            this.buttonCopiar.UseVisualStyleBackColor = false;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonApagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonApagar.Location = new System.Drawing.Point(22, 136);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(72, 70);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.Text = "AC";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonParenteses
            // 
            this.buttonParenteses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonParenteses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonParenteses.Location = new System.Drawing.Point(373, 136);
            this.buttonParenteses.Name = "buttonParenteses";
            this.buttonParenteses.Size = new System.Drawing.Size(72, 410);
            this.buttonParenteses.TabIndex = 21;
            this.buttonParenteses.Text = "()";
            this.buttonParenteses.UseVisualStyleBackColor = false;
            this.buttonParenteses.Click += new System.EventHandler(this.buttonParenteses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(457, 558);
            this.Controls.Add(this.buttonParenteses);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonSinal);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonVirgula);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonAdicao);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora GODd+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdicao;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonSinal;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonParenteses;
    }
}

