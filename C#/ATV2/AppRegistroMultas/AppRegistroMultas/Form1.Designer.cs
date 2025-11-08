namespace AppRegistroMultas
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
            this.btConsulta = new System.Windows.Forms.Button();
            this.btCadastroMulta = new System.Windows.Forms.Button();
            this.btCadastroVeiculo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(34, 128);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(471, 29);
            this.btConsulta.TabIndex = 32;
            this.btConsulta.Text = "CONSULTA DE MULTAS";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btCadastroMulta
            // 
            this.btCadastroMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroMulta.Location = new System.Drawing.Point(34, 85);
            this.btCadastroMulta.Name = "btCadastroMulta";
            this.btCadastroMulta.Size = new System.Drawing.Size(471, 29);
            this.btCadastroMulta.TabIndex = 31;
            this.btCadastroMulta.Text = "CADASTRO DE MULTAS";
            this.btCadastroMulta.UseVisualStyleBackColor = true;
            this.btCadastroMulta.Click += new System.EventHandler(this.btCadastroMulta_Click);
            // 
            // btCadastroVeiculo
            // 
            this.btCadastroVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroVeiculo.Location = new System.Drawing.Point(34, 39);
            this.btCadastroVeiculo.Name = "btCadastroVeiculo";
            this.btCadastroVeiculo.Size = new System.Drawing.Size(471, 29);
            this.btCadastroVeiculo.TabIndex = 30;
            this.btCadastroVeiculo.Text = "CADASTRAR VEÍCULOS";
            this.btCadastroVeiculo.UseVisualStyleBackColor = true;
            this.btCadastroVeiculo.Click += new System.EventHandler(this.btCadastroVeiculo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(471, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "EXCLUIR MULTAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(471, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "MODIFICAR MULTAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Yuri Gabriel - Marcus Rheuel - 2°B Informática";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btCadastroMulta);
            this.Controls.Add(this.btCadastroVeiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btCadastroMulta;
        private System.Windows.Forms.Button btCadastroVeiculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

