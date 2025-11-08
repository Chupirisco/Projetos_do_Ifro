namespace WindowsFormsAppControleDeEstoque
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
            this.btCadastrarSecao = new System.Windows.Forms.Button();
            this.btCadastrarProdutos = new System.Windows.Forms.Button();
            this.btPesquisarProdutos = new System.Windows.Forms.Button();
            this.btFiltrarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarSecao
            // 
            this.btCadastrarSecao.BackColor = System.Drawing.Color.Orange;
            this.btCadastrarSecao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarSecao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadastrarSecao.Location = new System.Drawing.Point(474, 100);
            this.btCadastrarSecao.Name = "btCadastrarSecao";
            this.btCadastrarSecao.Size = new System.Drawing.Size(120, 42);
            this.btCadastrarSecao.TabIndex = 0;
            this.btCadastrarSecao.Text = "Cadastrar Seção";
            this.btCadastrarSecao.UseVisualStyleBackColor = false;
            this.btCadastrarSecao.Click += new System.EventHandler(this.btCadastrarSecao_Click);
            // 
            // btCadastrarProdutos
            // 
            this.btCadastrarProdutos.BackColor = System.Drawing.Color.Orange;
            this.btCadastrarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarProdutos.Location = new System.Drawing.Point(173, 100);
            this.btCadastrarProdutos.Name = "btCadastrarProdutos";
            this.btCadastrarProdutos.Size = new System.Drawing.Size(120, 44);
            this.btCadastrarProdutos.TabIndex = 1;
            this.btCadastrarProdutos.Text = "Cadastrar Produto";
            this.btCadastrarProdutos.UseVisualStyleBackColor = false;
            this.btCadastrarProdutos.Click += new System.EventHandler(this.btCadastrarProdutos_Click);
            // 
            // btPesquisarProdutos
            // 
            this.btPesquisarProdutos.BackColor = System.Drawing.Color.YellowGreen;
            this.btPesquisarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisarProdutos.Location = new System.Drawing.Point(173, 173);
            this.btPesquisarProdutos.Name = "btPesquisarProdutos";
            this.btPesquisarProdutos.Size = new System.Drawing.Size(120, 45);
            this.btPesquisarProdutos.TabIndex = 3;
            this.btPesquisarProdutos.Text = "Listar Produtos";
            this.btPesquisarProdutos.UseVisualStyleBackColor = false;
            this.btPesquisarProdutos.Click += new System.EventHandler(this.btPesquisarProdutos_Click);
            // 
            // btFiltrarCategoria
            // 
            this.btFiltrarCategoria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btFiltrarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFiltrarCategoria.Location = new System.Drawing.Point(173, 242);
            this.btFiltrarCategoria.Name = "btFiltrarCategoria";
            this.btFiltrarCategoria.Size = new System.Drawing.Size(120, 45);
            this.btFiltrarCategoria.TabIndex = 4;
            this.btFiltrarCategoria.Text = "Alterar Produto";
            this.btFiltrarCategoria.UseVisualStyleBackColor = false;
            this.btFiltrarCategoria.Click += new System.EventHandler(this.btFiltrarCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTROLE DE ESTOQUE  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(763, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yuri Gabriel - Marcus Rheuel - Hugo Gustavo - Matheus Pedroso 2° B Informática";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(323, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar Categoria";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(323, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Listar Categorias";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(474, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Listar Seções";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(323, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Alterar Categoria";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(474, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 45);
            this.button5.TabIndex = 11;
            this.button5.Text = "Alterar Seção";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFiltrarCategoria);
            this.Controls.Add(this.btPesquisarProdutos);
            this.Controls.Add(this.btCadastrarProdutos);
            this.Controls.Add(this.btCadastrarSecao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarSecao;
        private System.Windows.Forms.Button btCadastrarProdutos;
        private System.Windows.Forms.Button btPesquisarProdutos;
        private System.Windows.Forms.Button btFiltrarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

